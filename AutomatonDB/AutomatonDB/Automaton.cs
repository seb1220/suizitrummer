using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomatonDB {
    [Serializable]
    internal class Automaton {
        private string description;

        public string Description {
            private set { description = value; }
            get { return description; }
        }

        private List<string> alphabet;
        private Dictionary<string, State> states;
        private State startState;

        public Automaton(string fileName) {
            states = new Dictionary<string, State>();
            alphabet = new List<string>();
            try {
                ReadFromFile(fileName);
            }
            catch (IOException e) {
                Console.WriteLine(e.Message);
            }
        }

        public bool AddState(string description, bool isEndState) {
            if (states.ContainsKey(description))
                return false;

            State s = new State(description, isEndState);
            states.Add(description, s);

            if (states.Count == 1)
                startState = s;

            return true;
        }

        public bool AddTransition(string description, string input, string successor) {
            State from = states[description];
            State to = states[successor];

            if (
                (from == null) ||
                (!alphabet.Contains(input)) ||
                (to == null)
            )
                return false;
            return from.AddTransition(input, to);
        }

        public bool Run(string[] input) {
            State s = startState;

            foreach (string i in input) {
                if (s == null)
                    return false;

                s = s.GetSuccessor(i);
            }

            return s.IsEndState;
        }

        public bool IsValid() {
            foreach (State s in states.Values)
                if (!s.IsValid(alphabet))
                    return false;

            return true;
        }

        public void ReadFromFile(string fileName) {
            string line;
            string[] parts;

            StreamReader sr = new StreamReader(fileName);
            Description = sr.ReadLine();
            parts = sr.ReadLine().Split('-');
            alphabet = new List<string>(parts);


            while (!sr.EndOfStream) {
                line = sr.ReadLine();
                if (line.Length == 0)
                    continue;

                if (!line.Contains("-")) {
                    if (line.StartsWith("(") && line.EndsWith(")"))
                        AddState(line.Substring(1, line.Length - 2), true);
                    else
                        AddState(line, false);
                }
                else {
                    parts = line.Split('-');
                    AddTransition(parts[0], parts[1], parts[2]);
                }
            }

            sr.Close();
        }


        public bool WriteIntoFile(string fileName) {
            try {
                StreamWriter sw = new StreamWriter(fileName);
                Print(sw);
                sw.Close();
                return true;
            }
            catch (IOException e) {
                return false;
            }
        }

        public bool WriteIntoDatabase() {
            try {
                Database.Connect();
                Database.PostAutomaton(description, states, startState, alphabet);
                Database.Disconnect();
                return true;
            }
            catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }
        
        public bool ReadFromDatabase(string desc) {
            try {
                // TODO: GetAutomaton, Factory Class ? Overloaded Constructor / Changed Constructor ?
                Database.Connect();
                Database.GetAutomaton(desc);
                Database.Disconnect();
                return true;
            }
            catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }

        public void Print() {
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            sw.AutoFlush = true;
            Console.SetOut(sw);
            Print(sw);
        }

        private void Print(StreamWriter sw) {
            sw.WriteLine(Description);
            for (int i = 0; i < alphabet.Count; i++) {
                sw.Write(alphabet[i]);
                if (i < alphabet.Count - 1)
                    sw.Write("-");
            }

            sw.WriteLine();

            string s;
            if (startState != null) {
                s = startState.Description;
                if (startState.IsEndState)
                    s = "(" + s + ")";
                sw.WriteLine(s);
            }

            foreach (string k in states.Keys) {
                if (startState == null || startState.Description == k) continue;
                s = k;
                if (states[s].IsEndState)
                    s = "(" + s + ")";

                sw.WriteLine(s);
            }

            foreach (string k in states.Keys)
                states[k].Print(sw);
        }
    }
}
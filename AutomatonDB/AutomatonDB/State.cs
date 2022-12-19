using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AutomatonDB {
    [Serializable]
    internal class State {
        private string description;
        private bool isEndState;
        private Dictionary<string, State> successors;

        public string Description {
            set { description = value; }
            get { return description; }
        }

        public bool IsEndState {
            set { isEndState = value; }
            get { return isEndState; }
        }

        public State(string description, bool isEndState) {
            Description = description;
            IsEndState = isEndState;
            successors = new Dictionary<string, State>();
        }

        public bool AddTransition(string input, State successor) {
            if (successors.ContainsKey(input))
                return false;

            successors.Add(input, successor);
            return true;
        }

        public State GetSuccessor(string input) {
            if (successors.ContainsKey(input))
                return successors[input];

            return null;
        }

        public bool IsValid(List<string> alphabet) {
            if (alphabet.Count != successors.Count)
                return false;

            foreach (string s in alphabet)
                if (!successors.ContainsKey(s))
                    return false;

            return true;
        }

        public void Print(StreamWriter sw) {
            foreach (string s in successors.Keys)
                sw.WriteLine(description + "-" + s + "-" + successors[s].Description);
        }
    }
}
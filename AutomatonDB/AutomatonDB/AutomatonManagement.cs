using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatonDB
{
    [Serializable]
    internal class AutomatonManagement
    {
        private Dictionary<string, Automaton> automatons;

        public AutomatonManagement()
        {
            automatons = new Dictionary<string, Automaton>();
        }

        public bool Add(Automaton a)
        {
            if (
                a?.Description != null &&
                (!automatons.ContainsKey(a.Description))
               )
            {
                automatons.Add(a.Description, a);
                return true;
            }

            return false;
        }

        public bool Print()
        {
            if (automatons.Count == 0)
                return false;


            foreach (Automaton a in automatons.Values)
            {
                a.Print();
                Console.WriteLine("\n----\n");
            }
            return true;
        }

        public bool Print(string description)
        {
            if (!automatons.ContainsKey(description))
                return false;

            automatons[description].Print();

            return true;
        }
        public bool WriteIntoFile(string description, string fileName)
        {
            if (!automatons.ContainsKey(description))
                return false;

            return automatons[description].WriteIntoFile(fileName);
        }
        
        public bool WriteToDatabase(string description)
        {
            if (!automatons.ContainsKey(description))
                return false;

            automatons[description].WriteIntoDatabase();
            
            return true;
        }

        public bool Remove(string description)
        {
            if (!automatons.ContainsKey(description))
                return false;

            automatons.Remove(description);

            return true;
        }

        public void Reset()
        {
            automatons = new Dictionary<string, Automaton>();
        }
    }
}

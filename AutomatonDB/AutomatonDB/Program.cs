using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace AutomatonDB {
    internal class Program {
        static void Main(string[] args) {
            AutomatonManagement am = new AutomatonManagement();
            //am.Add(new Automaton("a1.txt"));
            am.Add(Automaton.AutomatonFromFile("automat.txt"));
            am.Print();
            //am.WriteIntoFile("a1", "b1.txt");
            //Console.WriteLine(am.WriteToDatabase("automat"));
            //am.Add(Automaton.AutomatonFromDb("automat"));
            //am.Print();
        }
    }
}
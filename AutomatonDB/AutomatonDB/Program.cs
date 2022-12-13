using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatonDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutomatonManagement am = new AutomatonManagement();
            am.Add(new Automaton("a1.txt"));
            am.Add(new Automaton("automat.txt"));
            am.Print();
            am.WriteIntoFile("a1", "b1.txt");
        }
    }
}

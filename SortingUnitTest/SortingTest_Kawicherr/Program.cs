using System;

namespace SortingTest_Kawicher
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("nein man");

            Algorithms algorithms = new Algorithms();

            int min = 10;
            int max = 100;
            int count = 10;
            bool duplicates = false;
            algorithms.CreateRandoms(min, max, count, duplicates);

            algorithms.Print();
            
            Console.WriteLine(algorithms["82"]);
            
            Console.WriteLine("---");
            algorithms.QuickSort();
            algorithms.Print();
        }
    }
}


//    I   iiiiiiiiiiiiiiiii   iiiiiiiiiiiiiii
//    i   i               i                i
//    i   i               i               i
//    i   i               i              i
//    i   i               i             i
//    i   iiiiiiiiiiiiiiiii          iiiii
//    i   i               i           i
//    i   i               i          i
//    i   i               i         i
//    i   i               i        i
//    i   iiiiiiiiiiiiiiiii       i
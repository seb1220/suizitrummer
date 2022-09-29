using System;
using System.Collections;
using System.ComponentModel;

namespace test1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int[] ints = Array.ConvertAll(args, s => int.Parse(s));
                Array.Sort(ints);
                Console.WriteLine(String.Join(" ", ints));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                System.Environment.Exit(1);
            }
        }
    }
}

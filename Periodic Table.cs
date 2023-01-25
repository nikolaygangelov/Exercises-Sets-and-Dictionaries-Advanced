using System;
using System.Collections.Generic;

namespace _3._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());
            SortedSet<string> uniqueChemicals = new SortedSet<string>();

            for (int i = 0; i < count; i++)
            {
                string[] compounds = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < compounds.Length; j++)
                {
                    uniqueChemicals.Add(compounds[j]);
                }
                
            }

            Console.WriteLine(string.Join(' ', uniqueChemicals));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lengthsOfSets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            HashSet<int> setN = new HashSet<int>();
            HashSet<int> setM = new HashSet<int>();
            HashSet<int> setA = new HashSet<int>();

            int lengthOfN = lengthsOfSets[0];
            int lengthOfM = lengthsOfSets[1];

            for (int i = 0; i < lengthOfN; i++)
            {
                setN.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < lengthOfM; i++)
            {
                setM.Add(int.Parse(Console.ReadLine()));
            }

            if (setN.Count > setM.Count)
            {
                foreach (int element in setM)
                {
                    if (setN.Contains(element))
                    {
                        setA.Add(element);
                    }
                }
            }
            else if (setN.Count < setM.Count)
            {
                foreach (int element in setN)
                {
                    if (setM.Contains(element))
                    {
                        setA.Add(element);
                    }
                }
            }
            else if (setN.Count == setM.Count)
            {
                foreach (int element in setN)
                {
                    if (setM.Contains(element))
                    {
                        setA.Add(element);
                    }
                }
            }

            Console.WriteLine(string.Join(' ', setA));
        }
    }
}

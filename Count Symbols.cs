using System;
using System.Collections.Generic;

namespace _5._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> countOfOccurrences = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char currentLetter = text[i];
                if (!countOfOccurrences.ContainsKey(currentLetter))
                {
                    countOfOccurrences.Add(currentLetter, 0);
                }
                countOfOccurrences[currentLetter]++;
            }

            foreach (var (ch,count) in countOfOccurrences)
            {
                Console.WriteLine($"{ch}: {count} time/s");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());
            Dictionary<int, int> numberOfAppearances = new Dictionary<int, int>();

            for (int i = 0; i < count; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                if (!numberOfAppearances.ContainsKey(inputNumber))
                {
                    numberOfAppearances.Add(inputNumber, 0);
                }
                numberOfAppearances[inputNumber]++;

            }
            Console.WriteLine(string.Join(' ', numberOfAppearances
                .Where(v => v.Value % 2 == 0)
                .Select(n => n.Key)
                ));
            //.Values.Where(v => v % 2 == 0))
        }
    }
}

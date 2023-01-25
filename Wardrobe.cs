using System;
using System.Collections.Generic;

namespace _6._Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {

            int numberOfLines = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> colorClothes = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] clothesInput = Console.ReadLine()
                    .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                string color = clothesInput[0];

                if (!colorClothes.ContainsKey(color))
                {
                    colorClothes.Add(color, new Dictionary<string, int>());
                }

                for (int j = 1; j < clothesInput.Length; j++)
                {
                    string pieceOfclothes = clothesInput[j];

                    if (!colorClothes[color].ContainsKey(pieceOfclothes))
                    {
                        colorClothes[color].Add(pieceOfclothes, 0);
                    }
                    colorClothes[color][pieceOfclothes]++;//count of clothes
                }
            }
            string[] clothesToLookFor = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string searchedColor = clothesToLookFor[0];
            string searchedClothing = clothesToLookFor[1];

            foreach (var (color, wear) in colorClothes)
            {
                Console.WriteLine($"{color} clothes:");
                foreach (var (pieceOfClothing, count) in wear)
                {
                    if (searchedColor == color && searchedClothing == pieceOfClothing)
                    {
                        Console.WriteLine($"* {pieceOfClothing} - {count}  (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {pieceOfClothing} - {count}");
                    }

                }
            }
        }
    }
}

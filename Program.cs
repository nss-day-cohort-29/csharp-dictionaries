using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dictionary<string, int> languagesWithScore = new Dictionary<string, int>() {
                {"English", 4},
                {"Spanish", 0},
                {"C#", 4}
            };

            languagesWithScore.Add("JavaScript", 3);

            Console.WriteLine(languagesWithScore);
            PrintDictionary(languagesWithScore);

            Console.WriteLine("----------");

            languagesWithScore["Spanish"] = 1;
            languagesWithScore["French"] = 5;

            PrintDictionary(languagesWithScore);

            Console.WriteLine("----------");
            int frenchScore = languagesWithScore["French"];
            Console.WriteLine($"French: {frenchScore}");


            List<Dictionary<string, int>> langScoreList = new List<Dictionary<string, int>>();
            langScoreList.Add(languagesWithScore);

            Dictionary<string, int> languagesWithScore2 = new Dictionary<string, int>(){
                {"English", 5}
            };

            langScoreList.Add(languagesWithScore2);

            Console.WriteLine("-----------------");
            Console.WriteLine("Printing langScoreList");
            foreach(Dictionary<string, int> lang in langScoreList) {
                Console.WriteLine("----");
                PrintDictionary(lang);
            }
            Console.WriteLine("-----------------");

            if (languagesWithScore.ContainsValue(1))
            {
                Console.WriteLine("Yay!");
            }
            else
            {
                Console.WriteLine("BOO!");
            }

            Console.WriteLine();
            Console.WriteLine("------------------");

            Dictionary<string, Dictionary<string, int>> people = 
                new Dictionary<string, Dictionary<string, int>>() {
                    {
                        "Hunter", 
                        new Dictionary<string, int>() { {"French", 5} }
                    }, {
                        "Jordan",
                        new Dictionary<string, int>() { {"Spanish", 5}, {"English", 5} }
                    }
                };

            foreach(KeyValuePair<string, Dictionary<string, int>> kvp in people) {
                Console.WriteLine($"{kvp.Key}'s languages:");
                PrintDictionary(kvp.Value);
            }
        }

        static void PrintDictionary(Dictionary<string, int> dict)
        {
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
            }
        }
    }
}





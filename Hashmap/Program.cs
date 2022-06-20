using System;
using HashMapprogram;

namespace HashAndTrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hash Table Program Started");
            FrequencyOfWords<string, string> hash = new FrequencyOfWords<string, string>();
            Console.WriteLine("Frequency of words is:");
            hash.add("0", "vijayalakshmi");
            hash.add("1", "harsha");
            hash.add("2", "aarna");
            hash.add("3", "harsha");
            hash.add("4", "sony");
            hash.add("5", "sita");
            hash.getFrequencyOfWords();*/
            string phrase = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words = phrase.ToLower().Split(" ");
            var dist = words.Distinct();
            int length = 0;
            foreach (var word in dist)
                length++;
            HashMapprogram.FrequencyOfWords<string, int> map = new HashMapprogram.FrequencyOfWords<string, int>(length);
            int count = 1;
            foreach (string word in words)
            {
                if (map.ContainsKey(word))
                {
                    count = map.GetValue(word) + 1;
                    map.Remove(word);
                    map.Add(word, count);
                }
                else
                {
                    map.Add(word, 1);
                }
            }
            Console.WriteLine($"{"Frequency"} | {"Count"}\n");
            foreach (string key in dist)
            {
                Console.WriteLine($"{key} | {map.GetValue(key)}");
            }


        }


    }
    
}

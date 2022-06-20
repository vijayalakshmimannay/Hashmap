using System;
using HashMapprogram;

namespace HashAndTrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table Program Started");
            FrequencyOfWords<string, string> hash = new FrequencyOfWords<string, string>();
            Console.WriteLine("Frequency of words is:");
            hash.add("0", "vijayalakshmi");
            hash.add("1", "harsha");
            hash.add("2", "aarna");
            hash.add("3", "harsha");
            hash.add("4", "sony");
            hash.add("5", "sita");
            hash.getFrequencyOfWords();


        }
    }
}

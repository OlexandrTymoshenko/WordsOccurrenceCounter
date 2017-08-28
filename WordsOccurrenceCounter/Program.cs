using System;
using System.Collections.Generic;
using System.IO;

namespace WordsOccurrenceCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string inputText = string.Empty;
                Dictionary<string, int> wordOccurrence = new Dictionary<string, int>();

                using (StreamReader sr = new StreamReader(args[0]))
                {
                    inputText = sr.ReadToEnd();
                }
                string[] words = inputText.Split();
                foreach (string word in words)
                {
                    if (wordOccurrence.ContainsKey(word))
                    {
                        wordOccurrence[word]++;
                    }
                    else
                    {
                        wordOccurrence[word] = 1;
                    }
                }
                foreach (var item in wordOccurrence)
                {
                    Console.WriteLine($"{item.Key} {item.Value}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

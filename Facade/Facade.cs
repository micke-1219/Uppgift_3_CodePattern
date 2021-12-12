using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Facade
{
    public class Facade
    {
        public List<string> words = new();
        public void SaveWord()
        {
            Console.WriteLine("Enter the word you want to save");
            string word = Console.ReadLine();
            words.Add(word);
            Console.WriteLine("Word saved!");
        }
        public void LoadWord()
        {
            Console.WriteLine($"Enter the index of the word you want to load (number of words in list: {words.Count})");
            string input = Console.ReadLine();
            int index = Int32.Parse(input);
            try
            {
                Console.WriteLine($"Word loaded: {words[index]}");
            }
            catch
            {
                Console.WriteLine("Index out of range!");
            }
        }
    }
}

// See https://aka.ms/new-console-template for more information
namespace MySpace;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<string> words = new List<string>();

        Console.WriteLine("Enter words separated by spaces:");
        string input = Console.ReadLine();
        string[] tokens = input.Split(' ');
        foreach (string token in tokens)
        {
            words.Add(token);
        }

        for (int i = 0; i < words.Count; i++)
        {
            string word = words[i];
            if (!word.All(char.IsLetter))
            {
                words.RemoveAt(i);
                i--;
            }
        }

        Console.WriteLine("Number of words in the list: " + words.Count);
        Console.WriteLine("List of words:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}

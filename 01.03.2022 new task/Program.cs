using System;

namespace _01._03._2022_new_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "exTensiON claSSi staTIc OLMalIdiR";
            Console.WriteLine(word.isCapitalized());

            string text = "Salam usaqlar necesiniz ?";
            Console.WriteLine(text.SearchWord("ADFDS"));
        }
    }
}

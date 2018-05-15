using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really long text";
            var summary = SummarizeText(sentence, 20);
            Console.WriteLine(summary);

           
        }

        static string SummarizeText(string text, int maxCharacters)
        {
            if (text.Length < maxCharacters)
                return text;

            var words = text.Split(' '); // creates a string array
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;

                if (totalCharacters > maxCharacters)
                    break;
            }

            return String.Join(" ", summaryWords) + "...";
            
        }
    }
}

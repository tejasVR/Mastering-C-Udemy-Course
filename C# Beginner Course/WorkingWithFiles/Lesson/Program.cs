using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Tejas\Documents\Udemy\C# Learnings\WorkingWithFiles";

            File.Create(@"C:\Users\Tejas\Documents\Udemy\C# Learnings\WorkingWithFiles\Sample.txt");
            //File.Copy();

            var fileInfo = new FileInfo(path);
            //fileInfo.CopyTo()

            Directory.CreateDirectory(@"c:\Users\Tejas\Documents\TestFolder");

            // Exercises

            // 1 
            var content = File.ReadAllText(path);
            var wordArray = content.Split(' ');
            Console.WriteLine(wordArray.Length);


            // 2
            var content2 = File.ReadAllText(path);
            var wordArray2 = content.Split(' ');
            var longestWord = "";
            for (int i  = 0; i < wordArray2.Length - 1; i++)
            {
                if (wordArray2[i].Length > wordArray2[i + 1].Length)
                {
                    longestWord = wordArray2[i];
                } else
                {
                    longestWord = wordArray2[i+1];
                }
            }
            Console.WriteLine(wordArray.Length);

        }
    }
}

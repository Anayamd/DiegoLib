using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        StreamReader reader = File.OpenText(@"C:\txt\lorem.txt");
        string[] words = reader.ReadToEnd().Split();

        for (int i = 0; i < words.Length; i++)
        {
            // Console.WindowHeight = 80
            int leftOffSet = ((Console.WindowWidth - words[i].Trim().Length) / 2);
            int topOffSet = ((Console.WindowHeight / 2));
            Console.SetCursorPosition(leftOffSet, topOffSet);

            string word = words[i].Trim('.', ',');

            if (word.Length % 2 == 0)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if ((word.Length / 2 == j) || (word.Length / 2 == j + 1))
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.White;

                    Console.Write(word[j]);
                }
            }
            else
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if (((word.Length + 1) / 2) == j + 1)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.White;

                    Console.Write(word[j]);
                }
            }

            System.Threading.Thread.Sleep(400);
            Console.Clear();
        }

        Console.WriteLine("Texto terminado.");
        Console.ReadKey(true);
    }
}
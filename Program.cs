using System;

class Program
{
    static void Main(string[] args)
    {

        string words = "natan scs aksmc sdv sdkvmsdv";
        int i = 0, x = 5, y = 2, wordCount = 1;

        for (int j = 0; j < words.Length; j++)
        {
            if (words[j] == ' ')
            {
                wordCount++;
            }
        }
        if (x <= wordCount && x + y <= wordCount) 
        {
            wordCount = 1;
            i = 0;
            while (i < words.Length)
            {
                while (i < words.Length && words[i] != ' ')
                {
                    if (wordCount >= x && wordCount <= x + y - 1)
                    {
                        Console.Write($"{words[i]}");
                    }
                    i++;
                }
                if (wordCount >= x && wordCount <= x + y - 1 && y != 0) 
                {
                    Console.WriteLine();
                }
                wordCount++;
                if (i < words.Length)
                {
                    i++;
                }
            }
        }
        else if (x > wordCount)
        {
            Console.WriteLine("x is not valid");
        }
        else if (x + y > wordCount)
        {
            Console.WriteLine($"words from {x} to {x + y - 1} dont exist");
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Start();
    }

    static void FirstTask()
    {

        Console.WriteLine("Write sentence:");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');

        int count = 0;

        foreach (var word in words)
        {
            count++;
        }
        Console.WriteLine($"Words in sentence: {count}");
    }

    static void SecondTask()
    {
        Console.WriteLine("Write sentence:");
        string sentence = Console.ReadLine();

        int count = 0;
        string vowels = "aeiouy";

        foreach (char c in sentence)
        {
            if (vowels.Contains(c))
            {
               count++;
            }
        }

        Console.WriteLine($"Number of vowels: {count}");
    }

    static void Start()
    {
        FirstTask();
        SecondTask();
    }
}


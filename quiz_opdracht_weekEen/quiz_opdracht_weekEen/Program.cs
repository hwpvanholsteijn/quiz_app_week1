using quiz_opdracht_weekEen.Models;
using System;

namespace quiz_opdracht_weekEen
{
    class Program
    {
        static void Main(string[] args)
        {
            Question q = new Question();
            q.Difficulty = 4;

            Console.WriteLine(q.Difficulty);
            q.Difficulty = 3;
            Console.WriteLine(q.Difficulty);
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}

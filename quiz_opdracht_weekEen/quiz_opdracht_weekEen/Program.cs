using quiz_opdracht_weekEen.Models;
using System;

namespace quiz_opdracht_weekEen
{
    class Program
    {
        static void Main(string[] args)
        {
            QuizMaster qM = new QuizMaster();
            qM.PresentQuestion();
            Console.ReadKey();
        }
    }
}

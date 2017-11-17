using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace quiz_opdracht_weekEen.Models
{
    class Question
    {
        private int difficulty;

        public Question() { }

        public Question(string question,string awnser, int difficulty, string category) {
            this.Text = question;
            this.Awnser = awnser;
            this.Difficulty = difficulty;
            this.Category = category;
        }

        public string Text { get; set; }
        public string Awnser { get; set; }
        public int Difficulty
        {
            get { return difficulty; }
            set {
                switch (value) {
                    case 3: difficulty = 3; break;
                    case 2: difficulty = 2; break;
                    default: difficulty = 1; break;
                }
            }
        }
        public string Category { get; set; }

        public bool IsCorrect(string awnser) {
            return Awnser == awnser;
        }

        public void DisplayQuestion(Question q) {
            Console.WriteLine(q.Text + "");
            Console.Write("Jouw antwoord:  ");
            String inputLine = Console.ReadLine();
            Console.WriteLine(string.Format("Het antwoord dat je hebt gegeven is: {0}", q.IsCorrect(inputLine)));
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }
    }
}

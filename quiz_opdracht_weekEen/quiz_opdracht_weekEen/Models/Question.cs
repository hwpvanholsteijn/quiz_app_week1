using System;
using System.Collections.Generic;
using System.Text;

namespace quiz_opdracht_weekEen.Models
{
    class Question
    {
        private byte difficulty;

        public Question(string question,string awnser, byte difficulty, string category) {
            this.Text = question;
            this.Awnser = awnser;
            this.Difficulty = difficulty;
            this.Category = category;
        }

        public string Text { get; set; }
        public string Awnser { get; set; }
        public byte Difficulty
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
    }
}

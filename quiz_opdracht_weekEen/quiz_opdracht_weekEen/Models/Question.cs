using System;
using System.Collections.Generic;
using System.Text;

namespace quiz_opdracht_weekEen.Models
{
    class Question
    {
        private byte difficulty;

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
        public string Categorie { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace quiz_opdracht_weekEen.Models
{
    interface IQuestion
    {
        string Text { get; set; }
        string Awnser { get; set; }
        int Difficulty { get; set; }
        string Category { get; set; }
        void DisplayQuestion(Question question);
        bool IsCorrect(string awnser);
    }
}

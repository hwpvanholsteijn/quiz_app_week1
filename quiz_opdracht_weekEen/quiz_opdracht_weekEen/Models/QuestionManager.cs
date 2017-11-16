using System;
using System.Collections.Generic;
using System.Text;

namespace quiz_opdracht_weekEen.Models.Questions
{
    class QuestionManager
    {
        List<Question> questions = new List<Question>();

        public QuestionManager() {
            this.InitalizeQuestions();
        }

        private void InitalizeQuestions() {
            questions.Add(new Question {
                Text = "Wat is de hoofdstad van de Nederlandse Provincie Noord-Holland?",
                Awnser = "Haarlem",
                Difficulty = 1,
                Category = "Topografie"
            });

            questions.Add(new Question
            {
                Text = "Wat is de hoofdstad van de Nederlandse Provincie Groningen?",
                Awnser = "Groningen",
                Difficulty = 1,
                Category = "Topografie"
            });

            questions.Add(new Question
            {
                Text = "In welk Nederlands dorpje ligt het drielandenpunt",
                Awnser = "Vaals",
                Difficulty = 2,
                Category = "Topografie"
            });
        }

        public Queue<Question> RandomQuestions() {
            List<Question> d = new List<Question>();
            foreach (Question a in questions) {
                d.Add(a);
            }
            return this.QueAList(d);
        }

        public Queue<Question> QueAList(List<Question> col) {
            return new Queue<Question>(col);
        }


    }
}

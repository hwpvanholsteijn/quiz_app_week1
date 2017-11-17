using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace quiz_opdracht_weekEen.Models.Questions
{
    class QuestionManager
    {
        private List<Question> AllQuestions = new List<Question>();

        public QuestionManager() {
            this.InitalizeQuestions();
        }

        private void InitalizeQuestions() {

            AllQuestions.Add(new Question() {
                Text = "Wat is de hoofdstad van de Nederlandse Provincie Noord-Holland?",
                Awnser = "Haarlem",
                Difficulty = 1,
                Category = "Topografie"
            });

            AllQuestions.Add(new Question
            {
                Text = "Wat is de hoofdstad van de Nederlandse Provincie Groningen?",
                Awnser = "Groningen",
                Difficulty = 1,
                Category = "Topografie"
            });

            AllQuestions.Add(new Question
            {
                Text = "In welk Nederlands dorpje ligt het drielandenpunt?",
                Awnser = "Vaals",
                Difficulty = 2,
                Category = "Topografie"
            });

            AllQuestions.Add(new Question
            {
                Text = "Welke term wordt door het doorlopen van een lijst.",
                Awnser = "iteratie",
                Difficulty = 1,
                Category = "Programmeren"
            });
        }

        public List<Question> FilterQuestions(string category, int difficulty) {
            int diff; 
            switch (difficulty)
            {
                case 3: diff = 3; break;
                case 2: diff = 2; break;
                default: diff = 1; break;
            }

            var filterResult = AllQuestions.Where(q => q.Category.ToUpper() == category.ToUpper() && diff == q.Difficulty);
            return filterResult.ToList();
        }

        public Queue<Question> FilterdQuestionList(string category, int difficulty) {
            return this.QueAList(this.FilterQuestions(category, difficulty));
        }


        public Queue<Question> RandomQuestions() {
            List<Question> randomizedQuestions = new List<Question>();
            foreach (Question anQuestion in AllQuestions) {
                randomizedQuestions.Add(anQuestion);
            }
            return this.QueAList(randomizedQuestions);
        }

        public Queue<Question> QueAList(List<Question> col) {
            return new Queue<Question>(col);
        }
    }
}

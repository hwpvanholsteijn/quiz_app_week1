using quiz_opdracht_weekEen.Models.Questions;
using System;
using System.Collections.Generic;
using System.Text;

namespace quiz_opdracht_weekEen.Models
{
    class QuizMaster
    {
        private QuestionManager qMan = new QuestionManager();
        private Queue<Question> unAskedQuestions = new Queue<Question>();


        private void FillQuestions() {
            unAskedQuestions = qMan.RandomQuestions();
            //unAskedQuestions = qMan.FilterdQuestionList("Topografie", 1);
        }

        public void PresentQuestion()
        {
                this.FillQuestions();
                Console.WriteLine("An quiz");
                Console.WriteLine("----------------------------------------------------------------------------------------");
                this.PresentQuestion(unAskedQuestions.Dequeue());
        }

        public void PresentQuestion(Question q) {
            q.DisplayQuestion(q);
            if (unAskedQuestions.Count > 0)
            {
                this.PresentQuestion(unAskedQuestions.Dequeue());
            }
        }
    }
}

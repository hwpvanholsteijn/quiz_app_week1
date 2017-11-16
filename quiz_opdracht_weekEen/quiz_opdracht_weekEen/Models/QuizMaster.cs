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
        }

        public void PresentQuestion()
        {
                this.FillQuestions();
                this.PresentQuestion(unAskedQuestions.Dequeue());
        }

        public void PresentQuestion(Question q) {
            Console.WriteLine(q.Text+"\n");
            Console.Write("Jou antwoord:  ");
            String inputLine = Console.ReadLine();
            Console.WriteLine(string.Format("Het antwoord dat je hebt gegeven is: {0}", q.IsCorrect(inputLine)));
            if (unAskedQuestions.Count > 0)
            {
                this.PresentQuestion(unAskedQuestions.Dequeue());
            }
        }
    }
}

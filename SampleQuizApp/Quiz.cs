using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SampleQuizApp
{
    class Quiz
    {
        // Properties
        public string QuizType { get; set; } //This should probably be an enum 
        //public List<QuizQuestion> QuizQuestions { get; set; } = new List<QuizQuestion>();
        public List<QuizQuestion> QuestionBank { get; set; } = new List<QuizQuestion>();

        // Constructor gets the quiz type
        public Quiz()
        {
            // Initialize Question Bank
            for(var x = 0; x < 40; x++)
            {
                QuestionBank.Add(new QuizQuestion { Question = $"This is question number {x}", Answer = $"{x}", QuizType = x < 20 ? "A" : "B" });
            }
        }

        public List<QuizQuestion> GetRandomQuestionsFromBank(string type)
        {
            var questionSubSet = QuestionBank.Where(x => x.QuizType == type.ToUpper()).ToList();

            return GetRandomList(questionSubSet);
        }

        private List<QuizQuestion> GetRandomList(List<QuizQuestion> allQuestions)
        {
            var listToReturn = new List<QuizQuestion>();

            var rng = new Random();

            for(var x = 0; x < 10; x++)
            {
                //Returns the index of an array from 0 to 
                var index = rng.Next(allQuestions.Count);
                //Console.WriteLine($"index is {index} listCount is {allQuestions.Count}");
                listToReturn.Add(allQuestions[index]);
                allQuestions.RemoveAt(index);
            }

            return listToReturn;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestions, List<Question> questions)
            : base(time, numberOfQuestions, questions) { }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam:");
            int totalGrade = 0;

            foreach (var question in Questions)
            {
                question.Display();
                Console.WriteLine("Enter Your Answer (Enter the number of your choice):");
                int userAnswerId = int.Parse(Console.ReadLine());

                // Finding the answer based on user input
                var userAnswer = question.Answers.Find(a => a.AnswerId == userAnswerId);

                if (userAnswer != null)
                {
                    Console.WriteLine($"Your Answer => {userAnswer.AnswerText}");
                    Console.WriteLine($"Right Answer => {question.CorrectAnswer.AnswerText}");

                    if (question.CorrectAnswer.AnswerId == userAnswerId)
                    {
                        totalGrade += question.Mark;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Answer ID!");
                }

                Console.WriteLine("---");
            }

            Console.WriteLine($"Your Grade is {totalGrade} from {Questions.Count * Questions[0].Mark}");
            Console.WriteLine("Thank You");
        }
    }

}

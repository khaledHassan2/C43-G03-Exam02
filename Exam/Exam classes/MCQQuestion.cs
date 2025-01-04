using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class MCQQuestion : Question
    {
        public MCQQuestion(string body, int mark, List<Answer> answers, Answer correctAnswer)
            : base(body, mark, answers, correctAnswer) { }

        public override void Display()
        {
            Console.WriteLine("MCQ Question");
            Console.WriteLine($"Question Body: {Body}");
            Console.WriteLine($"Mark: {Mark}");
            Console.WriteLine("Choices of Question:");
            foreach (var answer in Answers)

            {
                Console.WriteLine($"{answer.AnswerId}: {answer.AnswerText}");
            }
        }
    }
}

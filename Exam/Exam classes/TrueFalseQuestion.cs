using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string body, int mark, List<Answer> answers, Answer correctAnswer)
            : base(body, mark, answers, correctAnswer) { }

        public override void Display()
        {
            Console.WriteLine($"True/False Question: {Body} (Mark: {Mark})");
            foreach (var answer in Answers)
                Console.WriteLine($"{answer.AnswerId}: {answer.AnswerText}");
        }
    }
}

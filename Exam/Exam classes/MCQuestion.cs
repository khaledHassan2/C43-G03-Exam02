using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class MCQuestion : Question
    {
        public override string Header => "MSQ Question";
        public MCQuestion()
        {
            Answers = new Answer[3];
        }
        public override void AddQ()
        {
            Console.WriteLine(Header);
            int mark;
            do
            {
                Console.WriteLine("Enter Question Mark");
                
            } while (!(int.TryParse(Console.ReadLine(), out mark) && (mark > 0)));
            Mark = mark;
            do
            {
                Console.WriteLine("Enter Question  Body");
                Body = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(Body));


            //Choices
            Console.WriteLine("Chices Of Question");

            for (int i = 0; i < Answers.Length; i++)
            {
                    Answers[i] = new Answer() { AnswerId = i + 1 };
                do
                {
                    Console.WriteLine($"Enter Chioce Number {i+1}");
                    Answers[i].AnswerText =  Console.ReadLine();


                } while (String.IsNullOrWhiteSpace(Answers[i].AnswerText));
               
            }
            int rightAnswer;
            do
            {
                Console.WriteLine("Enter Right Id");


            } while (!(int.TryParse(Console.ReadLine(), out rightAnswer)&&(rightAnswer is 1 or 2 or 3)));
            RightAnswer.AnswerId = rightAnswer;
            RightAnswer.AnswerText = Answers[rightAnswer - 1].AnswerText;
            Console.Clear();
        }
    }
}

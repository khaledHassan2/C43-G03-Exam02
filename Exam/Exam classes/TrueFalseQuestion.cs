using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
     class TrueFalseQuestion : Question
    {
        public override string Header => "True | False Question";

        public TrueFalseQuestion()
        {
            Answers = new Answer[2];
            Answers[0] = new Answer(1,("True"));
            Answers[1] = new Answer(2, ("False"));



        }

        public override void AddQ()
        {
        int mark;
            Console.WriteLine(Header);
            do
            {
                Console.WriteLine("Enter Question Mark");

            } while (!(int.TryParse(Console.ReadLine(),out mark)&&(mark>0)));
            Mark = mark;
            do
            {
                Console.WriteLine("Enter Question Body");
                Body = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(Body));
       
           

            int rightAnswer;
            do
            {
                Console.WriteLine("Enter The Right Answer (1 For True | 2 For False)");
               


            } while (!(int.TryParse(Console.ReadLine(), out rightAnswer) && (rightAnswer is 1 or 2)));
            RightAnswer.AnswerId= rightAnswer;
            RightAnswer.AnswerText = Answers[rightAnswer-1].AnswerText;
            Console.Clear();


        }

    }
}

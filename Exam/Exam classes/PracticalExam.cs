using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class PracticalExam : Exam
    {
        public PracticalExam(int _time, int _intnumberOfQuestions) :base(_time,_intnumberOfQuestions)
        {
            
        }
        public override void CreatListQue()
        {
            Questions=new MCQuestion[NumberOfQuestions];
            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i] = new MCQuestion();
                Questions[i].AddQ();
                Console.Clear();
            }
        }

        public override void ShowExam()
        {
            foreach (var item in Questions)
            {
                Console.WriteLine("-----------------------------------------");

                Console.WriteLine(item);
                //choices
                for (int i = 0; i < item.Answers.Length; i++)
                {
                    Console.WriteLine($"{i+1}- {item.Answers[i].AnswerText}");
                }
                Console.WriteLine("-----------------------------------------");

                int UserAnswerId;
                do
                {
                    Console.WriteLine("Enter Answer Id");
                    
                }while (!(int.TryParse(Console.ReadLine(), out UserAnswerId)&& UserAnswerId is 1 or 2 or 3));
                item.UserAnswer.AnswerId = UserAnswerId;
                item.UserAnswer.AnswerText = item.Answers[UserAnswerId - 1].AnswerText;
            }
            Console.Clear() ;

            int grade = 0, totalMarks = 0;
            for (int i = 0; i < Questions.LongLength; i++)
            {
                totalMarks += Questions[i].Mark;
                if (Questions[i].UserAnswer.AnswerId == Questions[i].RightAnswer.AnswerId)
                {
                    grade += Questions[i].Mark;
                }
                Console.WriteLine($"Question{i + 1}: {Questions[i].Body}");
                Console.WriteLine($"Right Answer{i + 1}: {Questions[i].RightAnswer.AnswerText}");
                Console.WriteLine($"Your Answer{i + 1}: {Questions[i].UserAnswer.AnswerText}");
                Console.WriteLine("==============================================");

            }
            Console.WriteLine($"Your Grade Is => {grade} For {totalMarks}");

        }

    }

}

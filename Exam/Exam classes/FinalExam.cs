using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class FinalExam : Exam
    {
        public FinalExam(int _time,int _numberOfQuestions):base(_time,_numberOfQuestions)
        {
            
        }
        public override void CreatListQue()
        {
            Questions=new Question[NumberOfQuestions];

            for (int i = 0; i < Questions.Length; i++)
            {
                int Choice;
                do
                {
                    Console.WriteLine("Enter The Type Of Question (1 For MSQ | 2 For Trur | False)");
                } while (!(int.TryParse(Console.ReadLine(),out Choice )&& (Choice is 1 or 2)));
                Console.Clear();

                if (Choice == 1)
                {
                    Questions[i] = new MCQuestion();
                    Questions[i].AddQ();
                }
                else {
                    Questions[i] = new TrueFalseQuestion();
                    Questions[i].AddQ();
                }
            }
        }

        public override void ShowExam()
        {
            //Question
            foreach (var question in Questions)
            {
                Console.WriteLine(question.Body);
                //Choices
                if (question.GetType() == typeof(MCQuestion))
                {
                    for (int i = 0; i < question.Answers.Length; i++)
                {
                    Console.WriteLine($"{i+1}- {question.Answers[i].AnswerText}");
                }

                }


                Console.WriteLine("================================");

                int UserAnswerId;
                if (question.GetType()==typeof(MCQuestion))
                {
                    do
                    {
                        Console.WriteLine("Enter Answer Id");

                    } while (!(int.TryParse(Console.ReadLine(), out UserAnswerId) && UserAnswerId is 1 or 2 or 3));
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Enter The Right Answer (1 For True | 2 For False)");

                    } while (!(int.TryParse(Console.ReadLine(), out UserAnswerId) && (UserAnswerId is 1 or 2 )));
                }
                question.UserAnswer.AnswerId = UserAnswerId;
                question.UserAnswer.AnswerText = question.Answers[UserAnswerId - 1].AnswerText;
            }
            Console.Clear();

            int grade=0, totalMarks = 0;
            for (int i = 0; i < Questions.LongLength; i++)
            {
                totalMarks += Questions[i].Mark;
                if (Questions[i].UserAnswer.AnswerId == Questions[i].RightAnswer.AnswerId)
                {
                    grade += Questions[i].Mark;
                }
                Console.WriteLine($"Question{i+1}: {Questions[i].Body}");
                Console.WriteLine($"Right Answer{i + 1}: {Questions[i].RightAnswer.AnswerText}");
                Console.WriteLine($"Your Answer{i + 1}: {Questions[i].UserAnswer.AnswerText}");
                Console.WriteLine("======================================");

            }
            Console.WriteLine($"Your Grade Is => {grade} For {totalMarks}");
        }
        
    }
}

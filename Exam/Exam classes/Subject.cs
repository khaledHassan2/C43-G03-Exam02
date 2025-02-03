using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Exam_classes
{
    internal class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam Exam { get; set; }
        public Subject(int _Id,string _Name)
        {
            Id= _Id;
            Name= _Name;
        }
        public void CreatExam()
        {
            int ExamType, Time, NumberOfQuestions;
            do
            {
                Console.WriteLine("Enter Type Of Exam (1 For Practical | 2 For Final)");
            }
            while (!(int.TryParse(Console.ReadLine(),out ExamType)&&(ExamType is 1 or 2)));

            
            do
            {
                Console.WriteLine("Enter Time Of Exam From (30 min To 180 min)");
            }
            while (!(int.TryParse(Console.ReadLine(), out Time) && (Time >=30 && Time <=180)));

            do
            {
                Console.WriteLine("Enter Number Of Question");
            }
            while (!(int.TryParse(Console.ReadLine(), out NumberOfQuestions) && (NumberOfQuestions is 1 or 2)));

            if (ExamType ==1)
            {
                Exam = new PracticalExam(Time, NumberOfQuestions);
            }
            else
            {
                Exam=new FinalExam(Time, NumberOfQuestions);
            }
            Exam.CreatListQue();
        }
    }
}

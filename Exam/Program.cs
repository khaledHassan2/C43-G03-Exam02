using Exam.Exam_classes;
using System.Diagnostics;

namespace Exam
{

    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1,"C#");
            subject.CreatExam();

            Console.Clear();

            char c;
            do
            {
                Console.WriteLine("Do You Want To Start Exan (y | n)");

            } while (!(char.TryParse(Console.ReadLine(),out c))&&(c =='y' || c=='n'));

            if (c=='y')

            {
                Console.Clear ();

                Stopwatch sw = Stopwatch.StartNew();  
                sw.Start();

                subject.Exam.ShowExam();

                sw.Stop();

                Console.WriteLine($"Time : {sw.Elapsed}");

            }
            Console.WriteLine("Thank You");
        }
    }
}


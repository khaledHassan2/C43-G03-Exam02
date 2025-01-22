namespace Exam
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Exam Type (1 for Final, 2 for Practical):");
            int examType = int.Parse(Console.ReadLine());

            int examTime;
            do
            {
                Console.WriteLine("Enter Exam Time (in minutes between 30 and 180):");
                examTime = int.Parse(Console.ReadLine());
                if (examTime < 30 || examTime > 180)
                {
                    Console.WriteLine("Invalid time! Please enter a value between 60 and 180.");
                }
            } while (examTime < 30 || examTime > 180);

            Console.WriteLine("Enter Number of Questions:");
            int numberOfQuestions = int.Parse(Console.ReadLine());

            var questions = new List<Question>();

            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.WriteLine($"Enter details for Question {i + 1}:");

                Console.WriteLine("Enter Question Type (1 for True/False, 2 for MCQ):");
                int questionType = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Question Body:");
                string body = Console.ReadLine();

                Console.WriteLine("Enter Question Mark:");
                int mark = int.Parse(Console.ReadLine());

                var answers = new List<Answer>();

                if (questionType == 1)
                {
                    answers.Add(new Answer(1, "True"));
                    answers.Add(new Answer(2, "False"));
                    Console.WriteLine("Enter Correct Answer (1 for True, 2 for False):");
                    int correctAnswerId = int.Parse(Console.ReadLine());
                    var correctAnswer = answers.Find(a => a.AnswerId == correctAnswerId);
                    questions.Add(new TrueFalseQuestion(body, mark, answers, correctAnswer));
                }
                else if (questionType == 2)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"Enter Choice Number {j + 1}:");
                        string answerText = Console.ReadLine();
                        answers.Add(new Answer(j + 1, answerText));
                    }

                    Console.WriteLine("Enter Correct Answer Id:");
                    int correctAnswerId = int.Parse(Console.ReadLine());
                    var correctAnswer = answers.Find(a => a.AnswerId == correctAnswerId);
                    questions.Add(new MCQQuestion(body, mark, answers, correctAnswer));
                }
            }

            // Ask if user wants to start the exam
            Console.WriteLine("Do you want to start the exam? (y/n):");
            string startExamResponse = Console.ReadLine();

            if (startExamResponse.ToLower() == "y")
            {
                Console.Clear();
                Exam exam;
                if (examType == 1)
                    exam = new FinalExam(examTime, numberOfQuestions, questions);
                else
                    exam = new PracticalExam(examTime, numberOfQuestions, questions);

                exam.ShowExam();
            }
            else
            {
                Console.WriteLine("Exam ended.");
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    abstract class Question
    {
        public string Body { get; set; }
        public int Mark { get; set; }
        public List<Answer> Answers { get; set; }
        public Answer CorrectAnswer { get; set; }

        public Question(string body, int mark, List<Answer> answers, Answer correctAnswer)
        {
            Body = body;
            Mark = mark;
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }

        public abstract void Display();
    }
}

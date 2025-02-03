﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    abstract class Question
    {
        public abstract string Header { get; }
        public string Body { get; set; }

        public int Mark { get; set; }
        public Answer[] Answers { get; set; }
        public Answer RightAnswer { get; set; }
        public Answer UserAnswer { get; set; }


        public Question()
        {
            RightAnswer=new Answer();
            UserAnswer=new Answer();
        }

        public abstract void AddQ();
        public override string ToString()
        {
            return $"Header: {Header}\nMark: {Mark}\nBody: {Body}\n";
        }
    }
}

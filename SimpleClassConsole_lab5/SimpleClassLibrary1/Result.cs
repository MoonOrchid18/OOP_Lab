﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleClassLibrary1
{
    class Result //presents the results of a session on one subject
    {
        public string Subject { set; get; }
        public string Teacher { set; get; }
        public int Points { set; get; }
        public Result() { }

        public Result(string subject, string teacher, int points)
        {
            Subject = subject;
            Teacher = teacher;
            Points = points;
        }
        public Result(Result res)
        {
            this.Subject = res.Subject;
            this.Teacher = res.Teacher;
            this.Points = res.Points;
        }
    }
}
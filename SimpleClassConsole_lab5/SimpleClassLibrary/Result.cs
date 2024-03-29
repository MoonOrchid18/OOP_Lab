﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleClassConsole;

namespace SimpleClassLibrary
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
    

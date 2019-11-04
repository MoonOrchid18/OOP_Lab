using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassLibrary
{
    class Student
    {
        public string Name { set; get; }
        public string Surname { set; get; }
        public string Group { set; get; }
        public int Year { set; get; }
        public Result[] Results { set; get; }//an array of session results, which is
                                             //an array of Result objects
        public Student() { }
        public Student(string name, string surname, string group, int year, Result[] results)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Year = year;
            Results = new Result[results.Count()];
            for (int i = 0; i < results.Count(); i++)
            {
                Results[i] = results[i];
            }
        }
        public double GetAveragePoints()//method which calculating AVG point
        {
            int sum = 0;
            for (int i = 0; i < Results.Count(); i++)
            {
                sum += Results[i].Points;
            }

            return (Double)sum / Results.Count();
        }

        public string GetBestSubject()//which returns the name of the subject by which
                                      //the student has the highest score among other subjects
        {
            int MaxPoint = 0;
            int MaxIndex = 0;
            for (int i = 0; i < Results.Count(); i++)
            {
                if (Results[i].Points > MaxPoint)
                {
                    MaxPoint = Results[i].Points;
                    MaxIndex = i;
                }
            }
            return Results[MaxIndex].Subject;
        }

        public string GetWorstSubject()//which returns the name of the subject for which the student
                                       // received the worst score.
        {
            int MinPoint = 21;
            int MinIndex = 0;
            for (int i = 0; i < Results.Count(); i++)
            {
                if (Results[i].Points < MinPoint)
                {
                    MinPoint = Results[i].Points;
                    MinIndex = i;
                }
            }
            return Results[MinIndex].Subject;
        }
    }
}

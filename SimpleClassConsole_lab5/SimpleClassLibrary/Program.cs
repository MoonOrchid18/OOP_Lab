using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleClassConsole;
namespace SimpleClassLibrary
{
    class Program
    {
        static Student[] ReadStudentsArray()//reads data from the keyboard and returns
                                            //an array of Student objects (n pieces);
        {
            string subject, teacher;
            int points;
            string name, surname, group;
            int year;

            int exam;

            Console.WriteLine("enter number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] students = new Student[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Student {i + 1}");
                Console.WriteLine("Enter name of the student: ");
                name = Console.ReadLine();

                Console.WriteLine("Enter surname of the student: ");
                surname = Console.ReadLine();

                Console.WriteLine("Enter student code group: ");
                group = Console.ReadLine();

                Console.WriteLine("Enter number of the course: ");
                year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How much exams pass this student? ");
                exam = Convert.ToInt32(Console.ReadLine());

                Result[] result = new Result[exam];
                for (int j = 0; j < exam; j++)
                {
                    Console.WriteLine($"Subject {j + 1}");
                    Console.WriteLine("Name of the subject: ");
                    subject = Console.ReadLine();
                    Console.WriteLine("name of the teacher: ");
                    teacher = Console.ReadLine();
                    Console.WriteLine("Rating: ");
                    points = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    result[j] = new Result(subject, teacher, points);
                }
                students[i] = new Student(name, surname, group, year, result);
            }
            return students;
        }

        static void PrintStudent(Student stude)//accepts a Student object and displays it;
        {
            Console.WriteLine($"Name: {stude.Name}");
            Console.WriteLine($"Surname: {stude.Surname}");
            Console.WriteLine($"Group: {stude.Group}");
            Console.WriteLine($"Course: {stude.Year}");

            for (int i = 0; i < stude.Results.Count(); i++)
            {
                Console.WriteLine($"Subject {i + 1}");
                Console.WriteLine($"Name of the subject: {stude.Results[i].Subject}");
                Console.WriteLine($"Name of the teacher: {stude.Results[i].Teacher}");
                Console.WriteLine($"Rating: {stude.Results[i].Points}");
            }
        }

        static void PrintStudents(Student[] student)//accepts an array of Students objects and displays it
        {
            for (int i = 0; i < student.Count(); i++)
            {
                Console.WriteLine($"Name: {student[i].Name}");
                Console.WriteLine($"Surname: {student[i].Surname}");
                Console.WriteLine($"Group: {student[i].Group}");
                Console.WriteLine($"Course: {student[i].Year}");

                for (int j = 0; j < student[i].Results.Count(); j++)
                {
                    Console.WriteLine($"Subject {j + 1}");
                    Console.WriteLine($"Name of the subject: {student[i].Results[j].Subject}");
                    Console.WriteLine($"Name of teacher: {student[i].Results[j].Teacher}");
                    Console.WriteLine($"Rating: {student[i].Results[j].Points}");
                }
            }
        }
        // Accepts an array of Student objects and returns 
        //the highest grade point average and the lowest grade
        //point average through out-parameters.
        static void GetStudentsInfo(Student[] student, out double MaxAveragePoint, out double MinAveragePoint)
        {
            MaxAveragePoint = 0;
            MinAveragePoint = 21;

            for (int i = 0; i < student.Count(); i++)
            {
                if (student[i].GetAveragePoints() > MaxAveragePoint)
                {
                    MaxAveragePoint = student[i].GetAveragePoints();
                }

                if (student[i].GetAveragePoints() < MinAveragePoint)
                {
                    MinAveragePoint = student[i].GetAveragePoints();
                }
            }
        }
        //accepts an array of Student-type objects 
        //and sorts it by the student's grade point average;
        static void SortStudentsByPoints(Student[] stude)
        {
            Array.Sort(stude, (s1, s2) => s1.GetAveragePoints().CompareTo(s2.GetAveragePoints()));
        }
        //Accepts an array of Student objects and sorts it 
        //by last name, if the last name is the same, 
        //then arrange the objects by name.
        static void SortStudentsByName(Student[] stude)
        {
            Array.Sort(stude, (s1, s2) => s1.Surname.CompareTo(s2.Surname));
        }
    }
}

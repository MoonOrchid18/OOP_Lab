using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Student : Abiturient
    {
        public int Kurs { set; get; }
        public string Group { set; get; }
        public string Fakultet { set; get; }
        public string NavchZaklad { set; get; }

        public Student() { }
        public Student(int kurs, string group, string fakultet, string navchZaklad, Abiturient abit) : base(abit)
        {
            Kurs = kurs;
            Group = group;
            Fakultet = fakultet;
            NavchZaklad = navchZaklad;
        }
        public Student(Student prevStudent) : base(prevAbit: prevStudent)
        {
            Kurs = prevStudent.Kurs;
            Group = prevStudent.Group;
            Fakultet = prevStudent.Fakultet;
            NavchZaklad = prevStudent.NavchZaklad;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("\nStudent");
            Console.WriteLine($"Kurs: {Kurs}");
            Console.WriteLine($"Gruppa: {Group}");
            Console.WriteLine($"Fakultet: {Fakultet}");
            Console.WriteLine($"NavchZaklad: {NavchZaklad}");
        }
    }
}

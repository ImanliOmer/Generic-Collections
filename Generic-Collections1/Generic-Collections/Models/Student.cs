using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections.Models
{
    internal class Student
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Point { get; set; }

        public Student(string name,string surname,int point)
        {
            Name = name;
            Surname = surname;
            Point = point;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}\n" +
                $"Name: {Name}\n" +
                $"surname: {Surname}\n" +
                $"Age: {Age}\n" +
                $"Point: {Point}");
        }

        public static bool operator >(Student p1,Student p2)
        {
            return p1.Point > p2.Point;
        }
        public static bool operator <(Student p1, Student p2)
        {
            return p1.Point < p2.Point;
        }


       


    }
}

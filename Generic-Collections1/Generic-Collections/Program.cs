using Generic_Collections.Models;
using System;

namespace Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student("Cabbarov", "Elnur", 17);
            Student stu1 = new Student("Suleyman", "Suleymanli", 18);
            Student stu2 = new Student("Huseyn", "Elizade", 18);
            Student stu3 = new Student("Mehdi", "Mehdiyev", 18);

            Group qrup = new Group("pp111");

            qrup.AddStudent(stu);
            qrup.AddStudent(stu1);
            qrup.AddStudent(stu2);
            qrup.AddStudent(stu3);

            Console.WriteLine("\nTelebelerin siyahisi");
            qrup.GetAllStudents();

            Console.WriteLine("\nSort siyahisi");
            qrup.Sort();
        }
    }
}

using Generic_Collections.ExxHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Generic_Collections.Models
{
    internal class Group
    {
        private static int _groupNo = -1;
        public string GroupNo { get; }



        Regex regex = new Regex(@"([a-zA-Z]+)(\d+)");

        private Student[] students;
        private Student[] students2;


        public Group(string groupno)
        {
            students = new Student[0];
            GroupNo = groupno;
            _groupNo++;
            Match result = regex.Match(GroupNo);
            string word = result.Groups[1].Value;
            int num = int.Parse(result.Groups[2].Value);
            GroupNo = word + (_groupNo + num);

        }


        public void AddStudent(Student stu)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = stu;
            Console.WriteLine($"Student:{stu.Name} has been added to:{GroupNo} group !");
            students2 = students;
            return;
        }
        public void GetAllStudents()
        {
            foreach (Student stu in students)
            {
                Console.WriteLine(stu);
            }
        }
        public void Sort()
        {
            students2.PointSort();
            foreach (Student stu2 in students2)
            {
                Console.WriteLine(stu2);
            }
        }



    }
}

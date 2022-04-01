using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections.Models
{
    internal class Group
    {
        private int _no;
        private static Student[] student;

        public int No{ get; }
        public Group(int no)
        {
            No = no;
        }     
        public Group()
        {
            No++;
            _no=No;
        }
        public static Student[] createArray()
        {


            return student;

        }


    }
}

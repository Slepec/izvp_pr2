using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izvp_pr2
{
    public class Student
    {
        string name;
        int[] grades;

        public Student(string name, int[] grades)
        {
            this.name = name;
            this.grades = grades;
        }

        public string Name { get => name; set => name = value; }
        public int[] Grades { get => grades; set => grades = value; }
    }
}

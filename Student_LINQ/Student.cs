using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Student_LINQ
{
    public class Student
    {
        public int id { set; get; }
        public string firstName { set; get; }
        public string lastName { set; get; }
        public string middleName { set; get; }
        public string group { set; get; }
        public int averageScore { set; get; }
        public bool scholarship { set; get; }
        public Student(int id, string firstName, string lastName, string middleName, string group, int averageScore, bool scolarship)
        {
            this.id = id; this.firstName = firstName; this.lastName = lastName; this.middleName = middleName;
            this.group = group; this.averageScore = averageScore; this.scholarship = scolarship;
        }
    }
}
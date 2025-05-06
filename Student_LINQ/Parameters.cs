using PasswordManager_WinForms;
using System.CodeDom.Compiler;
using System.Linq;

namespace Student_LINQ
{
    public partial class ParametersForm : Form
    {
        static Student[] students = new Student[10]
 {
    new Student(1, "Alexander", "Ivanov", "Petrovich", "IT-101", 85, true),
    new Student(2, "Maria", "Koval", "Ivanovna", "IT-101", 78, false),
    new Student(3, "Andrew", "Shevchenko", "Olehovich", "IT-102", 92, true),
    new Student(4, "Irene", "Melnyk", "Borysivna", "IT-102", 67, false),
    new Student(5, "Dmytro", "Syvorenko", "Vasylovych", "IT-103", 88, true),
    new Student(6, "Catherine", "Lysenko", "Andriivna", "IT-103", 73, false),
    new Student(7, "Bogdan", "Romanyuk", "Yuriiovych", "IT-104", 95, true),
    new Student(8, "Olga", "Tkachenko", "Sergiivna", "IT-104", 80, true),
    new Student(9, "Natalia", "Hrytsenko", "Mykolaivna", "IT-105", 69, false),
    new Student(10, "Eugene", "Zakharchenko", "Ihorovych", "IT-105", 90, true)
 };
        public ParametersForm()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Student[] sortedStudents;

            if (radioButtonId.Checked)
            {
                sortedStudents = students.OrderBy(s => s.id).ToArray();
            }
            else if (radioButtonFirstName.Checked)
            {
                sortedStudents = students.OrderBy(s => s.firstName).ToArray();
            }
            else
            {
                sortedStudents = students.OrderBy(s => s.averageScore).ToArray();
            }
            ShowResults(sortedStudents);
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            Student[] groupedStudents;

            if (radioButtonId.Checked)
            {
                groupedStudents = students.GroupBy(s => s.id).SelectMany(s => s).ToArray();
            }
            else if (radioButtonFirstName.Checked)
            {
                groupedStudents = students.GroupBy(s => s.firstName).SelectMany(s => s).ToArray();
            }
            else
            {
                groupedStudents = students.GroupBy(s => s.averageScore).SelectMany(s => s).ToArray();
            }
            ShowResults(groupedStudents);
        }

        private void btnFillter_Click(object sender, EventArgs e)
        {
            Student[] filteredStudents;

            if (radioButtonId.Checked)
            {
                filteredStudents = students.Where(s => s.id < 5).ToArray();
            }
            else if (radioButtonFirstName.Checked)
            {
                filteredStudents = students.Where(s => s.firstName.StartsWith("A")).ToArray();
            }
            else
            {
                filteredStudents = students.Where(s => s.averageScore < 80).ToArray();
            }

            ShowResults(filteredStudents);
        }

        private void btnAgreg_Click(object sender, EventArgs e)
        {
            double res;
            if (radioButtonId.Checked)
            {
                res = students.Average(s => s.id);
            }
            else if (radioButtonFirstName.Checked)
            {
                res = students.Max(s => s.firstName.Length);
            }
            else
            {
                res = students.Average(s => s.averageScore);
            }
            textBox1.Text = res.ToString();
        }

        private void ShowResults(Student[] students)
        {
            Result result = new Result(students);
            result.ShowDialog();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowResults(students);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (Char)Keys.None;
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            Cmp cmp = new Cmp();
            cmp.ShowDialog();
        }
    }
}
using BAL_School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolWebForm
{
    public partial class Student : System.Web.UI.Page
    {
        Studentmethod method = null;
        public Student()
        {
            method = new Studentmethod();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Student_BAL> list = method.GetAllStudents();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Student_BAL s = new Student_BAL();
            s.StudentID= Convert.ToInt32(TextBox1.Text);
            s.StudentName = TextBox2.Text.ToString();
            s.ClassID = Convert.ToInt32(TextBox3.Text);
            s.Address= TextBox4.Text.ToString();
            s.Email= TextBox5.Text.ToString();
            method.AddStudent(s);
            List<Student_BAL> list1 = method.GetAllStudents();
            GridView1.DataSource = list1;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Student_BAL s = new Student_BAL();
            s.StudentID = Convert.ToInt32(TextBox1.Text);
            s.StudentName = TextBox2.Text.ToString();
            s.ClassID = Convert.ToInt32(TextBox3.Text);
            s.Address = TextBox4.Text.ToString();
            s.Email = TextBox5.Text.ToString();
            method.UpdateStudent(s);
            List<Student_BAL> list1 = method.GetAllStudents();
            GridView1.DataSource = list1;
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Student_BAL s = new Student_BAL();
            s.StudentID = Convert.ToInt32(TextBox1.Text);
            s.StudentName = TextBox2.Text.ToString();
            s.ClassID = Convert.ToInt32(TextBox3.Text);
            s.Address = TextBox4.Text.ToString();
            s.Email = TextBox5.Text.ToString();
            method.RemoveStudent(s.StudentID);
            List<Student_BAL> list1 = method.GetAllStudents();
            GridView1.DataSource = list1;
            GridView1.DataBind();
        }
    }
}
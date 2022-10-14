using BAL_School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolWebForm
{
    public partial class Subject : System.Web.UI.Page
    {
        SubjectMethods method = null;
        public Subject()
        {
            method = new SubjectMethods();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Subject_BAL> list = method.Subjectlist();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Subject_BAL s = new Subject_BAL();
            s.SubjectID= Convert.ToInt32(TextBox1.Text);
            s.SubjectName = TextBox2.Text.ToString();
            s.ClassID = Convert.ToInt32(TextBox3.Text);
            method.AddSubject(s);
            List<Subject_BAL> list1 = method.Subjectlist();
            GridView1.DataSource = list1;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Subject_BAL s = new Subject_BAL();
            s.SubjectID = Convert.ToInt32(TextBox1.Text);
            s.SubjectName = TextBox2.Text.ToString();
            s.ClassID = Convert.ToInt32(TextBox3.Text);
            method.Updatesubject(s);
            List<Subject_BAL> list1 = method.Subjectlist();
            GridView1.DataSource = list1;
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Subject_BAL s = new Subject_BAL();
            s.SubjectID = Convert.ToInt32(TextBox1.Text);
            s.SubjectName = TextBox2.Text.ToString();
            s.ClassID = Convert.ToInt32(TextBox3.Text);
            method.RemoveSubject(s.SubjectID);
            List<Subject_BAL> list1 = method.Subjectlist();
            GridView1.DataSource = list1;
            GridView1.DataBind();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL_School;
using DAL_School;

namespace SchoolWebForm
{
    public partial class Class : System.Web.UI.Page
    {
        Classmethod method = null;
        public Class()
        {
            method=new Classmethod();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Class_BAL> list = method.GetAllClasses();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Class_BAL c = new Class_BAL();
            c.ClassID = Convert.ToInt32(TextBox1.Text);
            c.ClassName = TextBox2.Text.ToString();
            method.AddClass(c);
            List<Class_BAL> list1 = method.GetAllClasses();
            GridView1.DataSource = list1;
            GridView1.DataBind();
        }
        
     
        protected void Button3_Click(object sender, EventArgs e)
        {

            Class_BAL c = new Class_BAL();
            c.ClassID = Convert.ToInt32(TextBox1.Text);
            c.ClassName = TextBox2.Text.ToString();
            method.UpdateClass(c);
            List<Class_BAL> list1 = method.GetAllClasses();
            GridView1.DataSource = list1;
            GridView1.DataBind();
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Class_BAL c = new Class_BAL();
            c.ClassID = Convert.ToInt32(TextBox1.Text);
            c.ClassName = TextBox2.Text.ToString();
            method.RemoveClass(c.ClassID);
            List<Class_BAL> list1 = method.GetAllClasses();
            GridView1.DataSource = list1;
            GridView1.DataBind();
        }
    }
}
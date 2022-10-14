using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL_School
{
    public class Class_BAL
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
    }
    public class Student_BAL
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int ClassID { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

    }
    public class Subject_BAL
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public int ClassID { get; set; }
    }
}

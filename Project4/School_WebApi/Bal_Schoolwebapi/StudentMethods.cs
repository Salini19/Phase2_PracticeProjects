using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_SchoolWebapi;

namespace Bal_Schoolwebapi
{
    public class StudentMethods
    {
        SchoolEntities context = null;
        public StudentMethods()
        {
            context = new SchoolEntities();
        }
        public bool AddSubMarks(Student s)
        {
            try
            {
                context.Students.Add(s);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }
        public bool UpdateSubMarks(int id,Student s)
        {
            try
            {
                List<Student> list = context.Students.ToList();
                Student s1= list.Find(x => x.StudentId == id);
                s1.StudentId = s.StudentId;
                s1.StudentName = s.StudentName;
                s1.Address = s.Address;
                s1.Email = s.Email;
                s1.subject = s.subject;
                s1.Classid = s.Classid;
                s1.Marks = s.Marks;

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public Student FindSubMarks(int id)
        {
            List<Student> list = context.Students.ToList();
            Student s1 = list.Find(x => x.StudentId == id);
            return s1;
        }
        public bool DeleteSubMarks(int id)
        {
            try
            {
                List<Student> list = context.Students.ToList();
                Student s1 = list.Find(x => x.StudentId == id);
                context.Students.Remove(s1);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public List<Student> Showlist()
        {
            List<Student> list = context.Students.ToList();
            return list;
        }
    }
}

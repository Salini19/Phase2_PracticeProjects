using DAL_School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace BAL_School
{
    public class Classmethod
    {
        public void AddClass(Class_BAL c)
        {
            SchoolEntities context = new SchoolEntities();
            Class c1 = new Class();
            c.ClassID = c1.Classid;
            c.ClassName = c1.ClassName;

            context.Classes.Add(c1);
            context.SaveChanges();


        }
        public bool RemoveClass(int id)
        {
            SchoolEntities context = new SchoolEntities();
            List<Class> m1 = context.Classes.ToList();
            Class s2 = m1.Find(m => m.Classid == id);
            if (s2 != null)
            {
                context.Classes.Remove(s2);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void UpdateClass(Class_BAL c)
        {
            SchoolEntities context = new SchoolEntities();
            List<Class> m1 = context.Classes.ToList();
            Class s2 = m1.Find(m => m.Classid == c.ClassID);
            s2.Classid = c.ClassID;
            s2.ClassName = c.ClassName;
            context.SaveChanges();
        }
        public List<Class_BAL> GetAllClasses()
        {
            SchoolEntities context = new SchoolEntities();
            List<Class_BAL> s = new List<Class_BAL>();
            List<Class> m1 = context.Classes.ToList();
            foreach (var item in m1)
            {
                s.Add(new Class_BAL
                {
                    ClassID = item.Classid,
                    ClassName = item.ClassName
                });
            }
            return s;
        }

    }
    public class Studentmethod
    {
        public void AddStudent(Student_BAL s)
        {
            SchoolEntities context = new SchoolEntities();
            Student s1 = new Student();
            s1.StudentId = s.StudentID;
            s1.StudentName = s.StudentName;
            s1.Address = s.Address;
            s1.Email = s.Email;
            s1.Classid = s.ClassID;
            context.Students.Add(s1);
            context.SaveChanges();

        }
        public void RemoveStudent(int id)
        {
            SchoolEntities context = new SchoolEntities();
            List<Student> s = context.Students.ToList();
            Student s1 = s.Find(m => m.StudentId== id);
            context.Students.Remove(s1);
            context.SaveChanges();
        }
        public void UpdateStudent(Student_BAL s2)
        {
            SchoolEntities context = new SchoolEntities();
            List<Student> s = context.Students.ToList();
            Student s1 = s.Find(m => m.StudentId == s2.StudentID);
            s1.StudentId = s2.StudentID;
            s1.StudentName = s2.StudentName;
            s1.Address= s2.Address;
            s1.Email = s2.Email;
            s1.Classid = s2.ClassID;
            context.SaveChanges();
        }
        public List<Student_BAL> GetAllStudents()
        {
            SchoolEntities context = new SchoolEntities();
            List<Student_BAL> s = new List<Student_BAL>();
            List<Student> s1 = context.Students.ToList();
            foreach (var item in s1)
            {
                s.Add(
                    new Student_BAL
                    {
                        StudentID = item.StudentId,
                        StudentName = item.StudentName,
                        Address = item.Address,
                        Email=item.Email,
                        ClassID=(int)item.Classid

                    }
                );
                
                
            }
            return s;
        }
    }
    public class SubjectMethods
    {
        public void AddSubject(Subject_BAL s)
        {
            SchoolEntities context = new SchoolEntities();
            subject s1 = new subject();
            s1.SubjectId = s.SubjectID;
            s1.SubjectName = s.SubjectName;
            s1.classId = s.ClassID;
            context.subjects.Add(s1);
            context.SaveChanges();

        }
        public void RemoveSubject(int id)
        {
            SchoolEntities context = new SchoolEntities();
            List<subject> s1 = context.subjects.ToList();
            subject s2 = s1.Find(m => m.SubjectId == id);
            context.subjects.Remove(s2);
            context.SaveChanges();
        }
        public void Updatesubject(Subject_BAL s)
        {
            SchoolEntities context = new SchoolEntities();
            List<subject> s1 = context.subjects.ToList();
            subject s2 = s1.Find(m => m.SubjectId == s.SubjectID);
            s2.SubjectId = s.SubjectID;
            s2.SubjectName = s.SubjectName;
            s2.classId = s.ClassID;
            context.SaveChanges();

        }
        public List<Subject_BAL> Subjectlist()
        {
            SchoolEntities context = new SchoolEntities();
            List<Subject_BAL> s1 = new List<Subject_BAL>();
            List<subject> s = context.subjects.ToList();
            foreach (var item in s)
            {
                s1.Add(
                    new Subject_BAL
                    {
                        SubjectID = item.SubjectId,
                        SubjectName = item.SubjectName,
                        ClassID = (int)item.classId
                    }); ;
            }
            return s1;
        }
    }
}

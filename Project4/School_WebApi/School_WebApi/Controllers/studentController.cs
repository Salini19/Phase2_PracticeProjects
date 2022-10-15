using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL_SchoolWebapi;
using Bal_Schoolwebapi;
using School_WebApi.Models;
using System.Data.Entity.Core.Metadata.Edm;

namespace School_WebApi.Controllers
{
    public class studentController : ApiController
    {
        StudentMethods methods = null;
        public studentController()
        {
            methods = new StudentMethods();
        }
        // GET api/<controller>
        public List<studModel> GetList()
        {
            List<Student> slist= methods.Showlist();
            List<studModel> list = new List<studModel>();
            foreach (var item in slist)
            {
                
                list.Add(new studModel {
                    StudentId = item.StudentId,
                    StudentName = item.StudentName,
                    Address = item.Address,
                    Email = item.Email,
                    Classid = item.Classid,
                    subject = item.subject,
                    Marks = item.Marks
                });

            }
            return list;
        }

        // GET api/<controller>/5
        public studModel GetById(int id)
        {
            Student s= methods.FindSubMarks(id);
            studModel s1 = new studModel();
            s1.StudentId = s.StudentId;
            s1.StudentName = s.StudentName;
            s1.Address = s.Address;
            s1.Email = s.Email;
            s1.Classid = s.Classid;
            s1.subject = s.subject;
            s1.Marks = s.Marks;
            return s1;
        }

        // POST api/<controller>
        public HttpResponseMessage PostStud([FromBody] studModel s)
        {
            Student s1 = new Student();
            s1.StudentId = s.StudentId;
            s1.StudentName = s.StudentName;
            s1.Address = s.Address;
            s1.Email = s.Email;
            s1.Classid = s.Classid;
            s1.subject = s.subject;
            s1.Marks = s.Marks;

            bool ans = methods.AddSubMarks(s1);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);

            }
        }

        // PUT api/<controller>/5
        public HttpResponseMessage PutStud(int id, [FromBody] studModel s)
        {
            Student s1 = new Student();
            s1.StudentId = id;
            s1.StudentName = s.StudentName;
            s1.Address = s.Address;
            s1.Email = s.Email;
            s1.Classid = s.Classid;
            s1.subject = s.subject;
            s1.Marks = s.Marks;

            bool ans=methods.UpdateSubMarks(id, s1);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);

            }
        }

        // DELETE api/<controller>/5
        public HttpResponseMessage DeleteStud(int id)
        {
            bool ans=methods.DeleteSubMarks(id);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School_WebApi.Models
{
    public class studModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public Nullable<int> Classid { get; set; }
        public string subject { get; set; }
        public Nullable<decimal> Marks { get; set; }
    }
}
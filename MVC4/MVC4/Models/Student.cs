using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC4.Models
{
    public class Student
    {
        public Student()
        {

        }
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height  { get; set; }
        public float weight { get; set; }

        public Standard Standard { get; set; }
    }
}
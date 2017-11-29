using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolWeb.Models
{
    public class Student:User
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
    }
}
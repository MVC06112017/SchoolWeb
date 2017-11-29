using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolWeb.Models
{
    public class Teacher:User
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Class { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
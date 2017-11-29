using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolWeb.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        public DateTime AssessmentDate { get; set; }
        public string Assessment { get; set; }
        public string SubjectName { get; set; }
        public string Comments { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

    }
}

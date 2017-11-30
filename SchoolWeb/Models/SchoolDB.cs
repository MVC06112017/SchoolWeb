using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SchoolWeb.Models
{
    public class SchoolDB:DbContext 
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

//        public SchoolDB() => Database.SetInitializer(new SchoolInitializer());
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolWeb.Models
{
    public class SchoolInitializer : DropCreateDatabaseAlways<SchoolDB>
    {
        protected override void Seed(SchoolDB context)
        {
            var teachers = new List<Teacher>()
            {
                new Teacher() { UserName = "vallee", Password = "password99", FirstName = "Esther", LastName = "Valle", Class = "3C" },
                new Teacher() { UserName = "waited", Password = "password99", FirstName = "David", LastName = "Waite", Class = "4B" },
                new Teacher() { UserName = "newmanb", Password = "password99", FirstName = "Belinda", LastName = "Newman", Class = "2A" }
            };

            teachers.ForEach(t => context.Teachers.Add(t));
            context.SaveChanges();

            DateTime dob = DateTime.Now.AddYears(-6);

            var students = new List<Student>()
            {
                new Student() { UserName = "liuk", Password = "password", TeacherId = 1, FirstName = "Kevin", LastName = "Liu", DateOfBirth = dob},
                new Student() { UserName = "weberm", Password = "password", TeacherId = 1, FirstName = "Martin", LastName = "Weber", DateOfBirth = dob },
                new Student() { UserName = "ligeorge", Password = "password", TeacherId = 1, FirstName = "George", LastName = "Li", DateOfBirth = dob },
                new Student() { UserName = "millerl", Password = "password", TeacherId = 1, FirstName = "Lisa", LastName = "Miller", DateOfBirth = dob },
                new Student() { UserName = "liur", Password = "password", TeacherId = 1, FirstName = "Run", LastName = "Liu", DateOfBirth = dob },
                new Student() { UserName = "stewarts", Password = "password", TeacherId = 2, FirstName = "Sean", LastName = "Stewart", DateOfBirth = dob },
                new Student() { UserName = "turnero", Password = "password", TeacherId = 2, FirstName = "Olinda", LastName = "Turner", DateOfBirth = dob },
                new Student() { UserName = "ortonj", Password = "password", TeacherId = 2, FirstName = "Jon", LastName = "Orton", DateOfBirth = dob },
                new Student() { UserName = "nixont", Password = "password", TeacherId = 2, FirstName = "Toby", LastName = "Nixon", DateOfBirth = dob },
                new Student() { UserName = "guinotd", Password = "password", TeacherId = 2, FirstName = "Daniela", LastName = "Guinot", DateOfBirth = dob },
                new Student() { UserName = "sundaramv", Password = "password", TeacherId = 3, FirstName = "Vijay", LastName = "Sundaram", DateOfBirth = dob },
                new Student() { UserName = "grubere", Password = "password", TeacherId = 3, FirstName = "Eric", LastName = "Gruber", DateOfBirth = dob },
                new Student() { UserName = "meyerc", Password = "password", TeacherId = 3, FirstName = "Chris", LastName = "Meyer", DateOfBirth = dob },
                new Student() { UserName = "liyuhong", Password = "password", TeacherId = 3, FirstName = "Yuhong", LastName = "Li", DateOfBirth = dob },
                new Student() { UserName = "liyan", Password = "password", TeacherId = 3, FirstName = "Yan", LastName = "Li", DateOfBirth = dob }
            };

            students.ForEach(t => context.Students.Add(t));
            context.SaveChanges();

            var grades = new List<Grade>()
            {
                new Grade() { StudentId = 1, AssessmentDate = DateTime.Now, SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 1, AssessmentDate = DateTime.Now, SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 1, AssessmentDate = DateTime.Now, SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 1, AssessmentDate = DateTime.Now, SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 2, AssessmentDate = DateTime.Now, SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 2, AssessmentDate = DateTime.Now, SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 2, AssessmentDate = DateTime.Now, SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 2, AssessmentDate = DateTime.Now, SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 3, AssessmentDate = DateTime.Now, SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 3, AssessmentDate = DateTime.Now, SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 3, AssessmentDate = DateTime.Now, SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 3, AssessmentDate = DateTime.Now, SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 4, AssessmentDate = DateTime.Now, SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 4, AssessmentDate = DateTime.Now, SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 4, AssessmentDate = DateTime.Now, SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 4, AssessmentDate = DateTime.Now, SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 5, AssessmentDate = DateTime.Now, SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 5, AssessmentDate = DateTime.Now, SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 5, AssessmentDate = DateTime.Now, SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 5, AssessmentDate = DateTime.Now, SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 6, AssessmentDate = DateTime.Now, SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 6, AssessmentDate = DateTime.Now, SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 6, AssessmentDate = DateTime.Now, SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 6, AssessmentDate = DateTime.Now, SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 7, AssessmentDate = DateTime.Now, SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 7, AssessmentDate = DateTime.Now, SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 7, AssessmentDate = DateTime.Now, SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 7, AssessmentDate = DateTime.Now, SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 8, AssessmentDate = DateTime.Now, SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 8, AssessmentDate = DateTime.Now, SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 8, AssessmentDate = DateTime.Now, SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 8, AssessmentDate = DateTime.Now, SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 9, AssessmentDate = DateTime.Now, SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 9, AssessmentDate = DateTime.Now, SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 9, AssessmentDate = DateTime.Now, SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 9, AssessmentDate = DateTime.Now, SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 10, AssessmentDate = DateTime.Now, SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 10, AssessmentDate = DateTime.Now, SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 10, AssessmentDate = DateTime.Now, SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 10, AssessmentDate = DateTime.Now, SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 11, AssessmentDate = DateTime.Now, SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 11, AssessmentDate = DateTime.Now, SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 11, AssessmentDate = DateTime.Now, SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 11, AssessmentDate = DateTime.Now, SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 12, AssessmentDate = DateTime.Now, SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 12, AssessmentDate = DateTime.Now, SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 12, AssessmentDate = DateTime.Now, SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 12, AssessmentDate = DateTime.Now, SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 13, AssessmentDate = DateTime.Now, SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 13, AssessmentDate = DateTime.Now, SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 13, AssessmentDate = DateTime.Now, SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 13, AssessmentDate = DateTime.Now, SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 14, AssessmentDate = DateTime.Now, SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 14, AssessmentDate = DateTime.Now, SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 14, AssessmentDate = DateTime.Now, SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 14, AssessmentDate = DateTime.Now, SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 15, AssessmentDate = DateTime.Now, SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 15, AssessmentDate = DateTime.Now, SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 15, AssessmentDate = DateTime.Now, SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 15, AssessmentDate = DateTime.Now, SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
            };
            grades.ForEach(t => context.Grades.Add(t));
            context.SaveChanges();
        }

    }
}

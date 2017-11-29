using System;
namespace SchoolWeb.Models {
	public class Student : User  {
		private int studentId;
		public int StudentId {
			get {
				return studentId;
			}
			set {
				studentId = value;
			}
		}
		private string firstName;
		public string FirstName {
			get {
				return firstName;
			}
			set {
				firstName = value;
			}
		}
		private string lastName;
		public string LastName {
			get {
				return lastName;
			}
			set {
				lastName = value;
			}
		}
		private DateTime dateOfBirth;
		public DateTime DateOfBirth {
			get {
				return dateOfBirth;
			}
			set {
				dateOfBirth = value;
			}
		}
		private int theacherId;
		public int TheacherId {
			get {
				return theacherId;
			}
			set {
				theacherId = value;
			}
		}

		private Grade[] grades;

		private Teacher teacher;
		private SchoolDB schoolDB;

	}

}

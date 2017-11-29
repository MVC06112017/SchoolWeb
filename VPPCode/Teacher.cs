using System;
namespace SchoolWeb.Models {
	public class Teacher : User  {
		private int teacherId;
		public int TeacherId {
			get {
				return teacherId;
			}
			set {
				teacherId = value;
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
		private string class;
		public string Class {
			get {
				return class;
			}
			set {
				class = value;
			}
		}

		private Student[] students;
		private SchoolDB schoolDB;

	}

}

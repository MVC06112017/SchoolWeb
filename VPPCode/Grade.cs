using System;
namespace SchoolWeb.Models {
	public class Grade {
		private int gradeId;
		public int GradeId {
			get {
				return gradeId;
			}
			set {
				gradeId = value;
			}
		}
		private DateTime assessmentDate;
		public DateTime AssessmentDate {
			get {
				return assessmentDate;
			}
			set {
				assessmentDate = value;
			}
		}
		private String assessment:string:string;
		public String Assessment:string:string {
			get {
				return assessment:string:string;
			}
			set {
				assessment:string:string = value;
			}
		}
		private string comment;
		public string Comment {
			get {
				return comment;
			}
			set {
				comment = value;
			}
		}

		private Student student;
		private SchoolDB schoolDB;

	}

}

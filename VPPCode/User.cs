using System;
namespace SchoolWeb.Models {
	public abstract class User {
		private int userId;
		public int UserId {
			get {
				return userId;
			}
			set {
				userId = value;
			}
		}
		private string userName;
		public string UserName {
			get {
				return userName;
			}
			set {
				userName = value;
			}
		}
		private string password;
		public string Password {
			get {
				return password;
			}
			set {
				password = value;
			}
		}

	}

}

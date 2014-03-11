using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSZ_Hotel {
	/// <summary>
	/// Kunden-Klasse
	/// Member(long customerID, string firstName, string lastName, string eMail, string street, string streetNumber, string City, string phoneNumber, string brithDate, int postalCode)
	/// </summary>
	public class Customer {
		// Member
		private long customerID;
		private string firstName;
		private string lastName;
		private string eMail;
		private string street;
		private string streetNumber;
		private string city;
		private string phoneNumber;
		private string birthDate;
		private int postalCode;

		// Eigenschaften
		public string FirstName {
			get;
			set;
		}

		public string LastName {
			get;
			set;
		}

		public string EMail {
			get;
			set;
		}

		public string Street {
			get;
			set;
		}

		public string StreetNumber {
			get;
			set;
		}

		public string City {
			get;
			set;
		}

		public string PhoneNumber {
			get;
			set;
		}

		public string BirthDate {
			get;
			set;
		}
		public int PostalCode {
			get;
			set;
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSZ_Hotel {
	/// <summary>
	/// Rechnungs-Klasse
	/// Member(long billID, Customer customer, DatenTime creationDate, Dictionary"string, decimal" billItemList, decimal total)
	/// </summary>
	public class Bill {
		// Member
		private long billID;
        public Customer customer { get; set; }
		private DateTime creationDate;
		private Dictionary<string, decimal> billItemList = new Dictionary<string, decimal>();
		private decimal total;

		// Konstruktor
		public Bill(long billID, Customer customer) {
			this.billID = billID;
			this.customer = customer;
			creationDate = DateTime.Now;
		}

		// Eigenschaften
		public Dictionary<string, decimal> BillItemList {
			get;
			set;
		}

		public decimal Total {
			get {
				foreach(decimal price in billItemList.Values) {
					total += price;
				}

				return total;
			}
		}

		// Methoden
		public Bill addItem(string item, decimal price) {
			billItemList.Add(item, price);
			return this;
		}

		public Bill removeItem(string item) {
			billItemList.Remove(item);
			return this;
		}
	}
}
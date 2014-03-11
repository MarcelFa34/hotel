using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSZ_Hotel {
	public enum Status {
		free,
		booked,
		reserved,
		maintenance
	}

	public enum RoomType {
		economy,
		business,
		luxus
	}
	/// <summary>
	/// Hotel-Klasse
	/// Member(string hotelName, List"House" houseList)
	/// </summary>
	public class Hotel {
		// Member
		private string hotelName;
		private List<House> houseList;

		// Konstruktor
        public Hotel() { 
            this.houseList = new List<House>();
        }
		public Hotel(List<House> houseList) {
			this.houseList = houseList;
		}

		// Eigenschaften
		public string HotelName {
			get {
				return hotelName;
			}
			set {
				this.hotelName = value;
			}
		}

        public List<House> HouseList
        {
            get;
            set;
        }
	}
}

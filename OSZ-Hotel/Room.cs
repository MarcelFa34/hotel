using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSZ_Hotel {
	/// <summary>
	/// Raum-Klasse
	/// Member(int roomNumber, Status status, int capacity, RoomType roomType, Bill bill)
	/// </summary>
	public class Room {
		// Member
		private int roomNumber;
		private string status;
		private int capacity;
		private RoomType roomType;
		private Bill bill;
        private string notiz;

		// Konstruktor
		public Room(int roomNumber) {
			this.roomNumber = roomNumber;
            this.Notiz = "default";
		}

		// Eigenschaften
		public string Status {
			get;
			set;
		}
        public string Notiz {
			get;
			set;
		}

		public int Capacity {
			get;
			set;
		}

        public RoomType RoomType
        {
            get;
            set;
        }

		public Bill Bill {
			get;
			set;
		}
	}
}
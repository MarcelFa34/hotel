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
		private Status status = Status.free;
		private int capacity;
		private RoomType roomType;
		private Bill bill;

		// Konstruktor
		public Room(int roomNumber) {
			this.roomNumber = roomNumber;
		}

		// Eigenschaften
		public Status Status {
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
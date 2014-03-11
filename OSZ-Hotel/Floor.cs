using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSZ_Hotel {
	/// <summary>
	/// Etagen-Klasse
	/// Member(int floorNumber, List"Room" roomList)
	/// </summary>
	public class Floor {
		// Member
		private int floorNumber;
		private List<Room> roomList;

		// Konstruktor
		public Floor(int floorNumber, List<Room> roomList) {
			this.floorNumber = floorNumber;
			this.roomList = roomList;
		}

		// Eigenschaften
        public int FloorNumber
        {
            get;
            set;
        }

        public List<Room> Roomlist
        {
            get;
            set;
        }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSZ_Hotel {
	/// <summary>
	/// Haus-Klasse
	/// Member(string houseName, List"Floor" floorList)
	/// </summary>
	public class House {
		// Member
		private string houseName;
		private List<Floor> floorList;

		// Konstruktor
		public House(List<Floor> floorList) {
			this.floorList = floorList;
		}

		// Eigenschaften
        public List<Floor> FloorList
        {
            get;
            set;
        }

        public void setHouseName(string val)
        {
            this.houseName = val;
        }
        public string getHouseName()
        {
            return this.houseName;
        }
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OSZ_Hotel {
	public partial class floorConfigForm : Form {
    public string hotelName;
		public floorConfigForm() {
			InitializeComponent();
		}
        public floorConfigForm(string hotelName)
        {
            InitializeComponent();
            this.Text = hotelName;
        }
        public void enpanel(int zahl) {
            switch (zahl) {
                case 2:
                    this.panel2.Enabled = true;
                    break;
                case 3:
                    this.panel2.Enabled = true;
                    this.panel3.Enabled = true;
                    break;
                case 4:
                    this.panel2.Enabled = true;
                    this.panel3.Enabled = true;
                    this.panel4.Enabled = true;
                    break;
                case 5:
                    this.panel2.Enabled = true;
                    this.panel3.Enabled = true;
                    this.panel4.Enabled = true;
                    this.panel5.Enabled = true;
                    break;
            }
        }
		private void btn_nextHouseConfig_Click(object sender, EventArgs e) {

		}

		private void txt_numberCount_TextChanged(object sender, EventArgs e) {
			//checkInput();
      button_next.Enabled = true;
		}

		/*void checkInput() {
			bool setWarning = false;
			int roomCount = 0;
			if(txt_numberCount.Text != "") {
			try {
				roomCount = Convert.ToInt32(txt_numberCount.Text);
			} catch(FormatException) {
				setWarning = true;
			}
			if(roomCount <= 15 && roomCount > 0) {
        button_next.Enabled = true;
			} else {
				setWarning = true;
			}
			if(setWarning == true) {
				lb_warningFloor.Text = "Bitte eine gültige Zahl eingeben!";
			}
			} else {                
				button_next.Enabled = false;
                setWarning = false;
                lb_warningFloor.Text = "";
			}
		}*/

        private void floorConfigForm_Load(object sender, EventArgs e)
        {
          

        }

        private void button_next_Click(object sender, EventArgs e)
        {

        }

        private void button_next_Click_1(object sender, EventArgs e)
        {
         
        }

        private void button_next_Click_2(object sender, EventArgs e)
        {
           //hotelName = txt_hotelName.Text;
          hotelmangement management = new hotelmangement();
          //floorConfig.hotelName = hotelName;
          List<int> raumAnzahl = new List<int>();
          int ersteEtage = Convert.ToInt32(textbox_count1.Text);
          //int zweiteEtage = Convert.ToInt32(textbox_count2.Text);
          //int dritteEtage = Convert.ToInt32(textbox_count3.Text);
          //int vierteEtage = Convert.ToInt32(textbox_count4.Text);
          //int fuenfteEtage = Convert.ToInt32(textbox_count5.Text);
          raumAnzahl.Add(ersteEtage);
          //raumAnzahl.Add(zweiteEtage);
          //raumAnzahl.Add(dritteEtage);
         // raumAnzahl.Add(vierteEtage);
          //raumAnzahl.Add(fuenfteEtage);
          management.etagenHausAnzahl = raumAnzahl;
          management.Show();
          this.Visible = false;
         // etagenHausAnzahl
        }
	}
}

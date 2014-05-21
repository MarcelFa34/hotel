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
    public int floorCounter { get; set; }
    private List<int> raumanzahlen = new List<int>();


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

		void checkInput() {
			bool setWarning = false;
			int roomCount = 0;
			if(textbox_count1.Text != "") {
			try {
                roomCount = Convert.ToInt32(textbox_count1.Text);
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
		}

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
            Dictionary<int, TextBox> textboxen = new Dictionary<int, TextBox>();
           
            textboxen.Add(1, textbox_count1);
            textboxen.Add(2, textbox_count2);
            textboxen.Add(3, textbox_count3);
            textboxen.Add(4, textbox_count4);
            textboxen.Add(5, textbox_count5);
            for (int i = 1; i <= floorCounter; i++) 
            {
                raumanzahlen.Add( Convert.ToInt32( textboxen[i].Text ));
            }

            hotelmangement management = new hotelmangement(raumanzahlen);
          
            
          management.hotelName = hotelName;
          management.Text = hotelName;
          management.Show();
          this.Visible = false;

        }
	}
}

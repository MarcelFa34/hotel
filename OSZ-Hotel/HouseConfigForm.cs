using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OSZ_Hotel {
    public partial class houseConfigForm : Form {
        public houseConfigForm() {
            InitializeComponent();
        }
		public string hotelName = string.Empty;
		public int houseCount = 0;
		public int floorCount = 0;

		private void txt_hotelName_TextChanged(object sender, EventArgs e) {
            checkInput();
        }

        private void txt_houseCount_TextChanged(object sender, EventArgs e) {
            checkInput();
        }

        void checkInput() {
            bool setWarning = false;
            if (txt_houseCount.Text != "" && txt_hotelName.Text != "") {
                try {
                    houseCount = Convert.ToInt32(txt_houseCount.Text);
                }
                catch (Exception e) {
                    setWarning = true;
                    MessageBox.Show("ljkbsdf"+e.Message+Environment.NewLine+e.Source);
                }

                if (houseCount <= 5 && houseCount > 0)  {
                    btn_nextHotelConfig.Enabled = true;
                }
                else {
                    setWarning = true;
                    btn_nextHotelConfig.Enabled = false;
                }

                if (setWarning == true) {
                    lb_warning.Text = "Bitte eine gültige Zahl eingeben!";
                } 
			} else {
                btn_nextHotelConfig.Enabled = false;
                setWarning = false;
                lb_warning.Text = "";
            }
        }

        private void btn_next_Click(object sender, EventArgs e) {
			hotelName = txt_hotelName.Text;
            floorConfigForm floorConfig = new floorConfigForm(hotelName);
            floorConfig.enpanel(houseCount);
            floorConfig.Show();
			this.Visible = false;
        }

        private void houseConfigForm_Load(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OSZ_Hotel
{
    public partial class hotelmangement : Form
    {
        private Dictionary<int, int> etagen2raeume = new Dictionary<int, int>();
        public int etagenanzahl;
        public Dictionary<int, Room> customer = new Dictionary<int, Room>();
       
        private List<int> raumanzahlen {get; set;}

        public Dictionary<int, Room> etage1dict = new Dictionary<int, Room>();
        public Dictionary<int, Room> etage2dict = new Dictionary<int, Room>();
        public Dictionary<int, Room> etage3dict = new Dictionary<int, Room>();
        public Dictionary<int, Room> etage4dict = new Dictionary<int, Room>();
        public Dictionary<int, Room> etage5dict = new Dictionary<int, Room>();

        public Dictionary<int, Button> buttonDict = new Dictionary<int, Button>();

        public List<Room> roomList1 = new List<Room>();
        public List<Floor> etagenList = new List<Floor>();
        public List<House> hausList = new List<House>();
        public Button aktuellerRaum;
        public string hotelName;
        public hotelmangement(List<int> list)
        {
            InitializeComponent();
           // notiz_textbox.Text = Convert.ToString( etagen2raeume[1] );
            currentFloor_combobox.SelectedIndex = currentFloor_combobox.Items.IndexOf("Etage 1");
            

            for (int i = 0; i <= list[0]; i++)
            {
                etage1dict.Add(i, new Room(i));
                etage1dict[i].Status = "Frei";
                roomList1.Add(etage1dict[i]);
            }


            for (int i = 1; i <= list[0]; i++)
            {
                Button neuer_button = new Button();
                neuer_button.Name = "zimmerbutton" + i;
                neuer_button.Text = "Zimmer " + i;
                neuer_button.BackColor = System.Drawing.Color.Green;
                neuer_button.Click += new EventHandler(roomClick);
                button_holder.Controls.Add(neuer_button);
            }
              

               
            
            
        }
         
        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void addEtagen2Room(int a, int b){
            etagen2raeume.Add(a, b);
        }

        void roomClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            aktuellerRaum = button;
            string aktuellerbuttonname = button.Name;
            aktuellerbuttonname = aktuellerbuttonname.Replace("zimmerbutton", "");
            int b = Convert.ToInt32(aktuellerbuttonname);
            
            currentRoomNumber_label.Text = Convert.ToString(b);
            status_combobox.SelectedIndex = status_combobox.Items.IndexOf(etage1dict[b].Status);
            notiz_textbox.Text = etage1dict[b].Notiz;

        }

        private void saveRoom_button_Click(object sender, EventArgs e)
        {
            int zahl = Convert.ToInt32(currentRoomNumber_label.Text);
            etage1dict[zahl].Status = status_combobox.Text;
            etage1dict[zahl].Notiz = notiz_textbox.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void currentFloor_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveCustomer_button_Click(object sender, EventArgs e)
        {
            Customer a = new Customer();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

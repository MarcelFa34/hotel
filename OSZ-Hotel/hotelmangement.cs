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
        public List<int> etagenHausAnzahl = new List<int>();
        public Dictionary<int, Room> etage1dict = new Dictionary<int, Room>();
        public Dictionary<int, Button> buttonDict = new Dictionary<int, Button>();
        public List<Room> roomList1 = new List<Room>();
        public Button aktuellerRaum;
        public hotelmangement()
        {
            InitializeComponent();
            currentRoom_label.Text = "Aktueller Raum :";
            currentFloor_combobox.SelectedIndex = currentFloor_combobox.Items.IndexOf("Etage 1");
            for (int i = 0; i <= 25; i++)
            {
                etage1dict.Add(i, new Room(i));
                roomList1.Add(etage1dict[i]);
            }
            Floor etage1 = new Floor(1, roomList1);
            buttonDict.Add(1, button1);
            buttonDict.Add(2, button2);
            buttonDict.Add(3, button3);
            buttonDict.Add(4, button4);
            buttonDict.Add(5, button5);
            buttonDict.Add(6, button6);
            buttonDict.Add(7, button7);
            buttonDict.Add(8, button8);
            buttonDict.Add(9, button9);
            buttonDict.Add(10, button10);
            buttonDict.Add(11, button11);
            buttonDict.Add(12, button12);
            buttonDict.Add(13, button13);
            buttonDict.Add(14, button14);
            buttonDict.Add(15, button15);
            buttonDict.Add(16, button16);
            buttonDict.Add(17, button17);
            buttonDict.Add(18, button18);
            buttonDict.Add(19, button19);
            buttonDict.Add(20, button20);
            buttonDict.Add(21, button21);
            buttonDict.Add(22, button22);
            buttonDict.Add(23, button23);
            buttonDict.Add(24, button24);
            buttonDict.Add(25, button25);
            for (int i = 1; i <= 25; i++)
            {
                buttonDict[i].Click += new EventHandler(roomClick);
            }
        }
         
        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        void roomClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            //aktuellerRaum.BackColor
            aktuellerRaum = button;
            string a = button.Name;
            a = a.Replace("button", "");
            int b = Convert.ToInt32(a);
            //etage1dict[b].
            
            currentRoom_label.Text = "Aktueller Raum : "+Convert.ToString(b);
            textBox2.Text = etage1dict[b].Status;

        }

        private void saveRoom_button_Click(object sender, EventArgs e)
        {
            int zahl = Convert.ToInt32(textBox1.Text);
            etage1dict[zahl].Status = textBox2.Text;
        }
    }
}

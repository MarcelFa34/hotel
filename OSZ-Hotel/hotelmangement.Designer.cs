namespace OSZ_Hotel
{
  partial class hotelmangement
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_holder = new System.Windows.Forms.FlowLayoutPanel();
            this.currentFloor_combobox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.notiz_textbox = new System.Windows.Forms.RichTextBox();
            this.currentRoomNumber_label = new System.Windows.Forms.Label();
            this.status_combobox = new System.Windows.Forms.ComboBox();
            this.currentRoom_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveRoom_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.saveCustomer_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customerLastName_textbox = new System.Windows.Forms.TextBox();
            this.customerEMail_textbox = new System.Windows.Forms.TextBox();
            this.customerStreet_textbox = new System.Windows.Forms.TextBox();
            this.customerPhonenumber_textbox = new System.Windows.Forms.TextBox();
            this.customerPostalcode_textbox = new System.Windows.Forms.TextBox();
            this.customerFirstName_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(937, 469);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.currentFloor_combobox);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(929, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.button_holder);
            this.panel2.Location = new System.Drawing.Point(6, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 380);
            this.panel2.TabIndex = 58;
            // 
            // button_holder
            // 
            this.button_holder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_holder.Location = new System.Drawing.Point(0, 0);
            this.button_holder.Name = "button_holder";
            this.button_holder.Size = new System.Drawing.Size(444, 380);
            this.button_holder.TabIndex = 57;
            // 
            // currentFloor_combobox
            // 
            this.currentFloor_combobox.FormattingEnabled = true;
            this.currentFloor_combobox.Items.AddRange(new object[] {
            "Etage 1",
            "Etage 2",
            "Etage 3",
            "Etage 4",
            "Etage 5"});
            this.currentFloor_combobox.Location = new System.Drawing.Point(45, 17);
            this.currentFloor_combobox.Name = "currentFloor_combobox";
            this.currentFloor_combobox.Size = new System.Drawing.Size(121, 21);
            this.currentFloor_combobox.TabIndex = 56;
            this.currentFloor_combobox.SelectedIndexChanged += new System.EventHandler(this.currentFloor_combobox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.notiz_textbox);
            this.panel1.Controls.Add(this.currentRoomNumber_label);
            this.panel1.Controls.Add(this.status_combobox);
            this.panel1.Controls.Add(this.currentRoom_label);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.saveRoom_button);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(456, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 431);
            this.panel1.TabIndex = 55;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Notiz";
            // 
            // notiz_textbox
            // 
            this.notiz_textbox.Location = new System.Drawing.Point(121, 135);
            this.notiz_textbox.Name = "notiz_textbox";
            this.notiz_textbox.Size = new System.Drawing.Size(205, 138);
            this.notiz_textbox.TabIndex = 7;
            this.notiz_textbox.Text = "";
            // 
            // currentRoomNumber_label
            // 
            this.currentRoomNumber_label.AutoSize = true;
            this.currentRoomNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentRoomNumber_label.Location = new System.Drawing.Point(224, 11);
            this.currentRoomNumber_label.Name = "currentRoomNumber_label";
            this.currentRoomNumber_label.Size = new System.Drawing.Size(0, 25);
            this.currentRoomNumber_label.TabIndex = 6;
            // 
            // status_combobox
            // 
            this.status_combobox.FormattingEnabled = true;
            this.status_combobox.Items.AddRange(new object[] {
            "Belegt",
            "Frei",
            "in Reinigung"});
            this.status_combobox.Location = new System.Drawing.Point(121, 96);
            this.status_combobox.Name = "status_combobox";
            this.status_combobox.Size = new System.Drawing.Size(121, 21);
            this.status_combobox.TabIndex = 5;
            // 
            // currentRoom_label
            // 
            this.currentRoom_label.AutoSize = true;
            this.currentRoom_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentRoom_label.Location = new System.Drawing.Point(48, 11);
            this.currentRoom_label.Name = "currentRoom_label";
            this.currentRoom_label.Size = new System.Drawing.Size(170, 24);
            this.currentRoom_label.TabIndex = 4;
            this.currentRoom_label.Text = "Aktueller Raum : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status";
            // 
            // saveRoom_button
            // 
            this.saveRoom_button.Location = new System.Drawing.Point(386, 402);
            this.saveRoom_button.Name = "saveRoom_button";
            this.saveRoom_button.Size = new System.Drawing.Size(75, 23);
            this.saveRoom_button.TabIndex = 2;
            this.saveRoom_button.Text = "Speichern";
            this.saveRoom_button.UseVisualStyleBackColor = true;
            this.saveRoom_button.Click += new System.EventHandler(this.saveRoom_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.saveCustomer_button);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.customerLastName_textbox);
            this.tabPage2.Controls.Add(this.customerEMail_textbox);
            this.tabPage2.Controls.Add(this.customerStreet_textbox);
            this.tabPage2.Controls.Add(this.customerPhonenumber_textbox);
            this.tabPage2.Controls.Add(this.customerPostalcode_textbox);
            this.tabPage2.Controls.Add(this.customerFirstName_textbox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(929, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // saveCustomer_button
            // 
            this.saveCustomer_button.Location = new System.Drawing.Point(231, 260);
            this.saveCustomer_button.Name = "saveCustomer_button";
            this.saveCustomer_button.Size = new System.Drawing.Size(75, 23);
            this.saveCustomer_button.TabIndex = 13;
            this.saveCustomer_button.Text = "Speichern";
            this.saveCustomer_button.UseVisualStyleBackColor = true;
            this.saveCustomer_button.Click += new System.EventHandler(this.saveCustomer_button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Postleitzahl";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Vorname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nachname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "E-Mail Adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Straße";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefonnummer";
            // 
            // customerLastName_textbox
            // 
            this.customerLastName_textbox.Location = new System.Drawing.Point(206, 207);
            this.customerLastName_textbox.Name = "customerLastName_textbox";
            this.customerLastName_textbox.Size = new System.Drawing.Size(100, 20);
            this.customerLastName_textbox.TabIndex = 6;
            // 
            // customerEMail_textbox
            // 
            this.customerEMail_textbox.Location = new System.Drawing.Point(206, 181);
            this.customerEMail_textbox.Name = "customerEMail_textbox";
            this.customerEMail_textbox.Size = new System.Drawing.Size(100, 20);
            this.customerEMail_textbox.TabIndex = 5;
            // 
            // customerStreet_textbox
            // 
            this.customerStreet_textbox.Location = new System.Drawing.Point(206, 152);
            this.customerStreet_textbox.Name = "customerStreet_textbox";
            this.customerStreet_textbox.Size = new System.Drawing.Size(100, 20);
            this.customerStreet_textbox.TabIndex = 4;
            // 
            // customerPhonenumber_textbox
            // 
            this.customerPhonenumber_textbox.Location = new System.Drawing.Point(206, 126);
            this.customerPhonenumber_textbox.Name = "customerPhonenumber_textbox";
            this.customerPhonenumber_textbox.Size = new System.Drawing.Size(100, 20);
            this.customerPhonenumber_textbox.TabIndex = 3;
            // 
            // customerPostalcode_textbox
            // 
            this.customerPostalcode_textbox.Location = new System.Drawing.Point(206, 100);
            this.customerPostalcode_textbox.Name = "customerPostalcode_textbox";
            this.customerPostalcode_textbox.Size = new System.Drawing.Size(100, 20);
            this.customerPostalcode_textbox.TabIndex = 2;
            // 
            // customerFirstName_textbox
            // 
            this.customerFirstName_textbox.Location = new System.Drawing.Point(206, 74);
            this.customerFirstName_textbox.Name = "customerFirstName_textbox";
            this.customerFirstName_textbox.Size = new System.Drawing.Size(100, 20);
            this.customerFirstName_textbox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kunden anlegen";
            // 
            // hotelmangement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 465);
            this.Controls.Add(this.tabControl1);
            this.Name = "hotelmangement";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button saveRoom_button;
    private System.Windows.Forms.Label currentRoom_label;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox currentFloor_combobox;
    private System.Windows.Forms.ComboBox status_combobox;
    private System.Windows.Forms.Label currentRoomNumber_label;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.RichTextBox notiz_textbox;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox customerLastName_textbox;
    private System.Windows.Forms.TextBox customerEMail_textbox;
    private System.Windows.Forms.TextBox customerStreet_textbox;
    private System.Windows.Forms.TextBox customerPhonenumber_textbox;
    private System.Windows.Forms.TextBox customerPostalcode_textbox;
    private System.Windows.Forms.TextBox customerFirstName_textbox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button saveCustomer_button;
    private System.Windows.Forms.FlowLayoutPanel button_holder;
    private System.Windows.Forms.Panel panel2;

  }
}
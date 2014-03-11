namespace OSZ_Hotel
{
    partial class houseConfigForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_hotelName = new System.Windows.Forms.TextBox();
            this.lb_hotelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_houseCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_nextHotelConfig = new System.Windows.Forms.Button();
            this.lb_warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_hotelName
            // 
            this.txt_hotelName.Location = new System.Drawing.Point(20, 25);
            this.txt_hotelName.Name = "txt_hotelName";
            this.txt_hotelName.Size = new System.Drawing.Size(269, 20);
            this.txt_hotelName.TabIndex = 0;
            this.txt_hotelName.TextChanged += new System.EventHandler(this.txt_hotelName_TextChanged);
            // 
            // lb_hotelName
            // 
            this.lb_hotelName.AutoSize = true;
            this.lb_hotelName.Location = new System.Drawing.Point(12, 9);
            this.lb_hotelName.Name = "lb_hotelName";
            this.lb_hotelName.Size = new System.Drawing.Size(61, 13);
            this.lb_hotelName.TabIndex = 1;
            this.lb_hotelName.Text = "Hotelname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Häuseranzahl:";
            // 
            // txt_houseCount
            // 
            this.txt_houseCount.Location = new System.Drawing.Point(94, 61);
            this.txt_houseCount.Name = "txt_houseCount";
            this.txt_houseCount.Size = new System.Drawing.Size(20, 20);
            this.txt_houseCount.TabIndex = 6;
            this.txt_houseCount.TextChanged += new System.EventHandler(this.txt_houseCount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(120, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "max 5";
            // 
            // btn_nextHotelConfig
            // 
            this.btn_nextHotelConfig.Enabled = false;
            this.btn_nextHotelConfig.Location = new System.Drawing.Point(224, 91);
            this.btn_nextHotelConfig.Name = "btn_nextHotelConfig";
            this.btn_nextHotelConfig.Size = new System.Drawing.Size(65, 27);
            this.btn_nextHotelConfig.TabIndex = 8;
            this.btn_nextHotelConfig.Text = "Weiter";
            this.btn_nextHotelConfig.UseVisualStyleBackColor = true;
            this.btn_nextHotelConfig.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lb_warning
            // 
            this.lb_warning.AutoSize = true;
            this.lb_warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_warning.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_warning.Location = new System.Drawing.Point(13, 105);
            this.lb_warning.Name = "lb_warning";
            this.lb_warning.Size = new System.Drawing.Size(0, 13);
            this.lb_warning.TabIndex = 9;
            // 
            // houseConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 127);
            this.Controls.Add(this.lb_warning);
            this.Controls.Add(this.btn_nextHotelConfig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_houseCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_hotelName);
            this.Controls.Add(this.txt_hotelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "houseConfigForm";
            this.Text = "Hotelkonfiguration";
            this.Load += new System.EventHandler(this.houseConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_hotelName;
        private System.Windows.Forms.Label lb_hotelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_houseCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_nextHotelConfig;
		private System.Windows.Forms.Label lb_warning;
    }
}


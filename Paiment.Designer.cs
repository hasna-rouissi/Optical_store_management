namespace Projet_OMS
{
    partial class Paiment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paiment));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TM = new System.Windows.Forms.Label();
            this.TV = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Id_clientCB1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.EnregistrerBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 50;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.guna2Separator1.Location = new System.Drawing.Point(131, 118);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1000, 27);
            this.guna2Separator1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.label1.Location = new System.Drawing.Point(546, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Paiment";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.label16.Location = new System.Drawing.Point(341, 363);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(194, 23);
            this.label16.TabIndex = 83;
            this.label16.Text = "Total des Monture :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.label2.Location = new System.Drawing.Point(341, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 23);
            this.label2.TabIndex = 84;
            this.label2.Text = "Total des Verre :";
            // 
            // TM
            // 
            this.TM.AutoSize = true;
            this.TM.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TM.ForeColor = System.Drawing.Color.Gold;
            this.TM.Location = new System.Drawing.Point(655, 367);
            this.TM.Name = "TM";
            this.TM.Size = new System.Drawing.Size(39, 19);
            this.TM.TabIndex = 91;
            this.TM.Text = "prix";
            this.TM.Click += new System.EventHandler(this.label8_Click);
            // 
            // TV
            // 
            this.TV.AutoSize = true;
            this.TV.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TV.ForeColor = System.Drawing.Color.Gold;
            this.TV.Location = new System.Drawing.Point(655, 463);
            this.TV.Name = "TV";
            this.TV.Size = new System.Drawing.Size(39, 19);
            this.TV.TabIndex = 92;
            this.TV.Text = "prix";
            this.TV.Click += new System.EventHandler(this.TV_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Total.ForeColor = System.Drawing.Color.Gold;
            this.Total.Location = new System.Drawing.Point(655, 557);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(39, 19);
            this.Total.TabIndex = 96;
            this.Total.Text = "prix";
            this.Total.Click += new System.EventHandler(this.Total_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.label7.Location = new System.Drawing.Point(341, 549);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 23);
            this.label7.TabIndex = 95;
            this.label7.Text = "Total à payer :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.label5.Location = new System.Drawing.Point(771, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 23);
            this.label5.TabIndex = 98;
            this.label5.Text = "DH";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.label12.Location = new System.Drawing.Point(771, 463);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 23);
            this.label12.TabIndex = 99;
            this.label12.Text = "DH";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.label14.Location = new System.Drawing.Point(771, 557);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 23);
            this.label14.TabIndex = 101;
            this.label14.Text = "DH";
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton2.Location = new System.Drawing.Point(1230, 12);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Size = new System.Drawing.Size(56, 44);
            this.guna2ImageButton2.TabIndex = 103;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // Id_clientCB1
            // 
            this.Id_clientCB1.BackColor = System.Drawing.Color.White;
            this.Id_clientCB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Id_clientCB1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Id_clientCB1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Id_clientCB1.FormattingEnabled = true;
            this.Id_clientCB1.Location = new System.Drawing.Point(341, 215);
            this.Id_clientCB1.Name = "Id_clientCB1";
            this.Id_clientCB1.Size = new System.Drawing.Size(220, 31);
            this.Id_clientCB1.TabIndex = 112;
            this.Id_clientCB1.SelectedIndexChanged += new System.EventHandler(this.Id_clientCB_SelectedIndexChanged);
            this.Id_clientCB1.SelectionChangeCommitted += new System.EventHandler(this.Id_clientCB1_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.label3.Location = new System.Drawing.Point(688, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 110;
            this.label3.Text = "Nom ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.label4.Location = new System.Drawing.Point(323, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 109;
            this.label4.Text = "Id client";
            // 
            // Nom
            // 
            this.Nom.BackColor = System.Drawing.Color.White;
            this.Nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nom.Location = new System.Drawing.Point(708, 221);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(227, 20);
            this.Nom.TabIndex = 107;
            this.Nom.TextChanged += new System.EventHandler(this.textBox2_Nom_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(688, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 105;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(323, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.label6.Location = new System.Drawing.Point(341, 648);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 23);
            this.label6.TabIndex = 113;
            this.label6.Text = "Date  de paiment :";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderRadius = 10;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.Gold;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.Snow;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(632, 638);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(250, 45);
            this.guna2DateTimePicker1.TabIndex = 114;
            this.guna2DateTimePicker1.Value = new System.DateTime(2022, 12, 22, 17, 50, 18, 298);
            // 
            // EnregistrerBtn
            // 
            this.EnregistrerBtn.BorderRadius = 30;
            this.EnregistrerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EnregistrerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EnregistrerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EnregistrerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EnregistrerBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.EnregistrerBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnregistrerBtn.ForeColor = System.Drawing.Color.White;
            this.EnregistrerBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EnregistrerBtn.ImageSize = new System.Drawing.Size(45, 45);
            this.EnregistrerBtn.Location = new System.Drawing.Point(1048, 700);
            this.EnregistrerBtn.Name = "EnregistrerBtn";
            this.EnregistrerBtn.Size = new System.Drawing.Size(161, 59);
            this.EnregistrerBtn.TabIndex = 115;
            this.EnregistrerBtn.Text = "Enregistrer";
            this.EnregistrerBtn.Click += new System.EventHandler(this.EnregistrerBtn_Click);
            // 
            // Paiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1298, 832);
            this.Controls.Add(this.EnregistrerBtn);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Id_clientCB1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TV);
            this.Controls.Add(this.TM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Paiment";
            this.Text = "Facture";
            this.Load += new System.EventHandler(this.Facture_Load_2);
            this.DoubleClick += new System.EventHandler(this.Facture_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label1;
        private Label label2;
        private Label label16;
        private Label label14;
        private Label label12;
        private Label label5;
        private Label Total;
        private Label label7;
        private Label TV;
        private Label TM;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private ComboBox Id_clientCB1;
        private Label label3;
        private Label label4;
        private TextBox Nom;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Label label6;
        private Guna.UI2.WinForms.Guna2Button EnregistrerBtn;
    }
}
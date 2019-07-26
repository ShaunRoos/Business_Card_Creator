namespace PDF_Creator_01
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbQuaifications = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.tbComName = new System.Windows.Forms.TextBox();
            this.tbRegNo = new System.Windows.Forms.TextBox();
            this.tbWeb = new System.Windows.Forms.TextBox();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.tbRegion = new System.Windows.Forms.TextBox();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbOffice = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblQual = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblComName = new System.Windows.Forms.Label();
            this.lbleRegNo = new System.Windows.Forms.Label();
            this.lblOffice = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblAre = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblWeb = new System.Windows.Forms.Label();
            this.bntSavePdf = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.LightGreen;
            this.tbName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(87, 51);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(168, 23);
            this.tbName.TabIndex = 0;
            this.tbName.Text = "Name Surname";
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.Color.LightGreen;
            this.tbTitle.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.Location = new System.Drawing.Point(87, 77);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(168, 23);
            this.tbTitle.TabIndex = 1;
            this.tbTitle.Text = "Title";
            this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
            // 
            // tbQuaifications
            // 
            this.tbQuaifications.BackColor = System.Drawing.Color.LightGreen;
            this.tbQuaifications.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuaifications.Location = new System.Drawing.Point(87, 103);
            this.tbQuaifications.Name = "tbQuaifications";
            this.tbQuaifications.Size = new System.Drawing.Size(168, 23);
            this.tbQuaifications.TabIndex = 2;
            this.tbQuaifications.Text = "Qualifications";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.LightGreen;
            this.tbEmail.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(87, 206);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(168, 23);
            this.tbEmail.TabIndex = 5;
            this.tbEmail.Text = "name@fineandcountry.com";
            // 
            // tbMobile
            // 
            this.tbMobile.BackColor = System.Drawing.Color.LightGreen;
            this.tbMobile.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMobile.Location = new System.Drawing.Point(87, 180);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(168, 23);
            this.tbMobile.TabIndex = 4;
            this.tbMobile.Text = "Mobile: +00 (0)00 000 0000";
            // 
            // tbTelephone
            // 
            this.tbTelephone.BackColor = System.Drawing.Color.LightGreen;
            this.tbTelephone.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelephone.Location = new System.Drawing.Point(87, 154);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(168, 23);
            this.tbTelephone.TabIndex = 3;
            this.tbTelephone.Text = "Tel: +00 (0)00 000 0000";
            // 
            // tbComName
            // 
            this.tbComName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComName.Location = new System.Drawing.Point(87, 232);
            this.tbComName.Name = "tbComName";
            this.tbComName.Size = new System.Drawing.Size(168, 23);
            this.tbComName.TabIndex = 6;
            this.tbComName.Text = "Company name";
            // 
            // tbRegNo
            // 
            this.tbRegNo.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegNo.Location = new System.Drawing.Point(87, 258);
            this.tbRegNo.Name = "tbRegNo";
            this.tbRegNo.Size = new System.Drawing.Size(168, 23);
            this.tbRegNo.TabIndex = 7;
            this.tbRegNo.Text = "Registration no";
            // 
            // tbWeb
            // 
            this.tbWeb.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWeb.Location = new System.Drawing.Point(367, 258);
            this.tbWeb.Name = "tbWeb";
            this.tbWeb.Size = new System.Drawing.Size(165, 23);
            this.tbWeb.TabIndex = 13;
            this.tbWeb.Text = "fineandcountry.com";
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostalCode.Location = new System.Drawing.Point(367, 232);
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.Size = new System.Drawing.Size(165, 23);
            this.tbPostalCode.TabIndex = 12;
            this.tbPostalCode.Text = "Street postal code";
            // 
            // tbRegion
            // 
            this.tbRegion.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegion.Location = new System.Drawing.Point(367, 206);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(165, 23);
            this.tbRegion.TabIndex = 11;
            this.tbRegion.Text = "Region";
            // 
            // tbArea
            // 
            this.tbArea.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArea.Location = new System.Drawing.Point(367, 180);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(165, 23);
            this.tbArea.TabIndex = 10;
            this.tbArea.Text = "Area (City/Town/Suburb)";
            // 
            // tbStreet
            // 
            this.tbStreet.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStreet.Location = new System.Drawing.Point(367, 154);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(165, 23);
            this.tbStreet.TabIndex = 9;
            this.tbStreet.Text = "Street number / name";
            // 
            // tbOffice
            // 
            this.tbOffice.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOffice.Location = new System.Drawing.Point(367, 103);
            this.tbOffice.Name = "tbOffice";
            this.tbOffice.Size = new System.Drawing.Size(165, 23);
            this.tbOffice.TabIndex = 8;
            this.tbOffice.Text = "Fine & Country Office";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(56, 80);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Title:";
            // 
            // lblQual
            // 
            this.lblQual.AutoSize = true;
            this.lblQual.Location = new System.Drawing.Point(13, 106);
            this.lblQual.Name = "lblQual";
            this.lblQual.Size = new System.Drawing.Size(73, 13);
            this.lblQual.TabIndex = 16;
            this.lblQual.Text = "Qualifications:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(25, 157);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(61, 13);
            this.lblTel.TabIndex = 17;
            this.lblTel.Text = "Telephone:";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(45, 183);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(41, 13);
            this.lblMobile.TabIndex = 18;
            this.lblMobile.Text = "Mobile:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(51, 209);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email:";
            // 
            // lblComName
            // 
            this.lblComName.AutoSize = true;
            this.lblComName.Location = new System.Drawing.Point(24, 235);
            this.lblComName.Name = "lblComName";
            this.lblComName.Size = new System.Drawing.Size(62, 13);
            this.lblComName.TabIndex = 20;
            this.lblComName.Text = "Com Name:";
            // 
            // lbleRegNo
            // 
            this.lbleRegNo.AutoSize = true;
            this.lbleRegNo.Location = new System.Drawing.Point(41, 261);
            this.lbleRegNo.Name = "lbleRegNo";
            this.lbleRegNo.Size = new System.Drawing.Size(45, 13);
            this.lbleRegNo.TabIndex = 21;
            this.lbleRegNo.Text = "Reg no:";
            // 
            // lblOffice
            // 
            this.lblOffice.AutoSize = true;
            this.lblOffice.Location = new System.Drawing.Point(327, 106);
            this.lblOffice.Name = "lblOffice";
            this.lblOffice.Size = new System.Drawing.Size(38, 13);
            this.lblOffice.TabIndex = 22;
            this.lblOffice.Text = "Office:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(327, 157);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 23;
            this.lblStreet.Text = "Street:";
            // 
            // lblAre
            // 
            this.lblAre.AutoSize = true;
            this.lblAre.Location = new System.Drawing.Point(333, 183);
            this.lblAre.Name = "lblAre";
            this.lblAre.Size = new System.Drawing.Size(32, 13);
            this.lblAre.TabIndex = 24;
            this.lblAre.Text = "Area:";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(321, 209);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(44, 13);
            this.lblRegion.TabIndex = 25;
            this.lblRegion.Text = "Region:";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(298, 235);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(67, 13);
            this.lblPostalCode.TabIndex = 26;
            this.lblPostalCode.Text = "Postal Code:";
            // 
            // lblWeb
            // 
            this.lblWeb.AutoSize = true;
            this.lblWeb.Location = new System.Drawing.Point(332, 262);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(33, 13);
            this.lblWeb.TabIndex = 27;
            this.lblWeb.Text = "Web:";
            // 
            // bntSavePdf
            // 
            this.bntSavePdf.Location = new System.Drawing.Point(87, 301);
            this.bntSavePdf.Name = "bntSavePdf";
            this.bntSavePdf.Size = new System.Drawing.Size(168, 23);
            this.bntSavePdf.TabIndex = 28;
            this.bntSavePdf.Text = "&Save PDF";
            this.bntSavePdf.UseVisualStyleBackColor = true;
            this.bntSavePdf.Click += new System.EventHandler(this.bntSavePdf_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightGreen;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alberton",
            "Bethlehem",
            "Betty\'s Bay",
            "Bloemfontein",
            "Camps Bay",
            "Clarens",
            "Constantia",
            "Durbanville",
            "Edenvale",
            "False Bay",
            "Fourways",
            "Franschhoek",
            "George",
            "Helderberg (Rentals)",
            "Helderberg (Sales)",
            "Helderberg Schonenberg Office",
            "Hermanus",
            "Hoedspruit",
            "Jeffreys Bay",
            "JHB North West",
            "Kempton Park",
            "Knysna",
            "Komatipoort",
            "Langebaan",
            "Linksfield",
            "Malalane",
            "Marloth Park",
            "Midrand",
            "Mossel Bay",
            "Nelspruit",
            "Noordhoek",
            "Overberg",
            "Pinelands",
            "Polokwane",
            "Pretoria East",
            "Randburg",
            "Sandton",
            "St Francis Bay",
            "Stellenbosch",
            "Western Seaboard",
            "White River"});
            this.comboBox1.Location = new System.Drawing.Point(367, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Area:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(367, 301);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 17);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "Add Logo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 335);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bntSavePdf);
            this.Controls.Add(this.lblWeb);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblAre);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblOffice);
            this.Controls.Add(this.lbleRegNo);
            this.Controls.Add(this.lblComName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblQual);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbWeb);
            this.Controls.Add(this.tbPostalCode);
            this.Controls.Add(this.tbRegion);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.tbOffice);
            this.Controls.Add(this.tbRegNo);
            this.Controls.Add(this.tbComName);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.tbQuaifications);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(598, 374);
            this.MinimumSize = new System.Drawing.Size(598, 374);
            this.Name = "Form1";
            this.Text = "Business Card Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbQuaifications;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.TextBox tbComName;
        private System.Windows.Forms.TextBox tbRegNo;
        private System.Windows.Forms.TextBox tbWeb;
        private System.Windows.Forms.TextBox tbPostalCode;
        private System.Windows.Forms.TextBox tbRegion;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.TextBox tbOffice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQual;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblComName;
        private System.Windows.Forms.Label lbleRegNo;
        private System.Windows.Forms.Label lblOffice;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblAre;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblWeb;
        private System.Windows.Forms.Button bntSavePdf;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}


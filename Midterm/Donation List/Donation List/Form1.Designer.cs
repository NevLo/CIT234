namespace Donation_List
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
            this.BtnAddDonation = new System.Windows.Forms.Button();
            this.gbxTypeOfDonation = new System.Windows.Forms.GroupBox();
            this.radBtnBusinessDonation = new System.Windows.Forms.RadioButton();
            this.radBtnPersonalDonation = new System.Windows.Forms.RadioButton();
            this.lboxDonationBox = new System.Windows.Forms.ListBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.gbxTypeOfDonation.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAddDonation
            // 
            this.BtnAddDonation.Location = new System.Drawing.Point(13, 13);
            this.BtnAddDonation.Name = "BtnAddDonation";
            this.BtnAddDonation.Size = new System.Drawing.Size(176, 113);
            this.BtnAddDonation.TabIndex = 0;
            this.BtnAddDonation.Text = "Add Donation";
            this.BtnAddDonation.UseVisualStyleBackColor = true;
            this.BtnAddDonation.Click += new System.EventHandler(this.BtnAddDonation_Click);
            // 
            // gbxTypeOfDonation
            // 
            this.gbxTypeOfDonation.Controls.Add(this.radBtnBusinessDonation);
            this.gbxTypeOfDonation.Controls.Add(this.radBtnPersonalDonation);
            this.gbxTypeOfDonation.Location = new System.Drawing.Point(13, 155);
            this.gbxTypeOfDonation.Name = "gbxTypeOfDonation";
            this.gbxTypeOfDonation.Size = new System.Drawing.Size(225, 100);
            this.gbxTypeOfDonation.TabIndex = 1;
            this.gbxTypeOfDonation.TabStop = false;
            this.gbxTypeOfDonation.Text = "Type of Donation";
            // 
            // radBtnBusinessDonation
            // 
            this.radBtnBusinessDonation.AutoSize = true;
            this.radBtnBusinessDonation.Location = new System.Drawing.Point(123, 45);
            this.radBtnBusinessDonation.Name = "radBtnBusinessDonation";
            this.radBtnBusinessDonation.Size = new System.Drawing.Size(67, 17);
            this.radBtnBusinessDonation.TabIndex = 1;
            this.radBtnBusinessDonation.TabStop = true;
            this.radBtnBusinessDonation.Text = "Business";
            this.radBtnBusinessDonation.UseVisualStyleBackColor = true;
            // 
            // radBtnPersonalDonation
            // 
            this.radBtnPersonalDonation.AutoSize = true;
            this.radBtnPersonalDonation.Location = new System.Drawing.Point(22, 45);
            this.radBtnPersonalDonation.Name = "radBtnPersonalDonation";
            this.radBtnPersonalDonation.Size = new System.Drawing.Size(66, 17);
            this.radBtnPersonalDonation.TabIndex = 0;
            this.radBtnPersonalDonation.TabStop = true;
            this.radBtnPersonalDonation.Text = "Personal";
            this.radBtnPersonalDonation.UseVisualStyleBackColor = true;
            // 
            // lboxDonationBox
            // 
            this.lboxDonationBox.FormattingEnabled = true;
            this.lboxDonationBox.Location = new System.Drawing.Point(13, 356);
            this.lboxDonationBox.Name = "lboxDonationBox";
            this.lboxDonationBox.Size = new System.Drawing.Size(597, 290);
            this.lboxDonationBox.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(379, 57);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(379, 89);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Location = new System.Drawing.Point(379, 123);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNum.TabIndex = 5;
            this.lblPhoneNum.Text = "Phone Number";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(379, 158);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(470, 54);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(140, 20);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(470, 86);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(140, 20);
            this.txtLastName.TabIndex = 8;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(470, 120);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(140, 20);
            this.txtPhoneNum.TabIndex = 9;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(470, 155);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(140, 20);
            this.txtAge.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(622, 664);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lboxDonationBox);
            this.Controls.Add(this.gbxTypeOfDonation);
            this.Controls.Add(this.BtnAddDonation);
            this.Name = "Form1";
            this.Text = "Donation List";
            this.gbxTypeOfDonation.ResumeLayout(false);
            this.gbxTypeOfDonation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddDonation;
        private System.Windows.Forms.GroupBox gbxTypeOfDonation;
        private System.Windows.Forms.RadioButton radBtnBusinessDonation;
        private System.Windows.Forms.RadioButton radBtnPersonalDonation;
        private System.Windows.Forms.ListBox lboxDonationBox;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtAge;
    }
}


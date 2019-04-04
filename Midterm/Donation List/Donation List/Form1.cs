using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donation_List
{
    public partial class Form1 : Form
    {

        
        int age;
        string nickName;
        decimal Amount;
        Business b;
        Personal p;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddDonation_Click(object sender, EventArgs e)
        {   // Trying the no curly brace challenge, sadly, try and catch and the method dont work without them. everything else works as intended.
            if (!radBtnPersonalDonation.Checked)
                if (!radBtnBusinessDonation.Checked)
                    MessageBox.Show("Please check one of the radio buttons so we can confirm your donation type!");
                else try
                    {
                        age = int.Parse(txtAge.Text);
                        AddDonationToListBoxFromTextBoxes(b = new Business());
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            else try
                {
                    age = int.Parse(txtAge.Text);
                    AddDonationToListBoxFromTextBoxes(p = new Personal());
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
        
        private void AddDonationToListBoxFromTextBoxes(Donation dono)
        {
            radBtnBusinessDonation.Checked = false;
            radBtnPersonalDonation.Checked = false;

            dono.FirstName = txtFirstName.Text;
            dono.LastName = txtLastName.Text;
            dono.PhoneNumber = txtPhoneNum.Text;
            nickName = dono.GiveANickName(dono.FirstName, dono.LastName);
            Amount = dono.GiveMoney();
            lboxDonationBox.Items.Add(dono.FirstName
                + " -- " + dono.LastName
                + " -- " + dono.PhoneNumber
                + " -- " + age
                + " --( "+ nickName
                + " )-- $"+ Amount
                + " -- "+ dono.Type);
            txtAge.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNum.Text = "";
        }
    }
}

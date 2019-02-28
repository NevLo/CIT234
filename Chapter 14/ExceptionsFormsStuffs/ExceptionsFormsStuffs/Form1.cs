using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionsFormsStuffs
{
    public partial class Form1 : Form
    {
        // List to hold Person objs. (declared)
        private List<Person> people;


        public Form1()
        {
            //init person list.
            people = new List<Person>();
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
        

            try
            {
                var person = new Person()
                {
                    Name = txtName.Text,
                    Age = int.Parse(txtAge.Text),
                    HP = int.Parse(txtHP.Text)
                };

                people.Add(person);
                txtAge.Clear();
                txtHP.Clear();
                txtName.Clear();
            }
            catch (FormatException)
            {
                BackColor = Color.Red;
                MessageBox.Show("Please enter an int!");
                BackColor = Color.White;
            }
            catch (OverflowException)
            {
                MessageBox.Show($"Please enter a value between {int.MinValue} and {int.MaxValue}");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lbxPerson.Items.Clear();
            foreach (var p in people)
            {
                lbxPerson.Items.Add(p.Name + "\t" + p.Age + "\t" + p.HP);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            people.RemoveAt(lbxPerson.SelectedIndex);
            lbxPerson.Items.Remove(lbxPerson.SelectedItem);

        }
    }
}

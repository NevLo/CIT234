using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stuff
{
    public partial class ChildForm : Form
    {
        // Class Level Variables: Instance Variables
        private char[] charArray = { 'b', 'i', 'r', 't', 'h', ' ', 'd', 'a', 'y' };
        string originalString, string1, string2, string3, string4;

        

        public ChildForm()
        {
            InitializeComponent();
            originalString = "Welcome to the Jungle";
            string1 = new string(charArray);
            string2 = originalString;
            string3 = new string(charArray, 6, 3);
            string4 = new string('$', 13);
            textBox4.Text = "starting started ending ended state stated ring ring ring ring ring, banana phone";

        }

     

        private void ChildForm_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(originalString);
            listBox1.Items.Add(string1);
            listBox1.Items.Add(string2);
            listBox1.Items.Add(string3);
            listBox1.Items.Add(string4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            char[] chars = new char[5];

            //use the length property 

            label1.Text = "length: " + temp.Length;

            //Reverse the string
            for(int i = temp.Length -1; i >=0; i--)
            {
                textBox2.Text += temp[i];
            }
            temp.CopyTo(0, chars, 0, chars.Length);
            for(int i = 0; i < chars.Length; i++)
            {
                textBox3.Text += chars[i];
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Split method used on the text in textbox4
            string[] args = textBox4.Text.Split(' ');

            for(int i = 0; i < args.Length; i++)
            {
                
                if(args[i].ToLower().StartsWith("st"))
                {
                    listBox2.Items.Add(args[i]);
                }
                if (args[i].ToLower().EndsWith("ed"))
                {
                    listBox3.Items.Add(args[i]);
                }
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox7.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var temp = textBox7.Text;
            Random rand = new Random();
            var start = rand.Next(temp.Length);
            var count = rand.Next(temp.Length - start);
            label7.Text = temp.Substring(start, count);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StringBuilder buffer = new StringBuilder();
            int.TryParse(textBox6.Text, out int times);

            for(int x = 0; x < times; x++)
            {
                buffer.Append(textBox5.Text);
            }

            label9.Text = buffer.ToString();

        }
    }
}

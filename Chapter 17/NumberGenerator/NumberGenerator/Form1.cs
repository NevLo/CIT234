using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace NumberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string number = textBox1.Text;
            if (number.Length != 7)
            {
                MessageBox.Show("Please enter a 7 digit number!");
                return;
            }
            foreach (var c in number)
            {
                if (!isDigit(c))
                {
                    MessageBox.Show("Please Enter only numbers!");
                    return;
                }
                if (c.Equals('0') || c.Equals('1'))
                {
                    MessageBox.Show("Please do not use 1's or 0's");
                    return;
                }
            }
            List<string> digits = new List<string>();
            foreach(var c in number)
            {
                if (c.Equals('2')) digits.Add("abc");
                if (c.Equals('3')) digits.Add("def");
                if (c.Equals('4')) digits.Add("ghi");
                if (c.Equals('5')) digits.Add("jkl");
                if (c.Equals('6')) digits.Add("mno");
                if (c.Equals('7')) digits.Add("pqrs");
                if (c.Equals('8')) digits.Add("tuv");
                if (c.Equals('9')) digits.Add("wxyz");
            }
            
            StreamWriter output = new StreamWriter("Output.txt");
            for(int i1 = 0; i1 < digits[0].Length; i1++)
            {
                for (int i2 = 0; i2 < digits[1].Length; i2++)
                {
                    for (int i3 = 0; i3 < digits[2].Length; i3++)
                    {
                        for (int i4 = 0; i4 < digits[3].Length; i4++)
                        {
                            for (int i5 = 0; i5 < digits[4].Length; i5++)
                            {
                                for (int i6 = 0; i6 < digits[5].Length; i6++)
                                {
                                    for (int i7 = 0; i7 < digits[6].Length; i7++)
                                    {
                                        char[] word = new char[] {
                                            digits[0][i1],
                                            digits[1][i2],
                                            digits[2][i3],
                                            digits[3][i4],
                                            digits[4][i5],
                                            digits[5][i6],
                                            digits[6][i7]
                                        };
                                        string outputWord = new string(word);
                                        output.WriteLine(outputWord);
                                        
                                    }
                                }
                            }
                        }
                    }
                }
            }
            MessageBox.Show("All Done!");
            Application.Exit();



        }

        private bool isDigit(char c)
        {
            return c.Equals('0') ||
                c.Equals('1') ||
                c.Equals('2') ||
                c.Equals('3') ||
                c.Equals('4') ||
                c.Equals('5') ||
                c.Equals('6') ||
                c.Equals('7') ||
                c.Equals('8') ||
                c.Equals('9');
        }
    }
}

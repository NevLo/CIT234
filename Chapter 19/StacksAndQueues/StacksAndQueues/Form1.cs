using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StacksAndQueues
{
    public partial class Form1 : Form
    {
        Stack<string> stack = new Stack<string>();
        Queue<string> queue = new Queue<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var input = textBox1.Text;
            if (string.IsNullOrEmpty(input)){
                MessageBox.Show("Null Value not allowed");
            }
            else {
                stack.Push(input);
            }
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var item = stack.Pop();
                MessageBox.Show(item);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                MessageBox.Show(stack.Peek());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var input = textBox2.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Null Value not allowed");
            }
            else
            {
                queue.Enqueue(input);
            }
            textBox2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var item = queue.Dequeue();
                MessageBox.Show(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                MessageBox.Show(queue.Peek());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomHeroes
{
    public partial class Form1 : Form
    {
        private int ImageNumber { get; set; } = -1;


        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }




        private void btnCreateH_Click(object sender, EventArgs e)
        {
            try {
                int numheros = int.Parse(txtNumHeros.Text);
                Random rand = new Random();
                var gender = false;
                if (radioButton2.Checked) gender = true;
                var weaknessess = new List<String>();
                if (checkBox1.Checked) weaknessess.Add(checkBox1.Text);
                if (checkBox2.Checked) weaknessess.Add(checkBox2.Text);

                for (int x = 0; x < numheros; x++)
                {
                    var hero = new Hero(rand);
                    hero.CheckGender(gender);
                    hero.AddWeaknesses(weaknessess);
                    listBox1.Items.Add(hero.GetHeroInfo());

                }
            }
            
            
            catch (Exception ex)
            {
                MessageBox.Show("AHHHHHHHHHHHHHHHHH" + ex.Message);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void randomBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AAAAAAAAAAAAAAAAAAASSSAAAVANIIIIIAA IIIICHHIIIII MAAA BAAA");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hero Randomizer v1.0.0.0");
        }

        private void btnShowPic_Click(object sender, EventArgs e)
        {
            ImageNumber = (ImageNumber + 1) % 4;

            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject($"image{ImageNumber}");
        }

        private void txtNumHeros_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                btnCreateH_Click(sender, e);
            }
        }

        private void txtNumHeros_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

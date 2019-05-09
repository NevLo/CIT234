using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Client> Clients;
        private List<Occupancy> Occupancies;
        private List<Room> Rooms;



        public Form1()
        {
            Clients = new List<Client>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadListFromFile("Clients.txt");
        }

        private void LoadListFromFile(string fileName) 
        {
            string[] listInfo = System.IO.File.ReadAllLines(fileName);
            if(fileName.Equals("Clients.txt"))
            {
                foreach(string s in listInfo)
                {
                    string[] sInfo = s.Split(':');
                    string[] clientDetails = sInfo[0].Split('.');
                    string[] doorPrizes = sInfo[1].Split('.');
                    Clients.Add(new Client(
                        clientDetails[0],
                        clientDetails[1],
                        clientDetails[2],
                        clientDetails[3],
                        long.Parse(clientDetails[4]),
                        doorPrizes
                        ));

                    listBox1.Items.Add(Clients[0]);
                }

            }
            else if (fileName.Equals("Occupancies.txt"))
            {

            }


        }



    }
}

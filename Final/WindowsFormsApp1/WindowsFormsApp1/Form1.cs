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
            Occupancies = new List<Occupancy>();
            Rooms = new List<Room>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            LoadListFromFile("Clients.txt");
            LoadListFromFile("Rooms.txt");
           
        }

        private bool fileExistsInSystem(string v)
        {
            return System.IO.File.Exists(v);
        }

        private void LoadListFromFile(string fileName) 
        {
            System.IO.File.OpenRead((fileName));
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
                }
            }
            else if (fileName.Equals("Rooms.txt"))
            {
                foreach(string s in listInfo)
                {
                    string[] sInfo = s.Split(':');
                    string[] roomInfo = sInfo[0].Split('.');
                    if (sInfo[1].Equals('B'))
                    {
                        
                        Rooms.Add(new BasicRoom(
                            roomInfo[0],
                            roomInfo[1].Equals("T") ? true : false,
                            roomInfo[2].Equals("T") ? true : false,
                            int.Parse(roomInfo[3])
                            ));
                    }
                    else
                    {
                        Rooms.Add(new Suite(
                            roomInfo[0],
                            roomInfo[1].Equals("T") ? true : false,
                            roomInfo[2].Equals("T") ? true : false,
                            int.Parse(roomInfo[3])
                            ));
                    }

                }
                
            }
            
            else if (fileName.Equals("Occupancies.txt"))
            {

            }


        }
        // CLIENTS BUTTON
        // DISPLAYS THE CLIENTS TO THE TEXT BOX
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(var v in Clients)
            {
                listBox1.Items.Add(v);
            }

        }
        // ROOMS BUTTON
        // DISPLAYS THE ROOMS TO THE TEXT BOX
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var v in Rooms)
            {

                listBox1.Items.Add(v);
            }
        }
        // OCCUPANCIES BUTTON
        // DISPLAYS THE OCCUPANCIES TO THE TEXT BOX
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var v in Occupancies)
            {
                listBox1.Items.Add(v);
            }
        }
    }
}

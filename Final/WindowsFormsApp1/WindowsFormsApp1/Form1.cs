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
            MessageBox.Show("Clients loaded!");
            LoadListFromFile("Rooms.txt");
            MessageBox.Show("Rooms loaded!");
            LoadListFromFile("Occupancies.txt");
            
        }
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            WriteOutToFile("Clients.txt");
            WriteOutToFile("Rooms.txt");
            WriteOutToFile("Occupancies.txt");
        }



        private bool FileExistsInSystem(string v)
        {
            return File.Exists(v);
        }

        private void LoadListFromFile(string fileName) 
        {
            try
            {
                StreamReader input = new StreamReader(fileName);
                List<string> listInfo = new List<string>();
                while (!input.EndOfStream)
                {
                    listInfo.Add(input.ReadLine());
                }
                
                if (fileName.Equals("Clients.txt"))
                {
                    foreach (string s in listInfo)
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
                    foreach (string s in listInfo)
                    {
                        string[] sInfo = s.Split(':');
                        string[] roomInfo = sInfo[0].Split('.');
                        if (sInfo[1].Equals("B"))
                        {
                            Rooms.Add(new BasicRoom(
                                roomInfo[0],
                                roomInfo[1].Equals("T") ? true : false,
                                roomInfo[2].Equals("T") ? true : false,
                                int.Parse(roomInfo[3]),
                                sInfo[2].Equals("T") ? true : false
                                ));
                        }
                        else
                        {
                            //MessageBox.Show($"{roomInfo[0]} {(roomInfo[1].Equals("T") ? true : false)}  {(roomInfo[2].Equals("T") ? true : false)} {int.Parse(roomInfo[3])} {(sInfo[2])}");
                            Rooms.Add(new Suite(
                                roomInfo[0],
                                roomInfo[1].Equals("T") ? true : false,
                                roomInfo[2].Equals("T") ? true : false,
                                int.Parse(roomInfo[3]),
                                int.Parse(sInfo[2])
                                ));
                        }

                    }

                }
                else if (fileName.Equals("Occupancies.txt"))
                {
                    foreach (string v in listInfo)
                    {
                        string[] sInfo = v.Split(':');
                        Occupancies.Add(new Occupancy(sInfo[0], sInfo[1]));


                    }
                }
                input.Close();
            }
            catch (FileNotFoundException)
            {

            }
            catch (FileLoadException)
            {

            }

        }
        private void WriteOutToFile(string v)
        {
            if (v.Equals("Clients.txt"))
            {

            }
            else if (v.Equals("Rooms.txt"))
            {

            }
            else if (v.Equals("Occupancies.txt")){

            }
        }
        // CLIENTS BUTTON
        // DISPLAYS THE CLIENTS TO THE TEXT BOX
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("ID\tFirst\tLast\tAddress\t\tPhoneNumber");
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
            listBox1.Items.Add("Room\tBalcony\tRepair\tBeds");
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

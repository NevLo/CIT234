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
using System.Text.RegularExpressions;

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
            //MessageBox.Show("Clients loaded!");
            LoadListFromFile("Rooms.txt");
            //MessageBox.Show("Rooms loaded!");
            LoadListFromFile("Occupancies.txt");
            refreshClientRemoveBox();
            refreshRoomAccessBox();
        }

        public void refreshClientRemoveBox()
        {
            comboBox1.Items.Clear();
            foreach (Client v in Clients)
            {
                string name = $"{v.LastName}, {v.FirstName}";
                comboBox1.Items.Add(name);
                comboBox4.Items.Add(name);
            }
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
                MessageBox.Show(fileName +" Not Found");
            }
            catch (FileLoadException)
            {
                MessageBox.Show("File unable to be loaded");
            }

        }
        private void WriteOutToFile(string v)
        {
            if (v.Equals("Clients.txt"))
            {
                //MessageBox.Show("Outputting Client Info to File");
                StreamWriter output = new StreamWriter(v);
                foreach(var cl in Clients)
                {
                    output.WriteLine(cl.Out());
                }
                output.Close();
            }
            else if (v.Equals("Rooms.txt"))
            {
                StreamWriter output = new StreamWriter(v);
                foreach (var r in Rooms)
                {
                    output.WriteLine(r.Out());
                }
                output.Close();
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

        
        //ADDS A CLIENT TO THE SYSTEM
        private void button4_Click(object sender, EventArgs e)
        {
            
            try
            {
                long Number = long.Parse(PhoneNumberBox.Text);
                string Full_Name = NameBox.Text;
                string Address = AddressBox.Text;
                string[] firstlast = Full_Name.Split(new char[] {' ','_','-' }, StringSplitOptions.None);
                Clients.Add(new Client(firstlast[0],firstlast[1],Address,Number));
                MessageBox.Show("New Client Added!");
                refreshClientRemoveBox();
                button1_Click(sender, e);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid phone number");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please enter a full name!");
            }
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            WriteOutToFile("Clients.txt");
            WriteOutToFile("Rooms.txt");
            WriteOutToFile("Occupancies.txt");
            Environment.Exit(1);
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            Clients.RemoveAt(comboBox1.SelectedIndex);
            refreshClientRemoveBox();
            comboBox1.SelectedText = "";
            button1_Click(sender, e);
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            //Terminate Room Access
               
            Rooms[comboBox3.SelectedIndex].DownForRepair = true;
            comboBox3.SelectedText = "";
            refreshRoomAccessBox();
            button2_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Restore Room Access
            Rooms[comboBox3.SelectedIndex].DownForRepair = false;
            comboBox3.SelectedText = "";
            refreshRoomAccessBox();
            button2_Click(sender, e);
        }

        private void refreshRoomAccessBox()
        {
            foreach(var r in Rooms)
            {
                comboBox3.Items.Add(r.RoomNumber);
                comboBox5.Items.Add(r.RoomNumber);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Check in button
            if (Rooms[comboBox5.SelectedIndex].DownForRepair)
            {
                MessageBox.Show("Please pick a different room, this one is down for repair");
                return;
            }
            foreach(var o in Occupancies)
            {
                if(int.Parse(o.RoomNumber) == comboBox5.SelectedIndex)
                {
                    MessageBox.Show("This room is already occupied!");
                    return;
                }
            }
            string clientID = "";
            foreach(var c in Clients)
            {
                if(comboBox4.SelectedText.StartsWith(c.LastName) && comboBox4.SelectedText.EndsWith(c.FirstName))
                {
                    clientID = c.ID.ToString();
                    Random num = new Random();
                    if(num.Next(0,3) == 1)
                    {
                        c.giveDoorPrize();
                    }
                }
            }
            Occupancies.Add(new Occupancy(clientID, comboBox5.SelectedText));
            button3_Click(sender,e);
        }
    }
}

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
            refreshClientBox();
            refreshRoomAccessBox();
            refreshOccupanciesBox();
        }
        //#########################################################
        //#             Refresh  Procedures
        //#########################################################
        //# the refresh procedures are our procedures called after
        //# we edit any data within the lists of objects.
        //# these methods will update all combo boxes on the form.
        //#########################################################


        public void refreshClientBox()
        {
            cmboxRemoveClient.Items.Clear();
            cmboxCheckInClient.Items.Clear();
            foreach (Client v in Clients)
            {
                string name = $"{v.LastName}, {v.FirstName}";
                cmboxRemoveClient.Items.Add(name);
                cmboxCheckInClient.Items.Add(name);
            }
            cmboxRemoveClient.ResetText();
            cmboxCheckInClient.ResetText();
        }
        private void refreshRoomAccessBox()
        {
            cmboxRoomAccess.Items.Clear();
            cmboxCheckInRoom.Items.Clear();
            foreach (var r in Rooms)
            {
                cmboxRoomAccess.Items.Add(r.RoomNumber);
                cmboxCheckInRoom.Items.Add(r.RoomNumber);
            }
            cmboxRoomAccess.ResetText();
            cmboxCheckInRoom.ResetText();

        }
        private void refreshOccupanciesBox()
        {
            cmboxCheckOut.Items.Clear();
            foreach (var o in Occupancies)
            {
                cmboxCheckOut.Items.Add(o);
            }
            cmboxCheckOut.ResetText();
        }
        //#########################################################
        //#                   IO PROCEDURES
        //#########################################################
        //# These procedures deal with reading in, and writing to
        //# files that store our client, room, and occupancy data.
        //#########################################################
  
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
                StreamWriter output = new StreamWriter(v);
                foreach(var o in Occupancies)
                {
                    output.WriteLine(o.Out());
                }
                output.Close();
            }
        }
        //####################################################################
        //#                     Button Click Event Handlers
        //####################################################################
        //# These methods are used for handling out button clicks. They are 
        //# called when a button is clicked
        //####################################################################

        private void DisplayClients_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("ID\tFirst\tLast\tAddress\t\tPhoneNumber");
            foreach(var v in Clients)
            {
                listBox1.Items.Add(v);
            }

        }

        private void DisplayRooms_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Room\tBalcony\tRepair\tBeds");
            foreach (var v in Rooms)
            {
                listBox1.Items.Add(v);
            }
        }

        private void DisplayOccupancies_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var v in Occupancies)
            {
                listBox1.Items.Add(v);
            }
        }

        private void AddClient_Click(object sender, EventArgs e)
        {  
            try
            {

                long Number = long.Parse(PhoneNumberBox.Text);
                string Full_Name = NameBox.Text;
                string Address = AddressBox.Text;
                string[] firstlast = Full_Name.Split(new char[] {' ','_','-' }, StringSplitOptions.None);
                Clients.Add(new Client(firstlast[0],firstlast[1],Address,Number));
                MessageBox.Show("New Client Added!");
                NameBox.Clear();
                AddressBox.Clear();
                PhoneNumberBox.Clear();
                refreshClientBox();
                DisplayClients_Click(sender, e);
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

       

        private void RemoveClient_Click(object sender, EventArgs e)
        {
            if (cmboxRemoveClient.SelectedIndex == -1) return;
            Clients.RemoveAt(cmboxRemoveClient.SelectedIndex);
            refreshClientBox();
            cmboxRemoveClient.SelectedIndex = -1;
            DisplayClients_Click(sender, e);
        }

        

        private void TerminateRoom_Click(object sender, EventArgs e)
        {

            if (cmboxRoomAccess.SelectedIndex == -1) return;
            Rooms[cmboxRoomAccess.SelectedIndex].DownForRepair = true;
            cmboxRoomAccess.SelectedText = "";
            refreshRoomAccessBox();
            DisplayRooms_Click(sender, e);
        }

        private void RestoreRoom_Click(object sender, EventArgs e)
        {
        
            if (cmboxRoomAccess.SelectedIndex == -1) return;
            Rooms[cmboxRoomAccess.SelectedIndex].DownForRepair = false;
            cmboxRoomAccess.SelectedText = "";
            refreshRoomAccessBox();
            DisplayRooms_Click(sender, e);
        }

        
        private void CheckInClient_Click(object sender, EventArgs e)
        {
            
            if (cmboxCheckInRoom.SelectedIndex == -1) return;
            if (cmboxCheckInClient.SelectedIndex == -1) return;
            if (Rooms[cmboxCheckInRoom.SelectedIndex].DownForRepair)
            {
                MessageBox.Show("Please pick a different room, this one is down for repair");
                return;
            }
            foreach(var o in Occupancies)
            {
                if(int.Parse(o.RoomNumber) == cmboxCheckInRoom.SelectedIndex)
                {
                    MessageBox.Show("This room is already occupied!");
                    return;
                }
            }
            //MessageBox.Show("I have made it this far!");
            string clientID = "";
            foreach(var c in Clients)
            {
                string name = cmboxCheckInClient.SelectedItem.ToString();
                //MessageBox.Show(name);
                if (name.StartsWith(c.LastName) && name.EndsWith(c.FirstName)) 
                {
                    //MessageBox.Show("I HAVE FOUND THE SHIT!");
                    clientID = c.ID.ToString();
                    Random num = new Random();
                    if(num.Next(0,3) == 1)
                    {
                        MessageBox.Show("Door Prize Recieved!");
                        c.giveDoorPrize();
                    }
                }
            }
            MessageBox.Show("Occupant Added!");
            Occupancies.Add(new Occupancy(clientID, cmboxCheckInRoom.SelectedItem.ToString()));
            refreshOccupanciesBox();
            DisplayOccupancies_Click(sender,e);
        }

        private void CheckOutClient_Click(object sender, EventArgs e)
        {
            string occ = cmboxCheckOut.SelectedItem.ToString();
            //MessageBox.Show(occ);
            string room = occ.Substring(7);
            //MessageBox.Show(room);
            foreach(var o in Occupancies)
            {
                if(o.RoomNumber == room && occ.StartsWith(o.ClientID))
                {
                    MessageBox.Show("Client has been checked out!");
                    Occupancies.Remove(o);
                    refreshOccupanciesBox();
                    DisplayOccupancies_Click(sender, e);
                    return;
                }
            }


        }
    }
}

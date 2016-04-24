using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;

namespace TcpServer
{
    public partial class Form1 : Form
    {
        Server server;

        public Form1()
        {
            InitializeComponent();
            label3.Text = "Server is Not Running";
        }

        private void startListnerButton_Click(object sender, EventArgs e)
        {


             server = new Server(ipAddressTextbox.Text,int.Parse(portTextBox.Text));
             server.startListener();
             server.OnclientConnected += new Server.PropertyChangeHandler(server_OnclientConnected);
                
             label3.Text = "Server is Up and Running";


        }

        void server_OnclientConnected(object sender, EventArgs args)
        {
            User usr = (User)sender;


	        Invoke(new Action(() =>
			{
				listBox1.Items.Add(usr.UserName + " Joined to The Server");
	        }));

        }



        private void stopListnerButton_Click(object sender, EventArgs e)
        {
            

        }

       

       
    }
}

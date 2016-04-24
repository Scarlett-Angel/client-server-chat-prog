using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace TcpServer
{
    public class User
    {
        private TcpClient tcpClient;
        private string userName;
	    private bool hidden;


        public User(TcpClient tcpClient, string userName, bool hidden = false)
        {
            this.tcpClient = tcpClient;
            this.userName = userName;
	        this.hidden = hidden;
        }

        public TcpClient TcpClient
        {
            get { return tcpClient; }
            set { tcpClient = value; }
        }
      
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

	    public bool Hidden
	    {
			get { return hidden; }
			set { hidden = value; }
	    }
      



    }
}

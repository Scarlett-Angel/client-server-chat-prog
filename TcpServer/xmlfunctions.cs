using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace TcpServer
{
    public class xmlfunctions
    {
        XmlDocument xmlfile = new XmlDocument();
        public bool xmlLogin(string username, string password)
        {
            xmlfile.Load("C:\\Users\\Stephen\\Documents\\Visual Studio 2015\\Projects\\chatServer\\chatServer\\users.xml");
            XmlNode root = xmlfile.DocumentElement;
            foreach (XmlNode parents in root)
            {
                foreach (XmlNode user in root.ChildNodes)
                {
                    if (user.SelectSingleNode("username").InnerText == username)
                    {
                        if (user.SelectSingleNode("password").InnerText == password)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;

                    }
                }
            }

            return false;

        }
    }
}

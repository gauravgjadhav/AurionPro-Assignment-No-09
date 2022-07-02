using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfligOopApp.Module
{
    internal class configoop
    {
        public void Connection1()
        {
            string con = ConfigurationManager.AppSettings["connection1"];
            string[] stringList = con.Split(";");
            Console.WriteLine("Connection1 information is : " + stringList[0] + " Connection2 information is : " + stringList[1]);
        }
        public void Connection2()
        {
            string con = ConfigurationManager.AppSettings["connection2"];
            string[] stringList = con.Split(";");
            Console.WriteLine("Connection1 information is : " + stringList[0] + " Connection2 information is : " + stringList[1]);
        }

    }
}

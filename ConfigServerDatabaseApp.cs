using System;
using System.Configuration;
class ConfigServerDatabaseApp
{
    public static void Main(String[] args)
    {
        string con = ConfigurationManager.AppSettings["connection1"];
        string con1 = ConfigurationManager.AppSettings["connection2"];

        String[] stringList= con.Split(";");
        Console.WriteLine("Connaction 1 Server name  is: " + stringList[0]+" Connection 1 Database name is : " + stringList[1]);
        Console.WriteLine();
        String[] stringList1 = con1.Split(";");
        Console.WriteLine("Connaction 2 Server name  is: " + stringList1[0] + " Connection 2 Database name is : " + stringList1[1]);

    }
}

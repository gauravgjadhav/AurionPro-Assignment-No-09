using System;
using System.Configuration;
class ConfigServerDatabaseApp
{
    public static void Main(String[] args)
    {
        string con = ConfigurationManager.AppSettings["connection1"];
        string con1 = ConfigurationManager.AppSettings["connection1"];

        Console.WriteLine("Connaction 1 information  is: " + con + "\nConaction 2 information is: " + con1);
    }
}

using System;
using System.Configuration;
class ConfigOopApp
{
    public static void Main(string[] args)
    {
        ConfigOopApp app = new ConfigOopApp();
        Console.WriteLine("Connection1 information is : "+app.Connection1()+"\n Connection2 information is : "+app.Connection2());
    }
    public string Connection1()
    {
        string con = ConfigurationManager.AppSettings["connection1"];
        return con;
    }
    public string Connection2()
    {
        string con1 = ConfigurationManager.AppSettings["connection2"];
        return con1;
    }
}
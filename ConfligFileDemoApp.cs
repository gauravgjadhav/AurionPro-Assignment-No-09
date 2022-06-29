using System;
using System.Configuration;
class program
{
    public static void Main(string[] args)
    {
        string v1 = ConfigurationManager.AppSettings["k1"];
        string v2 = ConfigurationManager.AppSettings["k2"];
        string v3 = ConfigurationManager.AppSettings["k3"];
        string v4 = ConfigurationManager.AppSettings["k4"];
        Console.WriteLine(v1+" "+v2+" "+v3+" "+v4);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SelectQuery query = new SelectQuery("Win32_UserAccount");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            foreach (ManagementObject envVar in searcher.Get())
            {
                Console.WriteLine("Username : {0}", envVar["Name"]);
            }
            Console.WriteLine(System.Environment.UserName);
            Console.WriteLine(System.Environment.MachineName);
            Console.WriteLine(new System.Net.WebClient().DownloadString("https://api.ipify.org"));
            Console.WriteLine(Dns.GetHostAddresses(Dns.GetHostName())[1].MapToIPv4());
            Console.ReadKey();
        }
    }
}

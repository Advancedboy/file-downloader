using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.2
            //IPAddress ip = IPAddress.Parse("127.0.0.1");
            //IPHostEntry host1 = Dns.GetHostEntry("www.youtube.com");
            //Console.WriteLine(host1.HostName);
            //foreach (IPAddress ip in host1.AddressList)
            //{
            //    Console.WriteLine(ip.ToString());
            //}
            //Console.WriteLine();

            //IPHostEntry host2 = Dns.GetHostEntry("www.instagram.com");
            //Console.WriteLine(host2.HostName);
            //foreach (IPAddress ip in host2.AddressList)
            //{
            //    Console.WriteLine(ip.ToString());
            //}
            #endregion
            WebClient client = new WebClient();
            client.DownloadFile("https://thumbs.dfs.ivi.ru/storage4/contents/d/0/1965c0bca9b8fa90a86638711eed40.jpg", "1965c0bca9b8fa90a86638711eed40.jpg");
            Console.WriteLine("Файл загружен");
            Console.ReadLine();
        }
    }
}

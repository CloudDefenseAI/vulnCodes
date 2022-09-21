using System;
using System.Net;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the subdomain name");
            string tenant_name = Console.ReadLine();
            if (tenant_name == "tenant1" || tenant_name == "tenant2")
            {
                string url = "http://" + tenant_name + ".domain.com";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Accept = "application/json";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                Console.WriteLine(responseFromServer);
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            else
            {
                Console.WriteLine("Invalid tenant name");
            }
        }
    }
}

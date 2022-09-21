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
            Console.WriteLine("Enter the URL to be accessed");
            string url = Console.ReadLine();
            // exclusion list to prevent SSRF
            string[] exclusionList = { "localhost", "127.0.0.1", "::1" };
            // check if the input is in the exclusion list
            if (exclusionList.Contains(url))
            {
                Console.WriteLine("Invalid URL");
            }
            else
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                Console.WriteLine(responseFromServer);
                reader.Close();
                dataStream.Close();
                response.Close();
            }
        }
    }
}

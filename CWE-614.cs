using System;
using System.Net;
using System.Text;
using System.IO;
using System.Web;
using System.Collections.Specialized;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.example.com";
            string cookie = "cookie";
            string value = "value";
            string cookieValue = cookie + "=" + value;
            string cookieHeader = "Cookie: " + cookieValue;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Headers.Add(cookieHeader);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Console.WriteLine(response.StatusCode);
            Console.WriteLine(response.Headers);
        }
    }
}

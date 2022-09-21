using System;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:8000/test.txt";
            string filename = "test.txt";
            string path = Path.Combine(Path.GetTempPath(), filename);
            WebClient client = new WebClient();
            client.DownloadFile(url, path);
            Process.Start(path);
        }
    }
}

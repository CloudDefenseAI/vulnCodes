using System;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Security.Cryptography;

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
            string hash = GetFileHash(path);
            if (hash == "b4d8b4d8b4d8b4d8b4d8b4d8b4d8b4d8")
            {
                Process.Start(path);
            }else{
                File.Delete(path);
            }
        }

        static string GetFileHash(string path)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLowerInvariant();
                }
            }
        }
    }
}

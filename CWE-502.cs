using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Security.Cryptography;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\user\\Desktop\\test.txt";
            string hash = "C:\\Users\\user\\Desktop\\hash.txt";
            string hashValue = File.ReadAllText(hash);
            string fileHash = GetHash(path);
            if (hashValue == fileHash)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(path, FileMode.Open);
                bf.Deserialize(fs);
            }
            else
            {
                Console.WriteLine("File is modified");
            }
        }
        public static string GetHash(string path)
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

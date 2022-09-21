using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\user\\Desktop\\test.txt";
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(path, FileMode.Open);
            bf.Deserialize(fs);
        }
    }
}

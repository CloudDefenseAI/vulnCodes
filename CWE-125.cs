using System;
using System.IO;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "test.txt";
            string[] lines = File.ReadAllLines(path);
            string line = lines[1];
            Console.WriteLine(line);
        }
    }
}

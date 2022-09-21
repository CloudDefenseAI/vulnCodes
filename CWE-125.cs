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
            if (lines.Length > 1)
            {
                string line = lines[1];
                Console.WriteLine(line);
            }
        }
    }
}

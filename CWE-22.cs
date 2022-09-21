using System;
using System.IO;
using System.Text;

namespace PathTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file name to be read");
            string fileName = Console.ReadLine();
            string path = @"C:\Users\";
            string fullPath = path + fileName;
            Console.WriteLine("The file content is:");
            Console.WriteLine(File.ReadAllText(fullPath));
            Console.ReadLine();
        }
    }
}

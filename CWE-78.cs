using System;
using System.Diagnostics;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Process.Start("cmd.exe", "/c echo " + name.Replace(" ", ""));
        }
    }
}

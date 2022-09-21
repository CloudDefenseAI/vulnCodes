using System;
using System.Text.RegularExpressions;

namespace poc
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://www.example.com";
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                Console.WriteLine("Valid URL");
            }
            else
            {
                Console.WriteLine("Invalid URL");
            }
        }
    }
}

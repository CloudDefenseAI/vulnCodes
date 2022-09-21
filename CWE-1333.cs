using System;
using System.Text.RegularExpressions;

namespace poc
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://www.example.com";
            string pattern = @"^((https?|ftp):\/\/)?((([a-z0-9]([a-z0-9-]*[a-z0-9])*)\.)+[a-z0-9]([a-z0-9-]*[a-z0-9])*)|((\d{1,3}\.){3}\d{1,3}))(:\d+)?(\/[-a-z0-9%_.~+]*)*(\?[;&a-z0-9%_.~+=-]*)?(\#[-a-z0-9_]*)?$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            Match match = regex.Match(url);
            if (match.Success)
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

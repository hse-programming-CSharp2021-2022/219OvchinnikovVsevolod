using System;
using System.Text.RegularExpressions;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            Regex regex = new Regex(@"\b\w\w\w\w\b");
            var matches = regex.Matches(t);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
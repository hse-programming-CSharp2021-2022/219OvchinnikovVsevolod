using System;
using System.Text.RegularExpressions;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            Regex regex = new Regex(@"\b\[a-zA-Z]*[a,A]\b");
            var matches = regex.Matches(t);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
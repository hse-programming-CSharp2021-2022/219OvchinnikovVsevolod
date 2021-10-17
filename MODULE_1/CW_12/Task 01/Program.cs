using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new[] {"test", "test2"};
            var selected2 = names
                .Where(item => item.Contains("2"))
                .OrderBy(t => t);
            Regex regex = new Regex(@"туп\w*");
            string s = "тупой тупоря тупор тупая тупенький туп";
            var matches = regex.Matches(s);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
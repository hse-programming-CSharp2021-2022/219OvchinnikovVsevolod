using System;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var Code = Console.ReadLine();
            char codeInt = (char) int.Parse(Code);
            Console.WriteLine(codeInt);
        }
    }
}
using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string score = Console.ReadLine();
            string result = "";
            switch (score)
            {
                case "1":
                    result = "неудовлетворительно";
                    break;
                case "2":
                    result = "неудовлетворительно";
                    break;
                case "3":
                    result = "неудовлетворительно";
                    break;
                case "4":
                    result = "удовлетворительно";
                    break;
                case "5":
                    result = "удовлетворительно";
                    break;
                case "6":
                    result = "хорошо";
                    break;
                case "7":
                    result = "хорошо";
                    break;
                case "8":
                    result = "отлично";
                    break;
                case "9":
                    result = "отлично";
                    break;
                case "10":
                    result = "отлично";
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
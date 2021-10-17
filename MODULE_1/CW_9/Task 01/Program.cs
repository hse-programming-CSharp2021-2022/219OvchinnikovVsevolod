using System;

namespace Task_01
{
    class Program
    {
        static Random gen = new Random();

        public static int GetIntValue(string prompt)
        {
            int intVal;
            do
                Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out intVal));
            return intVal;
        }

        public static string MoveOff(string source, string charsToDelete)
        {
            string res = source;
            int index;
            for (int i = 0; i < charsToDelete.Length; i++)
                while ((index = res.IndexOf(charsToDelete[i])) >= 0)
                    res = res.Remove(index, 1);
            return res;
        }

        public static string CreateString(int k, char minChar, char maxChar)
        {
            if (k < 0)
                return null; // throw new Exception("Аргумент метода должен быть положительным!");
            // minChar, minChar - Границы диапазона символов.
            if (maxChar < minChar)
            {
                char c = minChar;
                minChar = maxChar;
                maxChar = c;
            }

            // пустая строка, останется пустой, если символов 0
            string line = string.Empty;
            for (int i = 0; i < k; i++)
                line += (char) gen.Next(minChar, maxChar + 1);
            return line;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string generatedString = CreateString(n, '0', '9');
            Console.WriteLine(generatedString);
            Console.WriteLine(MoveOff(generatedString, "02468"));
        }
    }
}
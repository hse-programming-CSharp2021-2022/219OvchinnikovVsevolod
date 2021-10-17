using System;

namespace Task_02
{
    class Program
    {
        // проверка, что строки состоят только из символов латинского алфавита
// и пробелов
        public static bool Validate(string str)
        {
            // TODO: требуется валидировать строки с заглавные латинскими
            // символами также как верные
            char[] english = new char[27];
            english[0] = ' ';
            for (int i = 1; i < english.Length; i++)
            {
                english[i] = (char) ('a' + i);
            }

            if (str.IndexOfAny(english) < 0) return false;
            return true;
        } // end of Validate(string)

// получение массива строк
// каждый элемент проверен на соответствие формату
        public static string[] ValidatedSplit(string str, char ch)
        {
            string[] output = null;
            output = str.Split(ch);
            foreach (string s in output)
            {
                if (!Validate(s)) return null;
            }

            return output;
        } // end of ValidatdSplit(string, char)

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;

namespace Task_1
{
    class MyException : Exception
    {
        public MyException() { }
        public MyException(string message)
            : base(message) { }
    } 
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] array = new int[1];
                Console.WriteLine(array[1]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                int x = 0;
                Console.WriteLine(10 / x);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                var sw = new StreamReader("hfjbfjkskjnkjs.txt");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                File.ReadAllLines("C:/AHAHAH/a.txt");
            }
            catch (DirectoryNotFoundException  e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                object x = "shjbf";
                Console.WriteLine((int)x);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                int value = 900000000;
                int square = value * value;
                // P.S. у меня его не выбивает почему-то из-за Rider, хотя должно
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                int[,] array = new int[2, 5];
                Array.Sort(array);
            }
            catch (RankException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                string x = "shjbf";
                int y = int.Parse(x);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string x = null;
                x.Split();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                var s1 = new StreamWriter("file.txt");
                var s2 = new StreamWriter("file.txt");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                List<int> list = new List<int>();
                Console.WriteLine(list[-1]);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                throw new MyException("My exception");
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
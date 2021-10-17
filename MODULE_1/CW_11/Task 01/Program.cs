using System;
using System.IO;
using System.Text;

namespace CW_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Data.txt";
            // Создаем файл с данными
            // Сейчас данные для записи вбиты в коде
            // TODO1: сохранить в файл целые случайные значения из диапазона [10;100)
            string createText = "";
            try
            {
                File.WriteAllText(path, createText, Encoding.UTF8);

                // Open the file to read from
                if (File.Exists(path))
                {
                    string readText = File.ReadAllText(path);
                    string[] stringValues = readText.Split(' ');
                    int[] arr = StringArrayToIntArray(stringValues);
                    foreach (int i in arr)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        } // end of Main()

        // Красивая альтернатива 
        public static int[] StringArrayToIntArray(string[] str)
            => Array.ConvertAll(str, s =>
            {
                int.TryParse(s, out int tmp);
                return tmp;
            });
    }
}
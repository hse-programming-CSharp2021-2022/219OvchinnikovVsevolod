﻿/*
   Дисциплина: "Программирование"
   Группа: БПИ219
   Студент: Овчинников Всеволод
   Задача: Написать метод для вычисления площади и длины окружности, радиус которой задает вещественный параметр. 
   В основной программе, вводя значения радиуса, с помощью обращения к методу, вычислять площадь и длину окружности. При вводе применять метод double.TryParse() и проверять корректность введенного значения. При выводе использовать форматную строку метода WriteLine(). Окончание работы программы – ввод нулевого или отрицательного значения радиуса.    
   Дата: Сентябрь 2021
*/

using System;

namespace Task_02
{
    class Program
    {
        static double Square(double r)
        {
            return Math.PI * r * r;
        }

        static double Length(double r)
        {
            return Math.PI * r * 2.0;
        }

        static void Main(string[] args)
        {
            double r, //радиус
                s, // площадь круга
                c; // длина окружности        
            string str; // Рабочая строка для ввода и вывода данных 
            do
            {
                Console.Write("Введите радиус: ");
                str = Console.ReadLine(); //Читаем символьную строку
            } while (!double.TryParse(str, out r)); // Преобразуем в число

            c = Length(r);
            s = Square(r);
            str = $"L = {c}; S = {s}";
            // вычисления и строку с результатом ОФОРМИТЕ САМОСТОЯТЕЛЬНО!
            Console.WriteLine(str); // выводим строку с результатом
            Console.WriteLine("Для выхода из программы нажмите ENTER.");
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;

namespace Task_1
{
    class ConsolePlate
    {
        private char _plateChar;
        private ConsoleColor _plateColor;
        private ConsoleColor _backgroundColor;
        public char PlateChar
        {
            
            get => this._plateChar;
            set => this._plateChar = (int) value <= 31 ? '+' : value;
        }
        public ConsoleColor PlateColor
        { 
            get => this._plateColor;
            set => this._plateColor = value;
        }
        public ConsoleColor BackgroundColor
        { 
            get => this._backgroundColor;
            set => this._backgroundColor = (value != this._plateColor) ? value : throw new Exception("Invisible text not allowed.");
        }

        public ConsolePlate()
        {
            this._plateChar = '+';
            this._plateColor = ConsoleColor.White;
            this._backgroundColor = ConsoleColor.Black;
        }

        public ConsolePlate(char @char, ConsoleColor color, ConsoleColor backgroundColor)
        {
            if (color == backgroundColor)
                throw new Exception("Invisible text not allowed.");
            this._plateChar = @char;
            this._plateColor = color;
            this._backgroundColor = backgroundColor;
        }
        public void Print()
        {
            Console.ForegroundColor = this._plateColor;
            Console.BackgroundColor = this._backgroundColor;
            Console.Write(this._plateChar);
            Console.ResetColor();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConsolePlate plate1 = new ConsolePlate('X', ConsoleColor.White, ConsoleColor.Red);
            ConsolePlate plate2 = new ConsolePlate('O', ConsoleColor.White, ConsoleColor.White);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        plate1.Print();
                    }
                    else
                    {
                        plate2.Print();
                    }
                }
                Console.Write("\n");
            }
//            List<ConsolePlate> plates = new List<ConsolePlate>(60);
//            for (int i = 0; i < 60; i ++)
//            {
//                int index = i + 65;
//                plates.Add(new ConsolePlate((char) index,
//                    (index % 3 == 0) ? ConsoleColor.White : (index % 3 == 1) ? ConsoleColor.Blue : ConsoleColor.Red));
//            }
//
//            foreach (ConsolePlate consolePlate in plates)
//            {
//                consolePlate.Print();
//            }
        }
    }
}
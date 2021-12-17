using System;


namespace Task05
{
    class MyComplex
    {
        public double re, im;

        public MyComplex(double xre, double xim)
        {
            re = xre;
            im = xim;
        }

        // Неправильная реализация:
        //public static MyComplex operator ++(MyComplex mc)
        //{ mc.re++; mc.im++; return mc; }
        public static MyComplex operator --(MyComplex mc)
        {
            return new MyComplex(mc.re - 1, mc.im - 1);
        }
        public static MyComplex operator +(MyComplex mc)
        {
            return new MyComplex(mc.re - 1, mc.im - 1);
        }
        public override string ToString()
        {
            return base.ToString();
        }

        public double Mod()
        {
            return Math.Abs(re * re + im * im);
        }

        static public bool operator true(MyComplex f)
        {
            if (f.Mod() > 1.0) return true;
            return false;
        }

        static public bool operator false(MyComplex f)
        {
            if (f.Mod() <= 1.0) return true;
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine($"c = {Math.Sqrt((a * a) + (b * b))}");
        }
    }
}
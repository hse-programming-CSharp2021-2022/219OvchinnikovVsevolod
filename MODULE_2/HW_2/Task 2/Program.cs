using System;

namespace Task_2
{
    class Complex
    {
        private double re;
        private double im;

        public double Re
        {
            get => re;
            set => re = value;
        }
        public double Im
        {
            get => im;
            set => im = value;
        }

        public Complex()
        {
            this.re = 0;
            this.im = 0;
        }
        public Complex(double real, double imaginary)
        {
            this.re = real;
            this.im = imaginary;
        }

        public double Mod()
        {
            return Math.Sqrt(this.re * this.re + this.im * this.im);
        }

        public static Complex operator --(Complex c)
        {
            return new Complex(c.Re - 1, c.Im - 1);
        }
        public static bool operator true(Complex f)
        {
            return f.Mod() > 1;
        }

        public static bool operator false(Complex f)
        {
            return f.Mod() <= 1;
        }
        public override string ToString()
        {
            string result = "";
            if (Math.Abs(this.Re) > 0.00000000001)
            {
                result += $"{this.Re}";
            }

            if (Math.Abs(this.Im) < 0.0000000001)
            {
                return result;
            }

            if (this.Im < 0)
            {
                result += $"{this.Im}i";
            }
            else
            {
                result += $"+{this.Im}i";
            }

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex mc1 = new Complex(15, 2);
            Complex mc2 = new Complex(10, 1);
            mc1--;
            Console.WriteLine(mc1);
            Console.WriteLine(mc2);
        }
    }
}
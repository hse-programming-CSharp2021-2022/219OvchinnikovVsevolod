using System;

namespace Task_1
{
    public delegate double calculate(double x);

    interface IFunction
    { 
        double Function(double x);
    }
    
    class F : IFunction
    {
        calculate calc;
        
        public F(calculate c) => calc = c;

        public double Function(double x) => calc(x);
    }

    class G
    {
        F f1, f2;
        public G(F f1, F f2)
        {
            this.f1 = f1;
            this.f2 = f2;
        }
        public double GF(double x0) => f1.Function(f2.Function(x0));
    }

    class Program
    {
        static void Main(string[] args)
        {
            G g = new(new F((x) => x * x - 4), new F((x) => Math.Sin(x)));
            for (double i = 0; i <= Math.PI + Math.PI / 32; i += Math.PI / 16)
            {
                Console.WriteLine($"{g.GF(i):f4}");
            }
        }
    }
}
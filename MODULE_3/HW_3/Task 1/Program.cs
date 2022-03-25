using System;
using System.Linq;

namespace Task_1
{
    delegate void CoordChanged(Dot dot);

    class Dot
    {
        double x;
        double y;

        public event CoordChanged OnCoordChanged;

        public Dot(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void DotFlow()
        {
            Random rand = new();
            for (int i = 0; i < 10; i++)
            {
                x = rand.NextDouble() * 20 - 10;
                y = rand.NextDouble() * 20 - 10;
                if (x < 0 && y < 0)
                {
                    if (OnCoordChanged != null) OnCoordChanged(this);
                }
            }
        }

        public override string ToString() => $"{x:f2} {y:f2}";
    }

    class Program
    {
        public static void Output(Dot a)
        {
            Console.WriteLine(a);
        }

        static void Main(string[] args)
        {
            double[] xy = Console.ReadLine()?.Split().Select(double.Parse).ToArray();
            if (xy != null)
            {
                Dot d = new(xy[0], xy[1]);
                d.OnCoordChanged += Output;
                d.DotFlow();
            }
        }
    }
}
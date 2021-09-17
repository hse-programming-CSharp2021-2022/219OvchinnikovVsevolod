using System;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            float sm = 0;
//            double previous = 1 / (2 * 3 * 4);
//            double current = 1 / ()
            int i = 1;
            while (sm + ((float)1.0 / (i * (i + 1) * (i + 2))) > sm)
            {
                sm += (float)1.0 / (i * (i + 1) * (i + 2));
            }
            Console.WriteLine(sm);
        }
    }
}
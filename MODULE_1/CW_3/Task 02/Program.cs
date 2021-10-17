using System;

namespace Task_02
{
    class Program
    {
        public static bool Function1(bool p, bool q)
        {
            return !(p && q) && (!(p | !q));
        }

        public static void Function2(out bool x, bool p, bool q)
        {
            x = !(p && q) && (!(p | !q));
            return;
        }

        static void Main(string[] args)
        {
            bool[] flags = { false, true };
            for (var p = 0; p < flags.Length; p += 1)
            {
                for (var q = 0; q < flags.Length; q += 1)
                {
                    var t = Function1(flags[p], flags[q]);
                    var f = false;
                    Function2(out f, flags[p], flags[q]);
                    Console.WriteLine($"{flags[p]} {flags[q]} {t} {f}");
                }
            }
        }
    }
}
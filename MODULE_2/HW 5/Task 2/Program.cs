using System;
using System.Collections.Generic;

namespace Task_2
{
    public class Cindrella
    {
        public abstract class Something
        {
            public Random rnd = new Random((int)DateTime.Now.Ticks);
        };

        public class Lentil : Something
        {
            private double Weight => this.rnd.Next(0, 20) / 10.0;

            public override string ToString() => $"Lentil, Weight = {this.Weight}";
        }

        public class Ashes : Something
        {
            private double Volume => this.rnd.Next(0, 10) / 10.0;
            public override string ToString() => $"Ashes, Volume = {this.Volume}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random((int)DateTime.Now.Ticks);
            Cindrella.Something[] somethings = new Cindrella.Something[n];
            for (int i = 0; i < n; i++)
            {
                somethings[i] = rnd.Next(0, 2) == 0 ? (Cindrella.Something) new Cindrella.Ashes() : new Cindrella.Lentil();
                Console.WriteLine(somethings[i]);
            }
            List<Cindrella.Ashes> ashes = new List<Cindrella.Ashes>();
            List<Cindrella.Lentil> lentils = new List<Cindrella.Lentil>();
            foreach (var something in somethings)
            {
                if(something is Cindrella.Lentil)
                    lentils.Add((Cindrella.Lentil)something);
                if(something is Cindrella.Ashes)
                    ashes.Add((Cindrella.Ashes)something);
            }
            Console.WriteLine("===============");
            foreach (Cindrella.Ashes ash in ashes)
            {
                Console.WriteLine(ash);
            }
            Console.WriteLine("===============");
            foreach (Cindrella.Lentil lentil in lentils)
            {
                Console.WriteLine(lentil);
            }
        }
    }
}
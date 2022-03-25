using System;

namespace Task_6
{
    class Plant
    {
        private double _growth;
        private double _photosensitivity;
        private double _frostresistance;
        public double Growth { get => this._growth; set { this._growth = value; } }
        public double Photosensitivity { get => this._photosensitivity; set { this._photosensitivity = Math.Clamp(value, 0, 100); } }
        public double Frostresistance { get => this._frostresistance; set { this._frostresistance = Math.Clamp(value, 0, 100); } }
        public Plant(double growth, double photosensitivity, double frostresistance)
        {
            _growth = growth;
            _photosensitivity = photosensitivity;
            _frostresistance = frostresistance;
        }
        public override string ToString()
        {
            return $"{_growth:f2} {_photosensitivity:f2} {_frostresistance:f2}";
        }
    }

    class Program
    {
        public static int SortByPhotosensitivity(Plant a, Plant b)
        {
            if (a.Photosensitivity % 2 == 1 && b.Photosensitivity % 2 == 0) return 1;
            return -1;
        }

        static void Main(string[] args)
        {
            Random rand = new();
            int n = int.Parse(Console.ReadLine());
            Plant[] plants = new Plant[n];
            for (int i = 0; i < n; i++)
            {
                plants[i] = new(rand.NextDouble() * 75 + 25, rand.NextDouble() * 100, rand.NextDouble() * 80);
            }
            Array.ForEach(plants, (t) => Console.WriteLine(t));
            Console.WriteLine();
            Array.Sort(plants, delegate (Plant a, Plant b)
            {
                if (a.Growth < b.Growth) return 1;
                return -1;
            });
            Array.ForEach(plants, (t) => Console.WriteLine(t));
            Console.WriteLine();
            Array.Sort(plants, (a, b) =>
            {
                if (a.Frostresistance > b.Frostresistance) return 1;
                return -1;
            });
            Array.ForEach(plants, (t) => Console.WriteLine(t));
            Console.WriteLine();
            Array.Sort(plants, SortByPhotosensitivity);
            Array.ForEach(plants, (t) => Console.WriteLine(t));
            Console.WriteLine();
            Array.ConvertAll(plants, (t) => new Plant(t.Growth, (int) t.Frostresistance % 2 == 0 ? t.Frostresistance /= 3 : t.Frostresistance /= 2, t.Frostresistance));
            Array.ForEach(plants, (t) => Console.WriteLine(t));
            Console.WriteLine();
        }
    }
}
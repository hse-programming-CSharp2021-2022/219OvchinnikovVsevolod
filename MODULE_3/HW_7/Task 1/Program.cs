using System;
using System.Linq;

namespace Task_1
{
    class Randomizer
    {
        public Random rand = new();

        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(
                Enumerable.Repeat(chars, length)
                    .Select(s => s[rand.Next(s.Length)]).ToArray()
            );
        }
    }

    readonly struct Person : IComparable
    {
        private readonly string _name;
        private readonly string _surname;
        private readonly int _age;
        public Person(string n, string sn, string a)
        {
            _name = n;
            _surname = sn;
            if (!int.TryParse(a, out _age) || _age < 0)
                throw new ArgumentOutOfRangeException(nameof(a), "Argument should not be less than zero.");
        }

        public int CompareTo(object obj) => ((Person) obj)._age < _age ? 1 : -1;

        public override string ToString() => $"{_name} {_surname} {_age}";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Randomizer rnd = new();
            int n = 5;
            Person[] characters = new Person[n];
            for (int i = 0; i < n; i++)
            {
                characters[i] = new(
                    rnd.RandomString(rnd.rand.Next(5, 11)),
                    rnd.RandomString(rnd.rand.Next(7, 11)),
                    rnd.rand.Next(1, 101).ToString()
                );
            }
            foreach (Person p in characters)
                Console.WriteLine(p);
            Console.WriteLine("\n");
            Array.Sort(characters);
            foreach (Person p in characters)
                Console.WriteLine(p);
        }
    }
}
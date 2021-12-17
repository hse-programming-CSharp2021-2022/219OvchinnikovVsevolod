using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Task_1
{
    public class Creature
    {
        public string Name;
        public double Speed;

        public Creature()
        {
            this.Name = "UNKWN";
            this.Speed = 0;
        }

        public Creature(string name, double speed)
        {
            this.Name = name;
            this.Speed = speed;
        }

        public virtual string Run() => $"I am running with speed of {this.Speed}.";
        public override string ToString() => $"{this.Run()} My name is {this.Name}.";
    }

    public class Dwarf : Creature
    {
        public uint _strength;
        public uint Strength
        {
            get { return this.Strength; }
        }

        public Dwarf()
        {
            this.Name = "UNKWN";
            this.Speed = 0;
            this._strength = 0;
        }

        public Dwarf(string name, double speed, uint strength)
        {
            this.Name = name;
            this.Speed = speed;
            Random rnd = new Random((int) DateTime.Now.Ticks);
            if (strength < 1 || strength > 20)
            {
                strength = (uint) rnd.Next(1, 21);
            }
            this._strength = strength;
        }

        public virtual string Run() => $"I am running with speed of {this.Speed}. My strength is: {this.Strength}";

        public void MakeNewStaff()
        {
            Console.WriteLine("I've created a new staff.");
        }
    }

    public class Elf : Creature
    {
        public int Period = 77;

        public uint Age
        {
            get => this.Age;
            set => this.Age = value;
        }

        public Elf()
        {
            this.Name = "UNKWN";
            this.Speed = 0;
            this.Age = 0;
        }

        public Elf(string name, double speed)
        {
            Random rnd = new Random((int) DateTime.Now.Ticks);
            this.Name = name;
            this.Speed = speed;
            this.Age = (uint) rnd.Next(100, 201);
        }

        public override string Run() =>
            $"I am running with speed of {this.Speed + this.Age / this.Period}. My age is: {this.Age}";
    }

    class Program
    {
        public static string GenerateName(int length, bool caps = false)
        {
            Random rnd = new Random((int) DateTime.Now.Ticks);
            string chars = "";
            if (!caps)
                chars = "abcdefghijklmnopqrstuvwxyz";
            else
                chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }

        public static string RandomName()
        {
            Random rnd = new Random((int) DateTime.Now.Ticks);
            return GenerateName(1, true) + GenerateName(rnd.Next(2, 10));
        }

        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                Random rnd = new Random((int) DateTime.Now.Ticks);
                List<Creature> creatures = new List<Creature>();
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    int t = rnd.Next(0, 10);
                    if (t < 2)
                        creatures.Add(new Creature(RandomName(), rnd.Next(10, 19)));
                    else if (t < 6)
                        creatures.Add(new Dwarf(RandomName(), rnd.Next(10, 19), (uint)rnd.Next(-50, 51)));
                    else
                        creatures.Add(new Elf(RandomName(), rnd.Next(10, 19)));
                }

                foreach (Creature creature in creatures)
                {
                    Console.WriteLine(creature);
                }
                foreach (Creature creature in creatures)
                {

                    if (creature is Dwarf)
                    {
                        Dwarf dwarf;
                        dwarf = (Dwarf) creature;
                        dwarf.MakeNewStaff();
                    }
                }
                Console.WriteLine("Would u like to generate again? Press ESC to exit. Other Key - generate");
                run = Console.ReadKey().Key != ConsoleKey.Escape;
            }
        }
    }
}
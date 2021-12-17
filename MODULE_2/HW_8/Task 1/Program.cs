using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    abstract class Person
    {
        private string name;
        private string pocket;
        public Random random = new Random();
        public string Name { get => this.name; set => this.name = value; }
        public  string Pocket { get => this.pocket; set => this.pocket = value; }

        public abstract void Receive(string present);

        public Person(string name)
        {
            this.Name = name;
            this.Pocket = "";
        }

        public override string ToString() => $"Name = {Name} Pocket = {Pocket}";
    }
    class SnowMaiden : Person
    {
        public SnowMaiden(string name) : base(name){}

        public override void Receive(string present)
        {
            if (this.Pocket == "")
                this.Pocket = present;
            else
                throw new ArgumentException("Non-Empty pocket");
        }

        private string GenerateName()
        {
            int n = 3;
            StringBuilder name = new StringBuilder();
            for (var i = 0; i < n; i++)
                name.Append(random.Next((int)'a', (int)'z' + 1));
            for (var i = 1; i >= 0; i--)
                name.Append(name[i]);
            return name.ToString();
        }

        public string[] CreatePresents(int amount)
        {
            string[] presents = new string[amount];
            for (var i = 0; i < amount; i++)
                presents[i] = this.GenerateName();
            return presents;
        }
    }

    class Santa : Person
    {
        private List<string> sack;

        public void Request(SnowMaiden snowMaiden, int amount) => sack.AddRange(snowMaiden.CreatePresents(amount));

        public Santa(string name) : base(name){}
        public override void Receive(string present)
        {
            if (this.Pocket == "")
                this.Pocket = present;
            else
                throw new ArgumentException("Non-Empty pocket");
        }

        public void Give(Person person)
        {
            if (sack.Count > 0)
            {
                int t = random.Next(0, sack.Count);
                person.Receive(sack[t]);
                sack.RemoveAt(t);
            }
            else
                throw new Exception("No more gifts available.");
        }
    }
    class Child : Person
    {
        
        private string additionalPocket;
        public string AdditionalPocket { get => this.additionalPocket; set => this.additionalPocket = value; }

        public Child(string name) : base(name) => this.additionalPocket = "";

        public override void Receive(string present)
        {
            if (this.Pocket == "")
                this.Pocket = present;
            else if (this.additionalPocket == "")
                AdditionalPocket = present;
            else
                throw new ArgumentException("Both pockets are not empty");
        }

        public override string ToString() => $"Name = {this.Name} Pocket1 = {this.Pocket} Pocket2 = {this.additionalPocket}";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Santa santa = new Santa("Papa");
            SnowMaiden snowMaiden = new SnowMaiden("Mama");
            var people = new List<Person>(12);
            people.Add(santa);
            people.Add(snowMaiden);
            for (var i = 0; i < 10; i++)
                people.Add(new Child($"Seva_{i}"));
            Console.Write("==========");
            for (var i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i]);
            }
            Console.Write("==========");
            Random random = new Random();
            bool maidenAlive = true;
            while (true)
            {
                if (random.Next(0, 10) < 1)
                {
                    try
                    {
                        santa.Give(santa);
                        Console.WriteLine(santa);
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine("SANTA KILLED!");
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        if(maidenAlive)
                            santa.Request(snowMaiden, random.Next(1, 5));
                        else
                        {
                            break;
                        }
                    }
                    continue;
                }
                int t = random.Next(1, people.Count);
                if (people.Count == 2 && people[1] is SnowMaiden)
                    break;
                try
                {
                    santa.Give(people[t]);
                    Console.WriteLine(people[t]);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    people.RemoveAt(t);
                    if (t == 1 && maidenAlive)
                        maidenAlive = false;
                }
                catch
                {
                    if (maidenAlive)
                        santa.Request(snowMaiden, random.Next(1, 5));
                }
            }
        }
    }
}
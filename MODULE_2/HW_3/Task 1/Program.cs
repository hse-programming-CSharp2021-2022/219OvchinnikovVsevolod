using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_1
{
    class VideoFile
    {
        private string _name;
        private int _duration;
        private int _quality;

        public int Size
        {
            get => this._duration * this._quality;
        }

        public VideoFile(string name, int duration, int quality)
        {
            this._name = name;
            this._duration = duration;
            this._quality = quality;
        }

        public override string ToString()
        {
            return $"Video {this._name}. Size={this.Size} Duration={this._duration} Quality={this._quality}";
        }

        
    }

    class Program
    {
        public static string GenerateName(int length)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                Random rnd = new Random((int) DateTime.Now.Ticks);
                int n = rnd.Next(5, 16);
                List<VideoFile> files = new List<VideoFile>();
                Console.WriteLine("======ALL FILES======");
                for (int i = 0; i < n; i++)
                {
                    int duration = rnd.Next(60, 361);
                    int quality = rnd.Next(100, 1000);
                    files.Add(new VideoFile(GenerateName(rnd.Next(2, 10)), duration, quality));
                    Console.WriteLine(files[i]);
                }

                Console.WriteLine("=====CHOSEN FILE=====");
                int randFile = rnd.Next(0, files.Count);
                Console.WriteLine(files[randFile]);
                Console.WriteLine("====FILTERED FILES===");
                foreach (VideoFile videoFile in files)
                {
                    if (videoFile.Size > files[randFile].Size)
                    {
                        Console.WriteLine(videoFile);
                    }
                }
                Console.WriteLine("=====================");
                Console.WriteLine("Would u like to generate again? Press ESC to exit. Other Key - generate");
                run = Console.ReadKey().Key != ConsoleKey.Escape;
            }
        }
    }
}
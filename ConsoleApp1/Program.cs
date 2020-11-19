using System;
using System.IO;

namespace CreateFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text FIle name");
            string userinput = Console.ReadLine();
            CreteFilewithextension(userinput);
        }
        public static void CreateNewFile()
        {
            string rootpath = @"C:\Users\opilane\samples\Player1";
            string filename = "ball.txt";
            File.Create(Path.Combine(rootpath, filename));
        }
        public static void CreateuserFile(string filename)
        {
            string rootpath = @"C:\Users\opilane\samples\Player2";
            File.Create(Path.Combine(rootpath, filename));
        }
        public static void CreteFilewithextension(string filename)
        {
            string rootpath = @"C:\Users\opilane\samples\Player2";
            string fullfilename = $"{filename}.txt";
            File.Create(Path.Combine(rootpath, fullfilename));
        }
    }
}

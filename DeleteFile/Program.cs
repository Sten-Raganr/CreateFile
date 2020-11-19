using System;
using System.IO;

namespace DeleteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileDelete();
        }
        public static void FileDelete()
        {
            string rootpath = @"C:\Users\opilane\samples\Player2";
            string filename = "ball.txt";
            if (File.Exists(Path.Combine(rootpath, filename)))
            {
                File.Delete(Path.Combine(rootpath, filename));
                Console.WriteLine("File Deleted!");
            }
            else
            {
                Console.WriteLine("file not found");
            }
        }
    }
}

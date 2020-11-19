using System;
using System.IO;

namespace MoveFile
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Movefile();
        }
        public static void Movefile()
        {
            string sourcedirectory = @"C:\Users\opilane\samples\Player1";
            string destinationpath = @"C:\Users\opilane\samples\Player2";
            string filename = "ball.txt";

            File.Move(Path.Combine(sourcedirectory,filename), Path.Combine(destinationpath, filename));
        }
    }
}

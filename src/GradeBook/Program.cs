using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 34.1;
            double y = 23.4;
            var z = x + y;
            Console.WriteLine(z);
            if(args.Length>0)
            {
            Console.WriteLine("Hello" + args[0] + "!");
        }
        else
        {
            Console.WriteLine("Yello!");
        }
        }
        }}


using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";

            if (args.Length > 0)
            {
                name = args[0];
            }

            Console.WriteLine("Witaj " + name);

            //foreach (string item in args)
            //{
            //    Console.WriteLine("Witaj " + item);
            //}
        }
    }
}

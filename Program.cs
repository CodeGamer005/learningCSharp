using System;

namespace csharp_tutorial {
    class games 
    {
        public string name;
        public int yearReleased;

        public void print()
        {
            Console.WriteLine(name + " is a great game");
            Console.WriteLine("it was released in the year " + yearReleased);
        }
    }

    class Program{

        static void Main(String[] args)
        {
            Console.Title = "Skynet";  
            Console.WindowHeight = 40;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            games game01 = new games();
            game01.name = "breath of the wild";
            game01.yearReleased = 2017;

            game01.print();
            Console.ReadKey();
            

        }
    }
}
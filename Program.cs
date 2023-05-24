using System;

namespace csharp_tutorial {
    class wizard 
    {
        public string name;
        public string activespell;
        public int totalSpells;
        public float exp;

        public void callevent()
        {
            if (totalSpells > 0)
            {
                 Console.WriteLine(name + " used the spell " + activespell);
                 totalSpells--;
                 exp += 0.5f;
            }
            else 
            {
                Console.WriteLine("all spells have been used");
            }
           
            
        }
         
        public void rest()
        {
            Console.WriteLine(name + " rested to regain spells");
            totalSpells = 3;
        }
    }

    class Program{

        static void Main(String[] args)
        {
            Console.Title = "Skynet";  
            Console.WindowHeight = 40;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            wizard wizard01 = new wizard();
            wizard01.name = "gandalf";
            wizard01.activespell = "fire";
            wizard01.totalSpells = 3;
            wizard01.exp = 0f;

            wizard01.callevent();
            wizard01.callevent();
            wizard01.callevent();
            wizard01.callevent();

            wizard01.rest();
            wizard01.callevent();
            wizard01.callevent();
            
            Console.WriteLine(wizard01.name + " gained " + wizard01.exp + " exp");
            Console.ReadKey();
            

        }
    }
}

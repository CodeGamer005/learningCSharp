using System;

namespace csharp_tutorial {
    class Wizard 
    {
        public string name;
        public string activespell;
        public int totalSpells;
        public float exp;

        static public int Count;

        public Wizard(string _name, string _activespell)
        {
            name = _name;
            activespell = _activespell;
            totalSpells = 3;
            exp = 0f;
            Count++;
        }

        public void attack()
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

            Wizard wizard01 = new Wizard("gandalf", "thunder");
            Wizard wizard02 = new Wizard("impoter", "sus");

            wizard01.attack();
            wizard02.attack();
            
            
            Console.WriteLine(wizard01.name + " gained " + wizard01.exp + " exp");
            Console.WriteLine(wizard02.name + " gained " + wizard02.exp + " exp");

            Console.WriteLine(Wizard.Count);
            Console.ReadKey();
            

        }
    }
}
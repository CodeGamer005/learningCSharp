using System;
namespace csharp_tutorial
{
    class weapons
    {
        public virtual void weaponDMG()
        {
            Console.WriteLine("weapon does ... damage");
        }
    }

    class sword : weapons 
    {
        public override void weaponDMG()
        {
            Console.WriteLine("sword does 2 damage");
        }
    }

    class gun : weapons
    {
        public override void weaponDMG()
        {
            Console.WriteLine("Gun does 4 damage");
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            weapons weapon01 = new weapons();
            weapons mySword = new sword();
            weapons myGun = new gun();

            weapon01.weaponDMG();
            mySword.weaponDMG();
            myGun.weaponDMG();
            Console.ReadLine();
        }
    }
}
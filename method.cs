using System;
namespace csharp_tutorial {
    class my_method{

        static void mymethod(){
            Console.WriteLine("hello " + name);
        }

        static void Main(String[] args){
            Console.Write("enter your name: ");
            string name = Console.ReadLine();

            mymethod(name);
            Console.ReadLine();
        }
    }
}
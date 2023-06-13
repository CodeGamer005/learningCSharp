using System;

namespace csharp_tutorial 
{
    class program 
    {
        public static void Main(String[] args)
        {
            Console.Title = "Calculator";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==================================");
            Console.WriteLine("\t \t  CLI CALCULATOR");
            Console.WriteLine("==================================");

            op1();

            
        }

        public static void op1()
        {
           Console.WriteLine("enter number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("enter operator: ");
                string? op = Console.ReadLine();

                Console.WriteLine("enter 2nd number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double ans;

                switch (op)
                {
                    case "+" :
                    ans = num1 + num2;
                    Console.WriteLine("ans: " + ans);
                    break;

                     case "-" :
                    ans = num1 - num2;
                    Console.WriteLine("ans: " + ans);
                    break;

                     case "*" :
                    ans = num1 * num2;
                    Console.WriteLine("ans: " + ans);
                    break;

                     case "/" :
                    ans = num1 / num2;
                    Console.WriteLine("ans: " + ans);
                    break;

                    default:
                    Console.WriteLine("error");
                    break;
                }
                
             Console.WriteLine("continue(y/n): ");
             string? cont = Console.ReadLine();

             if(cont == "y")
             {
                Console.Clear();
                op2();

             }
             else
             {
                Console.Clear();
                Console.WriteLine("press any key to exit");
                Console.ReadLine();

             }     
        }

        public static void op2()
        {
            Console.WriteLine("enter number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("enter operator: ");
                string? op = Console.ReadLine();

                Console.WriteLine("enter 2nd number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double ans;

                switch (op)
                {
                    case "+" :
                    ans = num1 + num2;
                    Console.WriteLine("ans: " + ans);
                    break;

                     case "-" :
                    ans = num1 - num2;
                    Console.WriteLine("ans: " + ans);
                    break;

                     case "*" :
                    ans = num1 * num2;
                    Console.WriteLine("ans: " + ans);
                    break;

                     case "/" :
                    ans = num1 / num2;
                    Console.WriteLine("ans: " + ans);
                    break;

                    default:
                    Console.WriteLine("error");
                    break;
                }
                
             Console.WriteLine("continue(y/n): ");
             string? cont = Console.ReadLine();

             if(cont == "y")
             {
                Console.Clear();
                op1();

             }
             else
             {
                Console.Clear();
                Console.WriteLine("press any key to exit");
                Console.ReadLine();

             }

        }
    }

}


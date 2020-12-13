/*
* This Application is Created by:
* Dandre Mitchel R. Collera
* github.com/xAzurine
*
* Simple menu to submenu snippet
* C# Console App (.NET Framework)
*/
using System;

namespace randomz
{
    class Program
    {
        static void Main(string[] args)
        {
            char op;
            //Main Menu
            while(true)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("A. Basic");
                Console.WriteLine("B. Intermediate");
                Console.WriteLine("C. Extra");
                op = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                Console.Clear();
                if(op == 'A')
                {
                    // Basic Menu
                    while(true)
                    {
                        char op2;
                        Console.WriteLine("Basic Menu");
                        Console.WriteLine("A. Test App");
                        op2 = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                        Console.Clear();
                        if(op2 == 'A')
                        {
                            while(true)
                            {
                                char op3;
                                Console.WriteLine("Welcome to Test App");
                                Console.Write("Do you want to quit?");
                                op3 = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                                if(op3 == 'Y')
                                {
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}

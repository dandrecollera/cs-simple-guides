/*
* This Application is Created by:
* Dandre Mitchel R. Collera
* github.com/xAzurine
*
* How to use:
* Run the code. First enter the size of the pattern then
* enter mode to generate the pattern according to your choice.
*
* Modes
* 1: 1st Half
* 2: 2nd Half
* 3: Reverse 1st Half
* 4: Reverse 2nd Half
* 5: Whole Triangle
* 6: Reverse Triangle
* 7: Diamond
* 8. Hollow Diamond
*/




using System;

namespace StarPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, mode;
            Console.Write("Enter Size: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Mode: ");
            mode = Convert.ToInt32(Console.ReadLine());      
            Console.Clear();

            // 1st Half
            if (mode == 1)
            {
                for (int a = n; a >= 1; a--)
                {
                    for (int b = 1; b < a; b++)
                    {
                        Console.Write(" ");
                    }
                    for (int c = n; c >= a; c--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            // 2nd Half
            else if (mode == 2)
            {
                for (int a = 1; a <= n; a++)
                {
                    for (int b = 1; b <= a; b++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            // Reverse 1st Half
            else if (mode == 3)
            {
                for(int a = n; a >= 1; a--)
                {
                    for(int b = a; b < n; b++)
                    {
                        Console.Write(" ");
                    }
                    for(int c = 1; c <= a; c++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            // Reverse 2nd Half
            else if(mode == 4)
            {
                for(int a = n; a >= 1; a--)
                {
                    for(int b = 1; b <= a; b++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            // Whole Triangle
            else if(mode == 5)
            {
                for (int a = 1; a <= n; a++)
                {
                    for (int b = 1; b <= n - a; b++)
                    {
                        Console.Write(" ");
                    }
                    for (int b = 1; b <= 2 * a - 1; b++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            // Reverse Triangle
            else if(mode == 6)
            {
                for (int a = n; a >= 1; a--)
                {
                    for (int b = 1; b <= n - a; b++)
                    {
                        Console.Write(" ");
                    }
                    for (int b = 1; b < a * 2; b++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            // Diamond
            else if(mode == 7)
            {
                for (int a = 1; a <= n; a++)
                {
                    for (int b = 1; b <= n - a; b++)
                    {
                        Console.Write(" ");
                    }
                    for (int b = 1; b < a * 2; b++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                for (int a = n - 1; a >= 1; a--)
                {
                    for (int b = 1; b <= n - a; b++)
                    {
                        Console.Write(" ");
                    }
                    for (int b = 1; b < a * 2; b++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            //Hollow Diamond
            else
            {
                for (int a = 1; a <= n; a++)
                {
                    for (int b = a; b <= n; b++)
                    {
                        Console.Write("*");
                    }
                    for (int b = 1; b <= (2 * a - 2); b++)
                    {
                        Console.Write(" ");
                    }
                    for (int b = a; b <= n; b++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                for (int a = 1; a <= n; a++)
                {
                    for (int b = 1; b <= a; b++)
                    {
                        Console.Write("*");
                    }
                    for (int b = (2 * a - 2); b < (2 * n - 2); b++)
                    {
                        Console.Write(" ");
                    }
                    for (int b = 1; b <= a; b++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }            
        }    
    }
}

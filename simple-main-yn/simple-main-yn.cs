/*
* This Application is Created by:
* Dandre Mitchel R. Collera
* github.com/xAzurine
*
* Simple Yes or No snippet
* C# Console App (.NET Framework)
*/

using System;

namespace randomz
{
    class Program
    {
        static void Main(string[] args)
        {
            char decision = 'Z'; //Set Default to Z
            while(decision != 'N')
            {
                //code here

                Console.Write("Would you like to try again? Y/N: ");
                decision = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
                if(decision == 'Y')
                {
                    Console.WriteLine("Trying Again.");
                    continue;
                }
                else if(decision == 'N')
                {
                    decision = 'N';
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }
            }
        }
    }
}

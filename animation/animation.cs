/*
* This Application is Created by:
* Dandre Mitchel R. Collera
* github.com/xAzurine
*
* Simple Loading Animations in 
* C# Console App (.NET Framework)
*/

using System;
using System.Threading.Tasks;

namespace animations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("LOADING: ");
            for(int i = 0; i <= 10; i++)
            {
                Console.Write("▀");
                Task.Delay(50).Wait();
            }
            Console.Write(" OK!");
            Console.ReadKey();
        }
    }
}

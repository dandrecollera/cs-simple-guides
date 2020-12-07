/*
* This Application is Created by:
* Dandre Mitchel R. Collera
* github.com/xAzurine
*
* Simple code to mask password in 
* C# Console App (.NET Framework)
*/

using System;

namespace passwordmasking
{
    class Program
    {
        public string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        password = password.Substring(0, password.Length - 1);
                        int pos = Console.CursorLeft;
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        Console.Write(" ");
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }
            Console.WriteLine();
            return password;
        }
        static void Main(string[] args)
        {
            Program def = new Program();
            string uName, pass;
            Console.Write("username: ");
            uName = Console.ReadLine();
            Console.Write("password: ");
            pass = def.ReadPassword();
            if(uName == "admin" && pass == "password")
            {
                Console.Write("\nOK!");
            }
            else
            {
                Console.Write("\nWrong!");
            }
        }
    }
}

# cs-simple-guides
Compilation of C# guides, from simple algorithms and designs for C# Console App.

List of Guides
  1. [C# Patterns](https://github.com/dandrecollera/cs-simple-guides#c-patterns)
  2. [Password Masking](https://github.com/dandrecollera/cs-simple-guides#password-masking)
  3. [Simple Loading Animations](https://github.com/dandrecollera/cs-simple-guides#simple-loading-animations)
  4. [Simple Yes or No Loop](https://github.com/dandrecollera/cs-simple-guides#simple-yes-or-no-loop)

# C# Patterns
Create C# Pattern using for loop.

## Patterns Included
- [Asterisk](https://github.com/dandrecollera/cs-simple-guides#asterisk)
  - [1st Half](https://github.com/dandrecollera/cs-simple-guides#1st-half)
  - [2nd Half](https://github.com/dandrecollera/cs-simple-guides#2nd-half)
  - [Reversed 1st Half](https://github.com/dandrecollera/cs-simple-guides#reversed-1st-half)
  - [Reversed 2nd Half](https://github.com/dandrecollera/cs-simple-guides#reversed-2nd-half)
  - [Triangle](https://github.com/dandrecollera/cs-simple-guides#whole-triangle)
  - [Reversed Triangle](https://github.com/dandrecollera/cs-simple-guides#reversed-triangle)
  - [Diamond](https://github.com/dandrecollera/cs-simple-guides#diamond)
  - [Hollow Diamond](https://github.com/dandrecollera/cs-simple-guides#hollow-diamond)

## Asterisk
### 1st Half
```cs
n = 5; //size of pattern
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
```
```
    *
   **
  ***
 ****
*****
```
### 2nd Half
```cs
n = 5; //size of pattern
for (int a = 1; a <= n; a++)
{
    for (int b = 1; b <= a; b++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
```
```
*
**
***
****
*****
```
### Reversed 1st Half
```cs
n = 5; //size of pattern
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
```
```
*****
 ****
  ***
   **
    *
```
### Reversed 2nd Half
```cs
n = 5; //size of pattern
for(int a = n; a >= 1; a--)
{
    for(int b = 1; b <= a; b++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
```
```
*****
****
***
**
*
```
### Triangle
```cs
n = 5; //size of pattern
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
```
```
    *
   ***
  *****
 *******
*********
```
### Reversed Triangle
```cs
n = 5; //size of pattern
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
```
```
*********
 *******
  *****
   ***
    *
```
### Diamond
```cs
n = 5; //size of pattern
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
```
```
    *
   ***
  *****
 *******
*********
 *******
  *****
   ***
    *
```
### Hollow Diamond
```cs
n = 5; //size of pattern
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
```
```
**********
****  ****
***    ***
**      **
*        *
*        *
**      **
***    ***
****  ****
**********
```

# Password Masking
Convert Inputs into '*'.

```cs
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
```

# Simple Loading Animations
Spice things up in your C# Console Application using loading animations.

## Patterns Included
- [Loading Bar](https://github.com/dandrecollera/cs-simple-guides#loading-bar)
- [Spinning Line](https://github.com/dandrecollera/cs-simple-guides#spinning-line)

## Loading Bar
```cs
static void Main(string[] args)
{
    Console.Write("LOADING: ");
    for(int i = 0; i <= 10; i++)
    {
        Console.Write("▀");
        Task.Delay(50).Wait();
    }
    Console.Write(" OK!");
    Console.WriteLine();
}
```
```
LOADING: ▀▀▀▀▀▀▀▀▀▀▀ OK!
```

## Spinning Line
```cs
static void Main(string[] args)
{
    string[] load = new string[4] {"|", "/", "-", @"\"};
    int y = 0;
    for(int x = 0; x < load.Length * 2; x++)
    {
        Console.Clear();
        Console.WriteLine(load[y]);
        y++;
        Task.Delay(100).Wait();
        if(y == 4)
        {
            y = 0;
        }
    }
}
```
```
| (clear)
/ (clear)
- (clear)
\ (clear)
```

# Simple Yes or No Loop
Simple structure for yes or no prompt using while loop

```cs
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
```
##### Created by: Dandre Collera

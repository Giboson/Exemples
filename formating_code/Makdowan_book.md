# code_1

```C#

/**
using System;
Console.WriteLine("****Basic Console I/O*****");
GetUserData();
Console.ReadLine();
static void GetUserData()
{
    // Получить информацию об имени и возрасте.
    Console.Write("Please enter your name: "); // Предложить ввести имя
    string userName = Console.ReadLine();
    Console.Write("Please enter your age: "); // Предложить ввести возраст
    string userAge = Console.ReadLine();
    // Просто ради забавы изменить цвет переднего плана.
    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;
    // Вывести полученную информацию на консоль.
    Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);
    // Восстановить предыдущий цвет переднего плана.
    Console.ForegroundColor = prevColor;
    }
**/
        // Демонстрация применения некоторых дескрипторов формата,
        Console.WriteLine("The value 99999 in various formats:");
        Console.WriteLine("c format:{0:c}",     99999);
        Console.WriteLine("d9 format:{0:d9}",   99999);
        Console.WriteLine("f3 format:{0:f3}",   99999);
        Console.WriteLine("n format:{0:n}",     99999);
        // Обратите внимание, что использование для символа
        // шестнадцатеричного формата верхнего или нижнего регистра
        // определяет регистр отображаемых символов.
        Console.WriteLine("Е format:{0:E}", 99999);
        Console.WriteLine("е format:{0:X}", 99999);
        Console.WriteLine("X format:{0:x}", 99999);
        Console.WriteLine("x format:{0:e}", 99999);

```

# code_2

```C#

using System;
using System.Numerics;

/**
Console.WriteLine("=> Data Declarations:");
// Локальные переменные объявляются и инициализируются так:
// типДанных имяПеременной = начальноеЗначение;
int mylnt = 0;
string myString;
myString = "This is my character data";
// Объявить три переменных типа bool в одной строке,
bool b1 = true, b2 = false, b3 = b1;
// Использовать тип данных System.Boolean
// для объявления булевской переменной.
System.Boolean b4 = false;
Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}",
mylnt, myString, b1, b2, b3, b4);
Console.WriteLine();
**/


    Console.WriteLine("=> Using new to create variables:");
    bool b = new bool();             // Устанавливается в false
    int i = new int();              // Устанавливается в 0
    double d = new double();        // Устанавливается в 0.0
    DateTime dt = new DateTime();    // Устанавливается
                                    // в 1/1/0001 12:00:00 AM

    Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
    Console.WriteLine();
```

# code_3

```C#
            // Set up Console UI (CUI)
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("***********************************");
            Console.WriteLine("*****Welcome to My Rocking App*****");
            Console.WriteLine("***********************************");
            Console.BackgroundColor = ConsoleColor.Black;
            //  Wait for button  <Enter> kay to be Pressed
             Console.ReadLine();
/**
            Console.WriteLine("**************************");
            Console.WriteLine("***** My First C# App*****");
            Console.WriteLine("**************************");
            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("args: {0}", args[i]);
            }
             //  Wait for button  <Enter> kay to be Pressed
             Console.ReadLine();
            return 0;
**/

```

# code_4

```C#

```

```C#

```

```C#

```

```C#

```

```C#

```

```C#

```

```C#

```

```C#

```

```C#

```

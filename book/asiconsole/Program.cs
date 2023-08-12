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

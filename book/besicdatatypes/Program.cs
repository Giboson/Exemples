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



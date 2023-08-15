// For all sources

// Продемонстрировать применение условного оператора if.
using System;
class IfDemo 
    {
static void Main() 
    {
    int a, b, c;
    a = 2;
    b = 3;
    if(a < b) Console.WriteLine("а меньше b");
    // He подлежит выводу.
    if(a == b) Console.WriteLine("этого никто не увидит");
    Console.WriteLine();
    c = a - b; // с содержит -1
    Console.WriteLine("с содержит -1");
    if(c >= 0) Console.WriteLine("значение с неотрицательно");
    if(c < 0) Console.WriteLine("значение с отрицательно");
    Console.WriteLine();
    c = b - a; // теперь с содержит 1
    Console.WriteLine("с содержит 1");
    if(c >= 0) Console.WriteLine("значение с неотрицательно");
    if(c < 0) Console.WriteLine("значение с отрицательно ");

    }
}

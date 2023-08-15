// For all sources

// Продемонстрировать применение оператора цикла for.
using System;
class ForDemo
 {
    static void Main() 
    {
    int count;
    for(count = 0; count < 5; count = count+1)
    Console.WriteLine("Это подсчет: " + count);
    Console.WriteLine("Готово!");
    }
}

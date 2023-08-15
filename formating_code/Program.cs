// For all sources


    // Использовать тип byte.
    using System;
    class Use_byte 
    {
    static void Main() 
    {
    byte x;
    int sum;
    sum = 0;

     for(x = 1; x <= 100; x++)

    sum = sum + x;

    Console.WriteLine("Сумма чисел от 1 до 100 равна " + sum);
        }
    }
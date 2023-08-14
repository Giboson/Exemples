// For all sources

    using System;

    Console.WriteLine("**** Fun With type conversions ****");
    // Сложить две переменные типа short и вывести результат.
    short numb1 = 9, numb2 = 10;
    Console.WriteLine("{0} + {1} = {2}", numb1, numb2, Add(numb1, numb2));

    Console.ReadLine();
    static int Add(int x, int y)
    {
        return x + y;
    }
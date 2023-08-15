
# code_1

```cs

    // В эту версию не включена строка "using System;".
    using System;

    class Example 
    {
    // Любая программа на C# начинается с вызова метола Main().
    static void Main() 
    {
    // Здесь имя Console.WriteLine полностью определено.
    Console.WriteLine("Простая программа на С#.");
    }
    }


```

## code_2

```cs

    // Эта программа демонстрирует применение переменных.
    using System;

    class Example2 
    {
    static void Main() 
    {
    int x; // здесь объявляется переменная
    int y; // здесь объявляется еще одна переменная
    x = 100; // здесь переменной х присваивается значение 100
    Console.WriteLine("х содержит " + x);
    y = x / 2;
    Console.Write("у содержит х / 2: ");
    Console.WriteLine(y);
    }
    }
```

## code_3

```cs
/*
    * Эта программа демонстрирует отличия
    * между типами данных int и double.
*/
    using System;

    class Example3 
    {
    static void Main() 
    {
    int ivar; // объявить целочисленную переменную
    double dvar; // объявить переменную с плавающей точкой
        ivar = 100; // присвоить переменной ivar значение 100
        dvar = 100.0; // присвоить переменной dvar значение 100.0
    Console.WriteLine("Исходное значение ivar: " + ivar);
    Console.WriteLine("Исходное значение dvar: " + dvar);
    Console.WriteLine(); // вывести пустую строку
    // Разделить значения обеих переменных на 3.
        ivar = ivar / 3;
        dvar = dvar / 3.0;
    Console.WriteLine("Значение ivar после деления: " + ivar);
    Console.WriteLine("Значение dvar после деления: " + dvar);
    }
    }

```

## code_4

```cs
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

```

## code_5

```cs
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


```

## code_6

```cs
// Продемонстрировать применение кодового блока.
    using System;
    class BlockDemo 
    {
    static void Main() 
    {
    int i, j, d;
    i = 5 ;
    j = 10;
    // Адресатом этого оператора if служит кодовый блок.
    if(i != 0) {
    Console.WriteLine("i не равно нулю");
    d = j / i;
    Console.WriteLine("j / i равно " + d);
    }
    }
    }

```

## code_7

```cs
// Вычислить сумму и произведение чисел от 1 до 10.
    using System;

    class ProdSum 
    {
    static void Main() 
    {
    int prod;
    int sum;
    int i;
    sum = 0;
    prod = 1;
    for(i=1; i <= 10; i++)  
    {
    sum = sum + i;
    prod = prod * i;
    }
    Console.WriteLine("Сумма равна " + sum);
    Console.WriteLine("Произведение равно " + prod);
    }
    }

```

## code_8

```cs

    // Продемонстрировать применение идентификатора со знаком @.
    using System;

    class IdTest 
    {
    static void Main() 
    {
    int @if; // применение ключевого слова if
    // в качестве идентификатора
    for(@if = 0; @if < 10; @if++)
    Console.WriteLine("@if равно " + @if);
    }
    }

```

## code_9

```cs

    // Вычислить расстояние от Земли до Солнца в дюймах.
    using System;

    class Inches 
    {
    static void Main() 
    {
        long inches;
        long miles;
        miles = 93000000; // 93 000 000 миль до Солнца
    // 5 280 футов в миле, 12 дюймов в футе,
        inches = miles * 5280 * 12;
    Console.WriteLine("Расстояние до Солнца: " +
        inches + " дюймов.");
    }
    }

```

## code_10

```cs
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

```

## code_11

```cs
       // Определить радиус окружности по площади круга.
    using System;

    class FindRadius 
    {
    static void Main() 
    {
        Double r;
        Double area;
    area = 10.0;
        r = Math.Sqrt(area / 3.1416);
    Console.WriteLine("Радиус равен " + r);
    }
    }

```

## code_12

```cs
    
    // Продемонстрировать применение тригонометрических функций.
    using System;

    class Trigonometry 
    {
    static void Main() 
    {
    Double theta; // угол в радианах
        for(theta = 0.1; theta <= 1.0;
        theta = theta +0.1)  
    {
    Console.WriteLine("Синус угла " + theta +
    " равен " + Math.Sin(theta));
    Console.WriteLine("Косинус угла " + theta +
    " равен " + Math.Cos(theta));
    Console.WriteLine("Тангенс угла " + theta +
    " равен " + Math.Tan(theta));
    Console.WriteLine();
    }
    }
    }

```

## code_13

```cs

    // Использовать тип decimal для расчета скидки.
    using System;

    class UseDecimal 
    {
    static void Main() 
    {
    decimal price;
    decimal discount;
    decimal discounted_price;
    // Рассчитать цену со скидкой.
    price = 19.95m;
    discount = 0.15m; // норма скидки составляет 15%
    discounted_price = price - ( price * discount);
    Console.WriteLine("Цена со скидкой: RUB " + discounted_price);
    }
    }

```

## code_14

```cs
    /**
    * Применить тип decimal для расчета будущей стоимости
    * капиталовложений.
    */
    using System;

    class FutVal 
    {
    static void Main()
    {
    decimal amount;
    decimal rate_of_return;
    int years, i;
        amount = 1000.0M;
        rate_of_return = 0.07M;
        years = 10;
        Console.WriteLine("Первоначальные капиталовложения: RUB " + amount);
        Console.WriteLine("Норма прибыли: " + rate_of_return);
        Console.WriteLine("В течение " + years + " лет");
        for(i = 0; i < years; i++)
        amount = amount + (amount * rate_of_return);
        Console.WriteLine("Будущая стоимость равна RUB " + amount);
    }
    }
```

## code_15

```cs
   // Продемонстрировать применение типа bool.
    using System;

    class BoolDemo 
    {
    static void Main() 
    {
        bool b;
    b = false;
    Console.WriteLine("b равно " + b);
    b = true;
        Console.WriteLine("b равно " + b);
            // Логическое значение может управлять оператором if.
        if(b) Console.WriteLine("Выполняется.");
            b = false;
        if (b) Console.WriteLine("He выполняется.");
        // Результатом выполнения оператора отношения
        // является логическое значение.
        Console.WriteLine("10 > 9 равно " + (10 > 9));
    }

    }
```

## code_16

```cs
       // Применить команды форматирования.
    using System;

    class DisplayOptions 
    {
    static void Main() 
    {
        int i;
        Console.WriteLine("Число\tКвадрат\tКуб");
        for(i = 1; i < 10; i++)

    Console.WriteLine("{0}\t{1}\t{2}", i, i*i, i*i*i);
    }
    
    }

```

## code_17

```cs
    // Использовать спецификатор формата С для вывода
    // результата в местной валюте.
    using System;
    class UseDecimal 
    {
    static void Main() 
    {
        decimal price;
        decimal discount;
        decimal discounted_price;
    // рассчитать цену со скидкой,
    price = 19.95m;
    discount = 0.15m; // норма скидки составляет 15%
    discounted_price = price - ( price * discount);
    Console.WriteLine("Цена со скидкой: {0:C}", discounted_price);
    }
    }

```

## code_18

```cs

    // Продемонстрировать применение управляющих
    // последовательностей символов в строковых литералах.
    using System;
    class StrDemo 
    {
    static void Main() 
    {
    Console.WriteLine("Первая строка\nВторая строка\nТретья строка");
    Console.WriteLine("Один\tДва\tТри");
    Console.WriteLine("Четыре\tПять\tШесть");
    // Вставить кавычки.
    Console.WriteLine("\"3ачем?\", спросил он.");
    }
    }

```

## code_19

```cs
 // Продемонстрировать применение буквальных строковых литералов.
    using System;

    class Verbatim 
    {
    static void Main()
     {
    Console.WriteLine(@"Это буквальный
    строковый литерал,
    занимающий несколько строк.");
    Console.WriteLine(@"А это вывод с табуляцией:
    1 2 3 4
    5 6 7 8 ");
    Console.WriteLine(@"Отзыв программиста: ""Мне нравится С#.""");
    }
    }

```

## code_20

```cs


```
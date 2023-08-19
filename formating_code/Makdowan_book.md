
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
    // Продемонстрировать динамическую инициализацию.
    using System;

    class DynInit 
    {
    static void Main() 
    {
    // Длина сторон прямоугольного треугольника,
    double s1 = 4.0;
    double s2 = 5.0;
    // Инициализировать переменную hypot динамически,
    double hypot = Math.Sqrt( (s1 * s1) + (s2 * s2) );
    Console.Write("Гипотенуза треугольника со сторонами " +
    s1 + " и " + s2 + " равна ");
    Console.WriteLine("{0:#.###}.", hypot);
    }
    }

```

## code_21

```cs
// Продемонстрировать применение неявно типизированных переменных.
    using System;
    class ImplicitlyTypedVar 
    {
    static void Main() 
    {
    // Эти переменные типизированы неявно. Они отнесены
    // к типу double, поскольку инициализирующие их
    // выражения сами относятся к типу double.
    var s1 = 4.0; // <--  Ошибка!
    var s2 = 5.0;
    // Итак, переменная hypot типизирована неявно и
    // относится к типу double, поскольку результат,
    // возвращаемый методом Sqrt(), имеет тип double.
    var hypot = Math.Sqrt((s1 * s1) + (s2 * s2));
    Console.Write("Гипотенуза треугольника со сторонами " +
    s1 + " by " + s2 + " равна ");
    Console.WriteLine("{0:#.###}.", hypot);
    // Следующий оператор не может быть скомпилирован,
    // поскольку переменная s1 имеет тип double и
    // ей нельзя присвоить десятичное значение.
    // s1 = 12.2М; // Ошибка!
    }
    }

```

## code_22

```cs
        // Продемонстрировать область действия кодового блока.
    using System;

    class ScopeDemo
     {
    static void Main()
     {
        int x; // Эта переменная доступна для всего кода внутри метода Main().
        x = 10;
        if(x == 10){   // начать новую область действия
        int у = 20; // Эта переменная доступна только в данном кодовом блоке.
            // Здесь доступны обе переменные, х и у.
        Console.WriteLine("х и у: " + x + " " + у);
        x = у * 2;
        }
        // у = 100; // Ошибка! Переменна у здесь недоступна.
        // А переменная х здесь по-прежнему доступна.
        Console.WriteLine("х равно " + x);
        }
        }
```

## code_23

```cs
    // Продемонстрировать время существования переменной.
    using System;

    class VarInitDemo 
    {
    static void Main() 
    {
    int x;
    for(x = 0; x < 3; x++) 
    {
    int у = -1; // Переменная у инициализируется при каждом входе в блок.
    Console.WriteLine("у равно: " + у); // Здесь всегда выводится -1
    у = 100;
    Console.WriteLine("у теперь равно: " + у);
    }
    }
    }

```

## code_24

```cs
    /*
В этой программе предпринимается попытка объявить во внутренней
области действия переменную с таким же самым именем, как и у
переменной, определенной во внешней области действия.
*** Эта программа не может быть скомпилирована. ***
*/
    using System;

    class NestVar 
    {
    static void Main()
    {
    int count, sum;
   
    for (count = 0; count < 10; /*count --> */ sum = count+1) 
    {
    Console.WriteLine("Это подсчет: " + count);
    //int sum // Недопустимо!!!
    for(count = 0; count < 2; count++)
    // вечный цикол :) не компилить 
    Console.WriteLine("В этой программе есть ошибка!");
    }
    }
    }
```

## code_25

```cs
    // Продемонстрировать неявное преобразование типа long в тип double.
    using System;
    class LtoD 
    {
    static void Main() 
    {
    long L;
    double D;
    L = 100123285L;
    D = L;
    Console.WriteLine("L и D: " + L + " " + D);
    }
    }

```

## code_26

```cs
    // *** Эта программа не может быть скомпилирована. ***
    using System;

    class LtoD 
    {
    static void Main() 
    {
    long L;
    double D;
    D = 100123285.0;
    L = D; // Недопустимо!!!
    Console.WriteLine("L и D: " + L + " " + D);
    }
    }

```

## code_27

```cs

// Продемонстрировать приведение типов.
using System;

class CastDemo
{
    static void Main()
    {
        double x, y;
        byte b;
        int i;
        char ch;
        uint u;
        short s;
        long l;
        x = 10.0;
        y = 3.0;
        // Приведение типа double к типу int, дробная часть числа теряется.
        i = (int)(x / y);
        Console.WriteLine("Целочисленный результат деления х / у: " + i);
        Console.WriteLine();
        // Приведение типа int к типу byte без потери данных,
        i = 255;
        b = (byte)i;
        Console.WriteLine("b после присваивания 255: " + b +
        " -- без потери данных.");
        // Приведение типа int к типу byte с потерей данных,
        i = 257;
        b = (byte)i;
        Console.WriteLine("b после присваивания 257: " + b +
        " -- с потерей данных.");
        Console.WriteLine();
        // Приведение типа uint к типу short без потери данных.
        u = 32000;
        s = (short)u;
        Console.WriteLine("s после присваивания 32000: " +
        s + " -- без потери данных.");
        // Приведение типа uint к типу short с потерей данных,
        u = 64000;
        s = (short)u;
        Console.WriteLine("s после присваивания 64000: " +
        s + " -- с потерей данных.");
        Console.WriteLine();
        // Приведение типа long к типу uint без потери данных.
        l = 64000;
        u = (uint)l;
        Console.WriteLine("u после присваивания 64000: " + u +
        " -- без потери данных.");
        // Приведение типа long к типу uint с потерей данных.
        l = -12;
        u = (uint)l;
        Console.WriteLine("и после присваивания -12: " + u +
        " -- с потерей данных.");
        Console.WriteLine();
        // Приведение типа int к типу char,
        b = 88; // код ASCII символа X
        ch = (char)b;
        Console.WriteLine("ch после присваивания 88: " + ch);
    }
}

```

## code_28

```cs
// Пример неожиданного результата продвижения типов!
using System;

class PromDemo
{
    static void Main()
    {
        byte b;
        b = 10;
        b = (byte)(b * b); // Необходимо приведение типов!!
        Console.WriteLine("b: " + b);
    }
}
```

## code_29

```cs
// Пример приведения типов в выражениях.
using System;

class CastExpr
{
    static void Main()
    {
        double n;
        for (n = 1.0; n <= 10; n++)
        {
            Console.WriteLine("Квадратный корень из {0} равен {1}",
            n, Math.Sqrt(n));
            Console.WriteLine("Целая часть числа: (0)",
            (int)Math.Sqrt(n));
            Console.WriteLine("Дробная часть числа: (0)",
            Math.Sqrt(n) - (int)Math.Sqrt(n));
            Console.WriteLine();
        }
    }
}

```

## code_30

```cs
// Продемонстрировать применение оператора %.
using System;

class ModDemo
{
    static void Main()
    {
        int iresult, irem;
        double dresult, drem;
        iresult = 10 / 3;
        irem = 10 % 3;
        dresult = 10.0 / 3.0;
        drem = 10.0 % 3.0;
        Console.WriteLine("Результат и остаток от деления 10/3: " +
        iresult + " " + irem);
        Console.WriteLine("Результат и остаток от деления 10.0 / 3.0: " +
        dresult + " " + drem);
    }
}

```

## code_31

```cs
// Продемонстрировать отличие между префиксной
// и постфиксной формами оператора инкремента (++).
using System;

class PrePostDemo
{
    static void Main()
    {
        int x, y;
        int i;
        x = 1;
        y = 0;
        Console.WriteLine("Ряд чисел, полученных " +
        "с помощью оператора у = у + х++;");
        for (i = 0; i < 10; i++)
        {
            y = y + x++;  // постфиксная форма оператора ++
            Console.WriteLine(y + " ");
        }
        Console.WriteLine();
        x = 1;
        y = 0;
        Console.WriteLine("Ряд чисел, полученных " +
        "с помощью оператора у = у+  ++х;");
        for (i = 0; i < 10; i++)
        {
            y = y + ++x;  // префиксная форма оператора + +
            Console.WriteLine(y + " ");
        }
        Console.WriteLine();
    }
}

```

## code_32

```cs
    // Продемонстрировать применение операторов
// отношения и логических операторов.
using System;

class RelLogOps
{
    static void Main()
    {
        int i, j;
        bool b1, b2;
        i = 10;
        j = 11;
        if (i < j) Console.WriteLine("i < j");
        if (i <= j) Console.WriteLine("i <= j");
        if (i != j) Console.WriteLine("i != j");
        if (i == j) Console.WriteLine("Нельзя выполнить");
        if (i >= j) Console.WriteLine("Нельзя выполнить");
        if (i > j) Console.WriteLine("Нельзя выполнить");
        b1 = true; 
        b2 = false;
        if (b1 & b2) Console.WriteLine("Нельзя выполнить");
        if (!(b1 & b2)) Console.WriteLine("!(b1 & b2) — true");
        if (b1 | b2) Console.WriteLine("b1 | b2 - true");
        if (b1 ^ b2) Console.WriteLine("bl ^ b2 — true");
    }
}

```

## code_33

```cs
// Построение операции импликации в С#.
using System;

class Implication
{
    static void Main()
    {
        bool p = false, q = false;
        int i, j;
        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 2; j++)
            {
                if (i == 0) p = true;
                if (i == 1) p = false;
                if (j == 0) q = true;
                if (j == 1) q = false;
                Console.WriteLine("p равно " + p + ", q равно " + q);
                if (!p | q)
                    Console.WriteLine("Результат импликации " + p +
                    " и " + q + " равен " + true);
                Console.WriteLine();
            }
        }
    }
}


```

## code_34

```cs
// Продемонстрировать применение укороченных логических операторов.
using System;

class SCops
{
    static void Main()
    {
        int n, d;
        n = 10;
        d = 2;
        if (d != 0 && (n % d) == 0)
            Console.WriteLine(n + " делится нацело на " + d);
        d = 0; // задать нулевое значение переменной d
               // d равно нулю, поэтому второй операнд не вычисляется
        if (d != 0 && (n % d) == 0)
            Console.WriteLine(n + " делится нацело на " + d);
        // Если теперь попытаться сделать то же самое без укороченного
        // логического оператора, то возникнет ошибка из-за деления на нуль.
        if (d != 0 & (n % d) == 0)
            Console.WriteLine(n + " делится нацело на " + d);
    }
}

```

## code_35

```cs
// Продемонстрировать значение побочных эффектов.
using System;

class SideEffects
{
    static void Main()
    {
        int i;
        bool someCondition = false;
        i = 0;
        // Значение переменной i инкрементируется,
        // несмотря на то, что оператор if не выполняется.
        if (someCondition & (++i < 100))
            Console.WriteLine("He выводится");
        Console.WriteLine("Оператор if выполняется: " + i); // выводится 1
                                                            // В данном случае значение переменной i не инкрементируется,
                                                            // поскольку инкремент в укороченном логическом операторе опускается.
        if (someCondition && (++i < 100))
            Console.WriteLine("He выводится");
        Console.WriteLine("Оператор if выполняется: " + i); // по-прежнему 1 !!
    }
}

```

## code_36

```cs

// Применить поразрядный оператор И, чтобы сделать число четным.
using System;

class MakeEven
{
    static void Main()
    {
        ushort num;
        ushort i;
        for (i = 1; i <= 10; i++)
        {
            num = i;
            Console.WriteLine("num: " + num);
            num = (ushort)(num & 0xFFFE);
            Console.WriteLine("num после сброса младшего разряда: "
            + num + "\n");
        }
    }
}

```

## code_37

 ```cs
    // Применить поразрядный оператор И, чтобы определить,
    // является ли число нечетным.
using System;

class IsOdd
{
    static void Main()
    {
        ushort num;
        num = 10;
        if ((num & 1) == 1)
            Console.WriteLine("He выводится.");
        num = 11;
        if ((num & 1) == 1)
            Console.WriteLine(num + " — нечетное число.");
    }
}

 ```

## code_38

```cs
// Показать биты, составляющие байт.
using System;

class ShowBits
{
    static void Main()
    {
        int t;
        byte val;
        val = 123;
        for (t = 128; t > 0; t = t / 2)
        {
            if ((val & t) != 0) Console.Write("1 ");
            if ((val & t) == 0) Console.Write("0 ");
        }
    }
}

```

## code_39

```cs
// Применить поразрядный оператор ИЛИ, чтобы сделать число нечетным.
using System;

class MakeOdd
{
    static void Main()
    {
        ushort num;
        ushort i;
        for (i = 1; i <= 10; i++)
        {
            num = i;
            Console.WriteLine("num: " + num);
            num = (ushort)(num | 1);
            Console.WriteLine("num после установки младшего разряда: " +
            num + "\n");
        }
    }
}

```

## code_40

```cs

// Продемонстрировать применение поразрядного оператора исключающее ИЛИ.
using System;

class Encode
{
    static void Main()
    {
        char ch1 = 'H';
        char ch2 = 'i';
        char ch3 = '!';
        int key = 88;
        Console.WriteLine("Исходное сообщение: " + ch1 + ch2 + ch3);
        // Зашифровать сообщение.
        ch1 = (char)(ch1 ^ key);
        ch2 = (char)(ch2 ^ key);
        ch3 = (char)(ch3 ^ key);
        Console.WriteLine("Зашифрованное сообщение: " + ch1 + ch2 + ch3);
        // Расшифровать сообщение.
        ch1 = (char)(ch1 ^ key);
        ch2 = (char)(ch2 ^ key);
        ch3 = (char)(ch3 ^ key);
        Console.WriteLine("Расшифрованное сообщение: " + ch1 + ch2 + ch3);
    }
}

```

## code_41

```cs
// Продемонстрировать применение поразрядного унарного оператора НЕ.
using System;

class NotDemo
{
    static void Main()
    {
        sbyte b = -34;
        for (int t = 128; t > 0; t = t / 2)
        {
            if ((b & t) != 0) Console.Write("1 ");
            if ((b & t) == 0) Console.Write("0 ");
        }
        Console.WriteLine();
        // обратить все биты
        b = (sbyte)~b;
        for (int t = 128; t > 0; t = t / 2)
        {
            if ((b & t) != 0) Console.Write("1 ");
            if ((b & t) == 0) Console.Write("0 ");
        }
    }
}


```

## code_42

```cs
// Продемонстрировать применение операторов сдвига.
using System;

class ShiftDemo
{
    static void Main()
    {
        int val = 1;
        for (int i = 0; i < 8; i++)
        {
            for (int t = 128; t > 0; t = t / 2)
            {
                if ((val & t) != 0) Console.Write("1 ");
                if ((val & t) == 0) Console.Write("0 ");
            }
            Console.WriteLine();
            val = val << 1; // сдвиг влево
        }
        Console.WriteLine();
        val = 128;
        for (int i = 0; i < 8; i++)
        {
            for (int t = 128; t > 0; t = t / 2)
            {
                if ((val & t) != 0) Console.Write("1 ");
                if ((val & t) == 0) Console.Write("0 ");
            }
            Console.WriteLine();
            val = val >> 1; // сдвиг вправо
        }
    }
}

```

## code_43

```cs
    // Применить операторы сдвига для умножения и деления на 2.
using System;

class MultDiv
{
    static void Main()
    {
        int n;
        n = 10;
        Console.WriteLine("Значение переменной n: " + n);
        // Умножить на 2.
        n = n << 1;
        Console.WriteLine("Значение переменной n после " +
        "операции n = n * 2: " + n);
        // Умножить на 4.
        n = n << 2;
        Console.WriteLine("Значение переменной n после  " +
        "операции n = n * 4: " + n);
        // Разделить на 2.
        n = n >> 1;
        Console.WriteLine("Значение переменной n после " +
        "операции n = n / 2: " + n);
        // Разделить на 4.
        n = n >> 2;
        Console.WriteLine("Значение переменной n после " +
        "операции n = n / 4: " + n);
        Console.WriteLine();
        // Установить переменную n в исходное состояние.
        n = 10;
        Console.WriteLine("Значение переменной n: " + n);
        // Умножить на 2 тридцать раз.
        n = n << 30; // данные теряются
        Console.WriteLine("Значение переменной п после " +
        "сдвига на 30 позиций влево: " + n);
    }
}

```

## code_44

```cs

// Исключить деление на нуль, используя оператор?.
using System;

class NoZeroDiv
{
    static void Main()
    {
        int result;
        for (int i = -5; i < 6; i++)
        {
            result = i != 0 ? 100 / i : 0;
            if (i != 0)
                Console.WriteLine("100 / " + i + " равно " + result);
        }
    }
}

```

## code_45

```cs
    
// Разделить только на четные, ненулевые значения.
using System;
class NoZeroDiv2
{
    static void Main()
    {
        for (int i = -5; i < 6; i++)
            if (i != 0 ? (i % 2 == 0) : false)
                Console.WriteLine("100 / " + i + " равно " + 100 / i);
    }
}

```

## code_46

```cs
    // Определить, является ли числовое значение положительным или отрицательным.
using System;

class PosNeg
{
    static void Main()
    {
        int i;
        for (i = -5; i <= 5; i++)
        {
            Console.Write("Проверка " + i + ": ");
            if (i < 0) Console.WriteLine("отрицательное число");
            else Console.WriteLine("положительное число");
        }
    }
}

```

## code_47

```cs
// Определить, является ли числовое значение
// положительным, отрицательным или нулевым.
using System;

class PosNegZero
{
    static void Main()
    {
        int i;
        for (i = -5; i <= 5; i++)
        {
            Console.Write("Проверка " + i + ": ");
            if (i < 0) Console.WriteLine("отрицательное число");
            else if (i == 0) Console.WriteLine("число без знака");
            else Console.WriteLine("положительное число");
        }
    }
}

```

## code_48

```cs
    // Определить наименьший множитель заданного
    // целого значения, состоящий из одной цифры.
using System;

class Ladder
{
    static void Main()
    {
        int num;
        for (num = 2; num < 12; num++)
        {
            if ((num % 2) == 0)
                Console.WriteLine("Наименьший множитель числа " + num + " равен 2.");
            else if ((num % 3) == 0)
                Console.WriteLine("Наименьший множитель числа " + num + " равен 3.");
            else if ((num % 5) == 0)
                Console.WriteLine("Наименьший множитель числа " + num + " равен 5.");
            else if ((num % 7) == 0)
                Console.WriteLine("Наименьший множитель числа " + num + " равен 7.");
            else
                Console.WriteLine(num + " не делится на 2, 3, 5 или 7.");
        }
    }
}

```

## code_49

```cs
    // Продемонстрировать применение оператора switch.
using System;

class SwitchDemo
{
    static void Main()
    {
        int i;
        for (i = 0; i < 10; i++)
            switch (i)
            {
                case 0:
                    Console.WriteLine("i равно нулю");
                    break;
                case 1:
                    Console.WriteLine("i равно единице");
                    break;
                case 2:
                    Console.WriteLine("i равно двум");
                    break;
                case 3:
                    Console.WriteLine("i равно трем");
                    break;
                case 4:
                    Console.WriteLine("i равно четырем");
                    break;
                default:
                    Console.WriteLine("i равно или больше пяти");
                    break;
            }
    }
}

```

## code_50

```cs
// Использовать элементы типа char для управления оператором switch.
using System;

class SwitchDemo2
{
    static void Main()
    {
        char ch;
        for (ch = 'A'; ch <= 'E'; ch++)
            switch (ch)
            {
                case 'A':
                    Console.WriteLine("ch содержит A");
                    break;
                case 'B':
                    Console.WriteLine("ch содержит B");
                    break;
                case 'C':
                    Console.WriteLine("ch содержит C");
                    break;
                case 'D':
                    Console.WriteLine("ch содержит D");
                    break;
                case 'E':
                    Console.WriteLine("ch содержит E");
                    break;
            }
    }
}

```

## code_51

```cs
    // Пример "проваливания" пустых ветвей case.
using System;

class EmptyCasesCanFall
{
    static void Main()
    {
        int i;
        for (i = 1; i < 5; i++)
            switch (i)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("i равно 1, 2 или 3");
                    break;
                case 4:
                    Console.WriteLine("i равно 4");
                    break;
            }
    }
}

```

## code_52

```cs
// Выполнение цикла for в отрицательном направлении.
using System;

class DecrFor
{
    static void Main()
    {
        int x;
        for (x = 100; x > -100; x -= 5)
            Console.WriteLine(x);
    }
}

```

## code_53

```cs
    // Выяснить, является ли число простым. Если оно
// непростое, вывести наибольший его множитель.
using System;

class FindPrimes
{
    static void Main()
    {
        int num;
        int i;
        int factor;
        bool isprime;
        for (num = 2; num < 20; num++)
        {
            isprime = true;
            factor = 0;
            // Выяснить, делится ли значение переменной num нацело.
            for (i = 2; i <= num / 2; i++)
            {
                if ((num % i) == 0)
                {
                    // Значение переменной num делится нацело.
                    // Следовательно, это непростое число.
                    isprime = false;
                    factor = i;
                }
            }
            if (isprime)
                Console.WriteLine(num + " — простое число.");
            else
                Console.WriteLine("Наибольший множитель числа " + num +
                " равен " + factor);
        }
    }
}
```

## code_54

```cs
    // Использовать запятые в операторе цикла for.
using System;

class Comma
{
    static void Main()
    {
        int i, j;
        for (i = 0, j = 10; i < j; i++, j--)
            Console.WriteLine("i и j: " + i + " " + j);
    }
}

```

## code_55

```cs
    // Использовать запятые в операторе цикла for для
// выявления наименьшего и наибольшего множителя числа.
using System;

class Comma
{
    static void Main()
    {
        int i, j;
        int smallest, largest;
        int num;
        num = 100;
        smallest = largest = 1;
        for (i = 2, j = num / 2; (i <= num / 2) & (j >= 2); i++, j--)
        {
            if ((smallest == 1) & ((num % i) == 0))
                smallest = i;
            if ((largest == 1) & ((num % j) == 0))
                largest = j;
        }
        Console.WriteLine("Наибольший множитель: " + largest);
        Console.WriteLine("Наименьший множитель: " + smallest);
    }
}

```

## code_56

```cs

// Условием выполнения цикла может служить любое выражение типа bool.
using System;

class forDemo
{
    static void Main()
    {
        int i, j;
        bool done = false;
        for (i = 0, j = 100; !done; i++, j--)
        {
            if (i * i >= j) done = true;
            Console.WriteLine("i, j: " + i + " " + j);
        }
    }
}
```

## code_57

```cs
    // Отдельные части цикла for могут оставаться пустыми.
using System;

class Empty
{
    static void Main()
    {
        int i;
        for (i = 0; i < 10;)
        {
            Console.WriteLine("Проход №" + i);
            i++; // инкрементировать переменную управления циклом
        }
    }
}

```

## code_58

```cs
    // Исключить еще одну часть из определения цикла for.
using System;

class Empty2
{
    static void Main()
    {
        int i;
        i = 0; // исключить инициализацию из определения цикла
        for (; i < 10;)
        {
            Console.WriteLine("Проход №" + i);
            i++; // инкрементировать переменную управления циклом
        }
    }
}

```

## code_59

```cs
// Тело цикла может быть пустым.
using System;

class Empty3
{
    static void Main()
    {
        int i;
        int sum = 0;
        // получить сумму чисел от 1 до 5
        for (i = 1; i <= 5; sum += i++) ;
        Console.WriteLine("Сумма равна " + sum);
    }
}

```

## code_60

```cs
// Объявить переменную управления циклом в самом цикле for.
using System;

class ForVar
{
    static void Main()
    {
        int sum = 0;
        int fact = 1;
        // вычислить факториал чисел от 1 до 5
        for (int i = 1; i <= 5; i++)
        {
            sum += i; // Переменная i действует в цикле.
            fact *= i;
        }
        // А здесь переменная i недоступна.
        Console.WriteLine("Сумма равна " + sum);
        Console.WriteLine("Факториал равен " + fact);
    }
}

```

## code_61

```cs
// Вычислить порядок величины целого числа.
using System;

class WhileDemo
{
    static void Main()
    {
        int num;
        int mag;
        num = 435679;
        mag = 0;
        Console.WriteLine("Число: " + num);
        while (num > 0)
        {
            mag++;
            num = num / 10;
        };
        Console.WriteLine("Порядок величины: " + mag);
    }
}


```

## code_62

```cs
// Вычислить целые степени числа 2.
using System;

class Power
{
    static void Main()
    {
        int e;
        int result;
        for (int i = 0; i < 10; i++)
        {
            result = 1;
            e = i;
            while (e > 0)
            {
                result *= 2;
                e--;
            }
            Console.WriteLine("2 в степени " + i + " равно " + result);
        }
    }
}
```

## code_63

```cs
// Отобразить цифры целого числа в обратном порядке.
using System;

class DoWhileDemo
{
    static void Main()
    {
        int num;
        int nextdigit;
        num = 198;
        Console.WriteLine("Число: " + num);
        Console.Write("Число в обратном порядке: ");
        do
        {
            nextdigit = num % 10;
            Console.Write(nextdigit);
            num = num / 10;
        } while (num > 0);
        Console.WriteLine();
    }
}

```

## code_64

```cs
// Применить оператор break для выхода из цикла.
using System;

class BreakDemo
{
    static void Main()
    {
        // Использовать оператор break для выхода из этого цикла.
        for (int i = -10; i <= 10; i++)
        {
            if (i > 0) break; // завершить цикл, как только значение
                              // переменной i станет положительным
            Console.Write(i + " ");
        }
        Console.WriteLine("Готово!");
    }
}

```

## code_65

```cs
// Применить оператор break для выхода из цикла do-while.
using System;

class BreakDemo2
{
    static void Main()
    {
        int i;
        i = -10;
        do
        {
            if (i > 0) break;
            Console.Write(i + " ");
            i++;
        } while (i <= 10);
        Console.WriteLine("Готово!");
    }
}

```

## code_66

```cs
// Выявить наименьший множитель числа.
using System;

class FindSmallestFactor
{
    static void Main()
    {
        int factor = 1;
        int num = -1000;
        for (int i = 2; i <= num / i;  i++) {
        if ((num % i) == 0)
            {
                factor = i;
                break; // прервать цикл, как только будет
                       // выявлен наименьший множитель числа
            }
    }
    Console.WriteLine("Наименьший множитель равен " + factor);
}
}

```

## code_67

```cs
// Применить оператор break во вложенных циклах.
using System;

class BreakNested
{
    static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Подсчет во внешнем цикле: " + i);
            Console.Write(" Подсчет во внутреннем цикле: ");
            int t = 0;
            while (t < 100)
            {
                if (t == 10) break; // прервать цикл, если t равно 10
                Console.Write(t + " ");
                t++;
            }
            Console.WriteLine();
        }
        Console.WriteLine("Циклы завершены.");
    }
}

```

## code_68

```cs
// Применить оператор continue.
using System;

class ContDemo
{
    static void Main()
    {
        // вывести четные числа от 0 до 100.
        for (int i = 0; i <= 100; i++)
        {
            if ((i % 2) != 0) continue; // перейти к следующему шагу итерации
            Console.WriteLine(i);
        }
    }
}

```

## code_69

```cs
// Применить оператор goto в операторе switch.
using System;

class SwitchGoto
{
    static void Main()
    {
        for (int i = 1; i < 5; i++)
        {
            switch (i)
            {
                case 1:

                    Console.WriteLine("В ветви case 1");
                    goto case 3;
                case 2:
                    Console.WriteLine("В ветви case 2");
                    goto case 1;
                case 3:
                    Console.WriteLine("В ветви case 3");
                    goto default;
                default:
                    Console.WriteLine("В ветви default");
                    break;
            }
            Console.WriteLine();
        }
        // goto case 1; // Ошибка! Безусловный переход к оператору switch недопустим.
    }
}

```

## code_70

```cs
// Продемонстрировать практическое применение оператора goto.
using System;

class Use_goto
{
    static void Main()
    {
        int i = 0, j = 0, k = 0;
        for (i = 0; i < 10; i++)
        {
            for (j = 0; j < 10; j++)
            {
                for (k = 0; k < 10; k++)
                {
                    Console.WriteLine("i, j, k: " + i + " " + j +
                    " " + k);
                    if (k == 3) goto stop;
                }
            }
        }
    stop:
        Console.WriteLine("Остановлено! i, j, k: " + i +
        ", " + j + " " + k);
    }
}

```

## code_71

```cs
    // Программа, в которой используется класс Building.
using System;

class Building
{
    public int Floors; // количество этажей
    public int Area; // общая площадь здания
    public int Occupants; // количество жильцов
}
// В этом классе объявляется объект типа Building.
class BuildingDemo
{
    static void Main()
    {
        Building house = new Building(); // создать объект типа Building
        int areaPP; // площадь на одного человека
                    // Присвоить значения полям в объекте house.
        house.Occupants = 4;
        house.Area = 2500;
        house.Floors = 2;
        // Вычислить площадь на одного человека.
        areaPP = house.Area / house.Occupants;
        Console.WriteLine("Дом имеет:\n " +
        house.Floors + " этажа\n " +
        house.Occupants + " жильца\n " +
        house.Area +
        " кв. метров общей площади, из них\n " +
        areaPP + " приходится на одного человека");
    }
}

```

## code_72

```cs
// В этой программе создаются два объекта типа Building.
using System;

class Building
{
    public int Floors; // количество этажей
    public int Area; // общая площадь здания
    public int Occupants; // количество жильцов
}
// В этом классе объявляются два объекта типа Building.
class BuildingDemo
{
    static void Main()
    {
        Building house = new Building();
        Building office = new Building();
        int areaPP; // площадь на одного человека
                    // Присвоить значения полям в объекте house.
        house.Occupants = 4;
        house.Area = 2500;
        house.Floors = 2;
        // Присвоить значения полям в объекте office.
        office.Occupants = 25;
        office.Area = 4200;
        office.Floors = 3;
        // Вычислить площадь на одного человека в жилом доме.
        areaPP = house.Area / house.Occupants;
        Console.WriteLine("Дом имеет\n " +
        house.Floors + " этажа\n " +
        house.Occupants + " жильца\n " +
        house.Area +
        " кв. метров общей площади, из них\n " +
        areaPP + " приходится на одного человека");
        // Вычислить площадь на одного человека в учреждении.
        areaPP = office.Area / office.Occupants;
        Console.WriteLine("Учреждение имеет:\n  " +
        office.Floors + " этажа\n " +
        office.Occupants + " работников\n " +
        office.Area +
        " кв. метров общей площади, из них\n " +
        areaPP + " приходится на одного человека");
    }
}

```

## code_73

```cs
// Добавить метод в класс Building.
using System;

class Building
{
    public int Floors;    //  количество этажей
    public int Area; //  общая площадь здания
    public int Occupants; // к оличество жильцов
                          // Вывести площадьн а одного человека,
    public void AreaPerPerson()
    {
        Console.WriteLine(" " + Area / Occupants +
        " приходится на одного человека");
    }
}
// Использовать метод AreaPerPerson().
class BuildingDemo
{
    static void Main()
    {
        Building house = new Building();
        Building office = new Building();
        // Присвоить значения полям в объекте house.
        house.Occupants = 4;
        house.Area = 2500;
        house.Floors = 2;
        // Присвоить значения полям в объекте office.
        office.Occupants = 25;
        office.Area = 4200;
        office.Floors = 3;
        Console.WriteLine("Дом имеет:\n" +
        house.Floors + " этажа\n " +
        house.Occupants + " жильца\n " +
        house.Area +
        "кв. метров общей площади, из них");
        house.AreaPerPerson();
        Console.WriteLine();
        Console.WriteLine("Учреждение имеет:\n " +
        office.Floors + " этажа\n " +
        office.Occupants + " работников\n " +
        office.Area +
        " кв. метров общей площади, из них");
        office.AreaPerPerson();
    }
}

```

## code_74

```cs
// Возвратить значение из метода AreaPerPerson().
using System;

class Building
{
    public int Floors;    // количество этажей
    public int Area; // общая площадь здания
    public int Occupants; // количество жильцов
                          // Возвратить величину площади на одного человека,
    public int AreaPerPerson()
    {
        return Area / Occupants;
    }
}
// Использовать значение, возвращаемое методом AreaPerPerson!).
class BuildingDemo
{
    static void Main()
    {
        Building house = new Building();
        Building office = new Building();
        int areaPP; // площадь на одного человека
                    // Присвоить значения полям в объекте house.
        house.Occupants = 4;
        house.Area = 2500;
        house.Floors = 2;
        // Присвоить значения полям в объекте office.
        office.Occupants = 25;
        office.Area = 4200;
        office.Floors = 3;
        // Получить площадь на одного человека в жилом доме.
        areaPP = house.AreaPerPerson();
        Console.WriteLine("Дом имеет:\n " +
        house.Floors + " этажа\n " +
        house.Occupants + " жильца\n " +
        house.Area +
        " кв. метров общей площади, из них\n " +
        areaPP + " приходится на одного человека");
        Console.WriteLine();
        // Получить площадь на одного человека в учреждении.
        areaPP = office.AreaPerPerson();
        Console.WriteLine("Учреждение имеет:\n " +
        office.Floors + " этажа\n " +
        office.Occupants + " работников\n " +
        office.Area +
        " кв. метров общей площади, из них\n " +
        areaPP + " приходится на одного человека");
    }
}

```

## code_75

```cs
// Простой пример применения параметра.
using System;

class ChkNum
{
    // Возвратить значение true, если значение
    // параметра х окажется простым числом.
    public bool IsPrime(int x)
    {
        if (x <= 1) return false;
    for (int i = 2; i <= x / i; i++)
            if ((x % i) == 0) return false;
        return true;
    }
}
class ParmDemo
{
    static void Main()
    {
        ChkNum ob = new ChkNum();
        for (int i = 2; i < 10; i++)
            if (ob.IsPrime(i)) Console.WriteLine(i + " простое число.");
            else Console.WriteLine(i + " непростое число.");
    }
}

```

## code_76

```cs

// Добавить метод, принимающий два аргумента.
using System;

class ChkNum
{
    // Возвратить значение true, если значение
    // параметра х окажется простым числом.
    public bool IsPrime(int x)
    {
        if (x <= 1) return false;
        for (int i = 2; i <= x / i; i++)
            if ((x % i) == 0) return false;
        return true;
    }
    // Возвратить наименьший общий множитель.
    public int LeastComFactor(int a, int b)
    {
        int max;
        if (IsPrime(a) || IsPrime(b)) return 1;
        max = a < b ? a : b;
        for (int i = 2; i <= max / 2; i++)
            if (((a % i) == 0) && ((b % i) == 0)) return i;
        return 1;
    }
}
class ParmDemo
{
    static void Main()
    {
        ChkNum ob = new ChkNum();
        int a, b;
        for (int i = 2; i < 10; i++)
            if (ob.IsPrime(i)) Console.WriteLine(i + " простое число.");
            else Console.WriteLine(i + " непростое число.");
        a = 7;
        b = 8;
        Console.WriteLine("Наименьший общий множитель чисел " +
        a + " и " + b + " равен " +
        ob.LeastComFactor(a, b));
        a = 100;
        b = 8;
        Console.WriteLine("Наименьший общий множитель чисел " +
        a + " и " + b + " равен " +
        ob.LeastComFactor(a, b));
        a = 100;
        b = 75;
        Console.WriteLine("Наименьший общий множитель чисел " +
        a + " и " + b + " равен " +
        ob.LeastComFactor(a, b));
    }
}

```

## code_77

```cs
/*
Добавить параметризированный метод, вычисляющий
максимальное количество человек, которые могут
занимать здание, исходя из заданной минимальной
площади на одного человека.
*/
using System;

class Building
{
    public int Floors;    // количество этажей
    public int Area; // общая площадь здания
    public int Occupants;  // количество жильцов
                           // Возвратить площадьн а одного человека.
    public int AreaPerPerson()
    {
        return Area / Occupants;
    }
    // Возвратить максимальное количество человек, занимающих здание,
    // исходя из заданной минимальной площади на одного человека.
    public int MaxOccupant(int minArea)
    {
        return Area / minArea;
    }
}
// Использовать метод MaxOccupant().
class BuildingDemo
{
    static void Main()
    {
        Building house = new Building();
        Building office = new Building();
        // Присвоить значения полям в объекте house.
        house.Occupants = 4;
        house.Area = 2500;
        house.Floors = 2;
        // Присвоить значения полям в объекте office.
        office.Occupants = 25;
        office.Area = 4200;
        office.Floors = 3;
        Console.WriteLine("Максимальное количество человек в доме, \n" +
        "если на каждого должно приходиться " +
        300 + " кв. метров: " +
        house.MaxOccupant(300));
        Console.WriteLine("Максимальное количество человек " +
        "в учреждении, \n" +
        "если на каждого должно приходиться " +
        300 + " кв. метров: " +
        office.MaxOccupant(300));
    }
}
```

## code_78

```cs
    // Простой конструктор.
using System;

class MyClass
{
    public int x;
    public MyClass()
    {
        x = 10;
    }
}
class ConsDemo
{
    static void Main()
    {
        MyClass t1 = new MyClass();
        MyClass t2 = new MyClass();
        Console.WriteLine(t1.x + " " + t2.x);
    }
}

```

## code_79

```cs
// Параметризированный конструктор.
using System;

class MyClass
{
    public int x;
    public MyClass(int i)
    {
        x = i;
    }
}
class ParmConsDemo
{
    static void Main()
    {
        MyClass t1 = new MyClass(10);
        MyClass t2 = new MyClass(88);
        Console.WriteLine(t1.x + " " + t2.x);
    }
}
```

## code_80

```cs
// Добавить конструктор в класс Building.
using System;

class Building
{
    public int Floors; // количество этажей
    public int Area; // общая площадь здания
    public int Occupants; // количество жильцов
                          // Параметризированный конструктор для класса Building.
    public Building(int f, int a, int o)
    {
        Floors = f;
        Area = a;
        Occupants = o;
    }
    // Возвратить площадь на одного человека.
    public int AreaPerPerson()
    {
        return Area / Occupants;
    }
    // Возвратить максимальное количество человек, занимающих здание,
    // исходя из заданной минимальной площади на одного человека.
    public int MaxOccupant(int minArea)
    {
        return Area / minArea;
    }
}
// Использовать параметризированный конструктор класса Building.
class BuildingDemo
{
    static void Main()
    {
        Building house = new Building(2, 2500, 4);
        Building office = new Building(3, 4200, 25);
        Console.WriteLine("Максимальное количество человек в доме, \n" +
        "если на каждого должно приходиться " +
        300 +" кв. метров: " +
        house.MaxOccupant(300));
        Console.WriteLine("Максимальное количество человек " +
        "в учреждении, \n" +
        "если на каждого должно приходиться " +
        300 + " кв. метров: " +
        office.MaxOccupant(300));
    }
}

```

## code_81

```cs
// Использовать оператор new вместе с типом значения.
using System;

class newValue
{
    static void Main()
    {
        int i = new int(); // инициализировать переменную i нулевым значением
        Console.WriteLine("Значение переменной i равно: " + i);
    }
}

```

## code_82

```cs
// Продемонстрировать применение деструктора.
using System;

class Destruct
{
    public int x;
    public Destruct(int i)
    {
        x = i;
    }
    // Вызывается при утилизации объекта.
    ~Destruct()
    {
        Console.WriteLine("Уничтожить " + x);
    }
    // Создает объект и тут же уничтожает его.
    public void Generator(int i)
    {
        Destruct о = new Destruct(i);
    }
}
class DestructDemo
{
    static void Main()
    {
        int count;
        Destruct ob = new Destruct(0);
        /* А теперь создать большое число объектов.
        В какой-то момент произойдет "сборка мусора".
        Примечание: для того чтобы активизировать
        "сборку мусора", возможно, придется увеличить
        число создаваемых объектов. */
        for (count = 1; count < 100000; count++)
            ob.Generator(count);
        Console.WriteLine("Готово!");
    }
}

```

## code_83

```cs
using System;

class Rect
{
    public int Width;
    public int Height;
    public Rect(int w, int h)
    {
        Width = w;
        Height = h;
    }
    public int Area()
    {
        return Width * Height;
    }
}
class UseRect
{
    static void Main()
    {
        Rect r1 = new Rect(4, 5);
        Rect r2 = new Rect(7, 9);
        Console.WriteLine("Площадь прямоугольника r1: " + r1.Area());
        Console.WriteLine("Площадь прямоугольника r2: " + r2.Area());
    }
}

```

## code_84

```cs
using System;

class Rect
{
    public int Width;
    public int Height;
    public Rect(int w, int h)
    {
        this.Width = w;
        this.Height = h;
    }
    public int Area()
    {
        return this.Width * this.Height;
    }
}
class UseRect
{
    static void Main()
    {
        Rect r1 = new Rect(4, 5);
        Rect r2 = new Rect(7, 9);
        Console.WriteLine("Площадь прямоугольника r1: " + r1.Area());
        Console.WriteLine("Площадь прямоугольника r2: " + r2.Area());
    }
}

```

## code_85

```cs
    
// Продемонстрировать одномерный массив.
using System;

class ArrayDemo
{
    static void Main()
    {
        int[] sample = new int[10];
        int i;
        for (i = 0; i < 10; i = i + 1)
            sample[i] = i;
        for (i = 0; i < 10; i = i + 1)
            Console.WriteLine("sample[" + i + "]: " + sample[i]);
    }
}

```

## code_86

```cs
// Вычислить среднее арифметическое ряда значений.
using System;

class Average
{
    static void Main()
    {
        int[] nums = new int[10];
        int avg = 0;
        nums[0] = 99;
        nums[1] = 10;
        nums[2] = 100;
        nums[3] = 18;
        nums[4] = 78;
        nums[5] = 23;
        nums[6] = 63;
        nums[7] = 9;
        nums[8] = 87;
        nums[9] = 49;
        for (int i = 0; i < 10; i++)
            avg = avg + nums[i];
        avg = avg / 10;
        Console.WriteLine("Среднее: " + avg);
    }
}

```

## code_87

```cs
// Вычислить среднее арифметическое ряда значений.
using System;

class Average
{
    static void Main()
    {
        int[] nums = { 99, 10, 100, 18, 78, 23,
63, 9, 87, 49 };
        int avg = 0;
        for (int i = 0; i < 10; i++)
            avg = avg + nums[i];
        avg = avg / 10;
        Console.WriteLine("Среднее: " + avg);
    }
}

```

## code_88

```cs
// Продемонстрировать двумерный массив.
using System;

class TwoD
{
    static void Main()
    {
        int t, i;
        int[,] table = new int[3, 4];
        for (t = 0; t < 3; ++t)
        {
            for (i = 0; i < 4; ++i)
            {
                table[t, i] = (t * 4) + i + 1;
                Console.Write(table[t, i] + " ");
            }
            Console.WriteLine();
        }
    }
}

```

## code_89

```cs
// Суммировать значения по одной из диагоналей матрицы 3Ч3Ч3.
using System;

class ThreeDMatrix
{
    static void Main()
    {
        int[,,] m = new int[3, 3, 3];
        int sum = 0;
        int n = 1;
        for (int x = 0; x < 3; x++)
            for (int y = 0; y < 3; y++)
                for (int z = 0; z < 3; z++)
                    m[x, y, z] = n++;
        sum = m[0, 0, 0] + m[1, 1, 1] + m[2, 2, 2];
        Console.WriteLine("Сумма значений по первой диагонали: " + sum);
    }
}

```

## code_90

```cs
// Инициализировать двумерный массив.
using System;

class Squares
{
    static void Main()
    {
        int[,] sqrs = {
            { 1, 1 },
            { 2, 4 },
            { 3, 9 },
            { 4, 16 },
            { 5, 25 },
            { 6, 36 },
            { 7, 49 },
            { 8, 64 },
            { 9, 81 },
            { 10, 100 }};
        int i, j;
        for (i = 0; i < 10; i++)
        {
            for (j = 0; j < 2; j++)
                Console.Write(sqrs[i, j] + " ");
            Console.WriteLine();
        }
    }
}

```

## code_91

```cs
// Продемонстрировать применение ступенчатых массивов.
using System;

class Jagged
{
    static void Main()
    {
        int[][] jagged = new int[3][];
        jagged[0] = new int[4];
        jagged[1] = new int[3];
        jagged[2] = new int[5];
        int i;
        // Сохранить значения в первом массиве.
        for (i = 0; i < 4; i++)
            jagged[0][i] = i;
        // Сохранить значения во втором массиве.
        for (i = 0; i < 3; i++)
            jagged[1][i] = i;
        // Сохранить значения в третьем массиве.
        for (i = 0; i < 5; i++)
            jagged[2][i] = i;
        // Вывести значения из первого массива.
        for (i = 0; i < 4; i++)
            Console.Write(jagged[0][i] + " ");
        Console.WriteLine();
        // Вывести значения из второго массива.
        for (i = 0; i < 3; i++)
            Console.Write(jagged[1][i] + " ");
        Console.WriteLine();
        // Вывести значения из третьего массива.
        for (i = 0; i < 5; i++)
            Console.Write(jagged[2][i] + " ");
        Console.WriteLine();
    }
}

```

## code_92

```cs
// Присваивание ссылок на массивы.
using System;

class AssignARef
{
    static void Main()
    {
        int i;
        int[] nums1 = new int[10];
        int[] nums2 = new int[10];
        for (i = 0; i < 10; i++) nums1[i] = i;
        for (i = 0; i < 10; i++) nums2[i] = -i;
        Console.Write("Содержимое массива nums1: ");
        for (i = 0; i < 10; i++)
            Console.Write(nums1[i] + " ");
        Console.WriteLine();
        Console.Write("Содержимое массива nums2: ");
        for (i = 0; i < 10; i++)
            Console.Write(nums2[i] + " ");
        Console.WriteLine();
        nums2 = nums1; // теперь nums2 ссылается на nums1
        Console.Write("Содержимое массива nums2\n" + "после присваивания: ");
        for (i = 0; i < 10; i++)
            Console.Write(nums2[i] + " ");
        Console.WriteLine();
        // Далее оперировать массивом nums1 посредством
        // переменной ссылки на массив nums2.
        nums2[3] = 99;
        Console.Write("Содержимое массива nums1 после изменения\n" +
        "посредством переменной nums2: ");
        for (i = 0; i < 10; i++)
            Console.Write(nums1[i] + " ");
        Console.WriteLine();
    }
}
```

## code_93

```cs
// Использовать свойство Length массива.
using System;

class LengthDemo
{
    static void Main()
    {
        int[] nums = new int[10];
        Console.WriteLine("Длина массива nums равна " + nums.Length);
        // Использовать свойство Length для инициализации массива nums.
        for (int i = 0; i < nums.Length; i++)
            nums[i] = i * i;
        // А теперь воспользоваться свойством Length
        // для вывода содержимого массива nums.
        Console.Write("Содержимое массива nums: ");
        for (int i = 0; i < nums.Length; i++)
            Console.Write(nums[i] + " ");
        Console.WriteLine();
    }
}

```

## code_94

```cs
// Использовать свойство Length трехмерного массива.
using System;

class LengthDemo3D
{
    static void Main()
    {
        int[,,] nums = new int[10, 5, 6];
        Console.WriteLine("Длина массива nums равна " + nums.Length);
    }
}

```

## code_95

```cs
// Поменять местами содержимое элементов массива.
using System;

class RevCopy
{
    static void Main()
    {
        int i, j;
        int[] nums1 = new int[10];
        int[] nums2 = new int[10];
        for (i = 0; i < nums1.Length; i++) nums1[i] = i;
        Console.Write("Исходное содержимое массива: ");
        for (i = 0; i < nums2.Length; i++)
            Console.Write(nums1[i] + " ");
        Console.WriteLine();
        // Скопировать элементы массива nums1 в массив nums2 в обратном порядке.
        if (nums2.Length >= nums1.Length) // проверить, достаточно ли
                                          // длины массива nums2
            for (i = 0, j = nums1.Length - 1; i < nums1.Length; i++, j--)
                nums2[j] = nums1[i];
        Console.Write("Содержимое массива в обратном порядке: ");
        for (i = 0; i < nums2.Length; i++)
            Console.Write(nums2[i] + " ");
        Console.WriteLine();
    }
}

```

## code_96

```cs
// Продемонстрировать применение свойства Length
// при обращении со ступенчатыми массивами.
using System;

class Jagged
{
    static void Main()
    {
        int[][] network_nodes = new int[4][];
        network_nodes[0] = new int[3];
        network_nodes[1] = new int[7];
        network_nodes[2] = new int[2];
        network_nodes[3] = new int[5];
        int i, j;
        // Сфабриковать данные об использовании ЦП.
        for (i = 0; i < network_nodes.Length; i++)
            for (j = 0; j < network_nodes[i].Length; j++)
                network_nodes[i][j] = i * j + 70;
        Console.WriteLine("Общее количество узлов сети: " +
        network_nodes.Length + "\n");
        for (i = 0; i < network_nodes.Length; i++)
        {
            for (j = 0; j < network_nodes[i].Length; j++)
            {
                Console.Write("Использование в узле сети " + i +
                " ЦП " + j + ": ");
                Console.Write(network_nodes[i][j] + "% ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}


```

## code_97

```cs
    // Продемонстрировать неявно типизированный ступенчатый массив.
using System;

class Jagged
{
    static void Main()
    {
        var jagged = new[] {
        new[] { 1, 2, 3, 4 },
        new[] { 9, 8, 7 },
        new[] { 11, 12, 13, 14, 15 }
    };
        for (int j = 0; j < jagged.Length; j++)
        {
            for (int i = 0; i < jagged[j].Length; i++)
                Console.Write(jagged[j][i] + " ");
            Console.WriteLine();
        }
    }
}

```

## code_98

```cs
    // Использовать оператор цикла foreach.
using System;

class ForeachDemo
{
    static void Main()
    {
        int sum = 0;
        int[] nums = new int[10];
        // Задать первоначальные значения элементов массива nums.
        for (int i = 0; i < 10; i++)
            nums[i] = i;
        // Использовать цикл foreach для вывода значений
        // элементов массива и подсчета их суммы.
        foreach (int х in nums)
        {
            Console.WriteLine("Значение элемента равно: " + х);
            sum += х;
        }
        Console.WriteLine("Сумма равна: " + sum);
    }
}

```

## code_99

```cs
// Использовать оператор break для преждевременного завершения цикла foreach.
using System;

class ForeachDemo
{
    static void Main()
    {
        int sum = 0;
        int[] nums = new int[10];
        // Задать первоначальные значения элементов массива nums.
        for (int i = 0; i < 10; i++)
            nums[i] = i;
        // Использовать цикл foreach для вывода значений
        // элементов массива и подсчета их суммы.
        foreach (int x in nums)
        {
            Console.WriteLine("Значение элемента равно: " + x);
            sum += x;
            if (x == 4) break; // прервать цикл, как только индекс массива достигнет 4
        }
        Console.WriteLine("Сумма первых 5 элементов: " + sum);
    }
}

```

## code_100

```cs
    // Использовать оператор цикла foreach для обращения к двумерному массиву.
using System;

class ForeachDemo2
{
    static void Main()
    {
        int sum = 0;
        int[,] nums = new int[3, 5];
        // Задать первоначальные значения элементов массива nums.
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 5; j++)
                nums[i, j] = (i + 1) * (j + 1);
        // Использовать цикл foreach для вывода значений
        // элементов массива и подсчета их суммы.
        foreach (int х in nums)
        {
            Console.WriteLine("Значение элемента равно: " + х);
            sum += х;
        }
        Console.WriteLine("Сумма равна: " + sum);
    }
}

```

## code_101

```cs
// Поиск в массиве с помощью оператора цикла foreach.
using System;

class Search
{
    static void Main()
    {
        int[] nums = new int[10];
        int val;
        bool found = false;
        // Задать первоначальные значения элементов массива nums.
        for (int i = 0; i < 10; i++)
            nums[i] = i;
        val = 5;
        // Использовать цикл foreach для поиска заданного
        // значения в массиве nums.
        foreach (int x in nums)
        {
            if (x == val)
            {
                found = true;
                break;
            }
        }
        if (found)
            Console.WriteLine("Значение найдено!");
    }
}

```

## code_102

```cs
// Создать и вывести символьную строку.
using System;

class StringDemo
{
    static void Main()
    {
        char[] charray = { 'Э', 'т', 'о', ' ', 'с', 'т', 'р', 'о', 'к', 'а'};
        string str1 = new string(charray);
        string str2 = "Еще одна строка.";
        Console.WriteLine(str1);
        Console.WriteLine(str2);
    }
}
```

## code_103

```cs
// Некоторые операции со строками.
using System;
using System.Globalization;
class StrOps
{
    static void Main()
    {
        string str1 = "Программировать в .NET лучше всего на С#.";
        string str2 = "Программировать в .NET лучше всего на С#.";
        string str3 = "Строки в C# весьма эффективны.";
        string strUp, strLow;
        int result, idx;
        Console.WriteLine("str1: " + str1);
        Console.WriteLine("Длина строки str1: " + str1.Length);
        // Создать варианты строки str1, набранные
        // прописными и строчными буквами.
        strLow = str1.ToLower(CultureInfo.CurrentCulture);
        strUp = str1.ToUpper(CultureInfo.CurrentCulture);
        Console.WriteLine("Вариант строки str1, " +
        "набранный строчными буквами:\n " + strLow);
        Console.WriteLine("Вариант строки str1, " +
        "набранный прописными буквами:\n " + strUp);
        Console.WriteLine();
        // Вывести строку str1 посимвольно.
        Console.WriteLine("Вывод строки str1 посимвольно.");
        for (int i = 0; i < str1.Length; i++)
            Console.Write(str1[i]);
        Console.WriteLine("\n");
        // Сравнить строки способом порядкового сравнения.
        if (str1 == str2)
            Console.WriteLine("str1 == str2");
        else
            Console.WriteLine("str1 != str2");
        if (str1 == str3)
            Console.WriteLine("str1 == str3");
        else
            Console.WriteLine("str1 != str3");
        // Сравнить строки с учетом культурной среды.
        result = string.Compare(str3, str1, StringComparison.CurrentCulture);
        if (result == 0)
            Console.WriteLine("Строки str1 и str3 равны");
        else if (result < 0)
            Console.WriteLine("Строка str1 меньше строки str3");
        else
            Console.WriteLine("Строка str1 больше строки str3");
        Console.WriteLine();
        // Присвоить новую строку переменной str2.
        str2 = "Один Два Три Один";
        // Поиск подстроки.
        idx = str2.IndexOf("Один", StringComparison.Ordinal);
        Console.WriteLine("Индекс первого вхождения подстроки <Один>: " + idx);
        idx = str2.LastIndexOf("Один", StringComparison.Ordinal);
        Console.WriteLine("Индекс последнего вхождения подстроки <Один>: " +
        idx);
    }
}
```

## code_104

```cs
// Продемонстрировать массивы строк.
using System;

class StringArrays
{
    static void Main()
    {
        string[] str = { "Это", "очень", "простой", "тест." };
        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < str.Length; i++)
            Console.Write(str[i] + " ");
        Console.WriteLine("\n");
        // Изменить строку.
        str[1] = "тоже";
        str[3] = "до предела тест!";
        Console.WriteLine("Видоизмененный массив: ");
        for (int i = 0; i < str.Length; i++)
            Console.Write(str[i] + " ");
    }
}
```

## code_105

```cs
// Вывести отдельные цифры целого числа словами.
using System;

class ConvertDigitsToWords
{
    static void Main()
    {
        int num;
        int nextdigit;
        int numdigits;
        int[] n = new int[20];
        string[] digits = { "нуль", "один", "два",
"три", "четыре", "пять",
"шесть", "семь", "восемь",
"девять" };
        num = 1908;
        Console.WriteLine("Число: " + num);
        Console.Write("Число словами: ");
        nextdigit = 0;
        numdigits = 0;
        // Получить отдельные цифры и сохранить их в массиве n.
        // Эти цифры сохраняются в обратном порядке.
        do
        {
            nextdigit = num % 10;
            n[numdigits] = nextdigit;
            numdigits++;
            num = num / 10;
        } while (num > 0);
        numdigits--;
        // Вывести полученные слова.
        for (; numdigits >= 0; numdigits--)
            Console.Write(digits[n[numdigits]] + " ");
        Console.WriteLine();
    }
}
```

## code_106

```cs

// Применить метод Substring().
using System;

class SubStr
{
    static void Main()
    {
        string orgstr = "В C# упрощается обращение со строками.";
        // сформировать подстроку
        string substr = orgstr.Substring(5, 20);
        Console.WriteLine("orgstr: " + orgstr);
        Console.WriteLine("substr: " + substr);
    }
}

```

## code_107

```cs
// Продемонстрировать управление оператором switch посредством строк.
using System;

class StringSwitch
{
    static void Main()
    {
        string[] strs = { "один", "два", "три", "два", "один" };
        foreach (string s in strs)
        {
            switch (s)
            {
                case "один":
                    Console.Write(1);
                    break;
                case "два":
                    Console.Write(2);
                    break;
                case "три":
                    Console.Write(3);
                    break;
            }
        }
        Console.WriteLine();
    }
}
```

## code_108

```cs
// Отличия между видами доступа public и private к членам класса.
using System;

class MyClass
{
    private int alpha;  // закрытый доступ, указываемый я вно
    int beta;     // закрытый доступ по умолчанию
    public int gamma;   // открытый доступ
                        // Методы, которым  доступны члены alpha и beta данногок ласса.
                        // Член класса может иметь доступ к закрытому члену этого же класса.
    public void SetAlpha(int а)
    {
        alpha = а;
    }
    public int GetAlpha()
    {
        return alpha;
    }
    public void SetBeta(int a)
    {
        beta = a;
    }
    public int GetBeta()
    {
        return beta;
    }
}
class AccessDemo
{
    static void Main()
    {
        MyClass ob = new MyClass();
        // Доступ к членам alpha и beta данного класса
        // разрешен только посредством его методов.
        ob.SetAlpha(-99);
        ob.SetBeta(19);
        Console.WriteLine("ob.alpha равно " + ob.GetAlpha());
        Console.WriteLine("ob.beta равно " + ob.GetBeta());
        // Следующие виды доступа к членам alpha и beta
        // данного класса не разрешаются.
        // ob.alpha = 10; // Ошибка! alpha - закрытый член!
        // ob.beta =9;  // Ошибка! beta - закрытый член!
        // Член gamma данного класса доступен непосредственно,
        // поскольку он является открытым.
        ob.gamma = 99;
    }
}

```

## code_109

```cs
// Продемонстрировать применение класса Stack.
using System;
// Класс для хранения символов в стеке.
class Stack
{
    // Эти члены класса являются закрытыми.
    char[] stck; // массив, содержащий стек
    int tos;  // индекс вершины стека
              // Построить пустой класс Stack для реализации стека заданного размера.
    public Stack(int size)
    {
        stck = new char[size]; // распределить память для стека
        tos = 0;
    }
    // Поместить символы в стек.
    public void Push(char ch)
    {
        if (tos == stck.Length)
        {
            Console.WriteLine(" - Стек заполнен.");
            return;
        }
        stck[tos] = ch;
        tos++;
    }
    // Извлечь символ из стека.
    public char Pop()
    {
        if (tos == 0)
        {
            Console.WriteLine(" - Стек пуст.");
            return (char)0;
        }
        tos--;
        return stck[tos];
    }
    // Возвратить значение true, если стек заполнен.
    public bool IsFull()
    {
        return tos == stck.Length;
    }
    // Возвратить значение true, если стек пуст.
    public bool IsEmpty()
    {
        return tos == 0;
    }
    // Возвратить общую емкость стека.
    public int Capacity()
    {
        return stck.Length;
    }
    // Возвратить количество объектов, находящихся в данный момент в стеке.
    public int GetNum()
    {
        return tos;
    }
}
class StackDemo
{
    static void Main()
    {
        Stack stk1 = new Stack(10);
        Stack stk2 = new Stack(10);
        Stack stk3 = new Stack(10);
        char ch;
        int i;
        // Поместить ряд символов в стек stk1.
        Console.WriteLine("Поместить символы А-J в стек stk1.");
        for (i = 0; !stk1.IsFull(); i++)
            stk1.Push((char)('A' + i));
        if (stk1.IsFull()) Console.WriteLine("Стек stk1 заполнен.");
        // Вывести содержимое стека stk1.
        Console.Write("Содержимое стека stk1: ");
        while (!stk1.IsEmpty())
        {
            ch = stk1.Pop();
            Console.Write(ch);
        }
        Console.WriteLine();
        if (stk1.IsEmpty()) Console.WriteLine("Стек stk1 пуст.\n");
        // Поместить дополнительные символы в стек stk1.
        Console.WriteLine("Вновь поместить символы A-J в стек stk1.");
        for (i = 0; !stk1.IsFull(); i++)
            stk1.Push((char)('A' + i));
        // А теперь извлечь элементы из стека stk1 и поместить их в стек stk2.
        // В итоге элементы сохраняются в стеке stk2 в обратном порядке.
        Console.WriteLine("А теперь извлечь символы из стека stk1\n" +
        "и поместить их в стек stk2.");
        while (!stk1.IsEmpty())
        {
            ch = stk1.Pop();
            stk2.Push(ch);
        }
        Console.Write("Содержимое стека stk2: ");
        while (!stk2.IsEmpty())
        {
            ch = stk2.Pop();
            Console.Write(ch);
        }
        Console.WriteLine("\n");
        // Поместить 5 символов в стек.
        Console.WriteLine("Поместить 5 символов в стек stk3.");
        for (i = 0; i < 5; i++)
            stk3.Push((char)('A' + i));
        Console.WriteLine("Емкость стека stk3: " + stk3.Capacity());
        Console.WriteLine("Количество объектов в стеке stk3: " +
        stk3.GetNum());
    }
}


```

## code_110

```cs
// Пример передачи объектов методам по ссылке.
using System;

class MyClass
{
    int alpha, beta;
    public MyClass(int i, int j)
    {
        alpha = i;
        beta = j;
    }
    // Возвратить значение true, если параметр ob
    // имеет те же значения, что и вызывающий объект.
    public bool SameAs(MyClass ob)
    {
        if ((ob.alpha == alpha) & (ob.beta == beta))
            return true;
        else return false;
    }
    // Сделать копию объекта ob.
    public void Copy(MyClass ob)
    {
        alpha = ob.alpha;
        beta = ob.beta;
    }
    public void Show()
    {
        Console.WriteLine("alpha: (0), beta: (1}",
        alpha, beta);
    }
}
class PassOb
{
    static void Main()
    {
        MyClass ob1 = new MyClass(4, 5);
        MyClass ob2 = new MyClass(6, 7);
        Console.Write("ob1: ");
        ob1.Show();
        Console.Write("ob2: ");
        ob2.Show();
        if (ob1.SameAs(ob2))
            Console.WriteLine("ob1 и ob2 имеют одинаковые значения.");
        else
            Console.WriteLine("ob1 и ob2 имеют разные значения.");
        Console.WriteLine();
        // А теперь сделать объект ob1 копией объекта ob2.
        ob1.Copy(ob2);
        Console.Write("оЫ после копирования: ");
        ob1.Show();
        if (ob1.SameAs(ob2))
            Console.WriteLine("ob1 и ob2 имеют одинаковые значения.");
        else
            Console.WriteLine("ob1 и ob2 имеют разные значения.");
    }
}

```

# code_111

```cs
// Передача аргументов обычных типов по значению.
using System;

class Test
{
    /* Этот метод не оказывает никакого влияния на
    аргументы, используемые для его вызова. */
    public void NoChange(int i, int j)
    {
        i = i + j;
        j = -j;
    }
}
class CallByValue
{
    static void Main()
    {
        Test ob = new Test();
        int a = 15, b = 20;
        Console.WriteLine("а и b до вызова: " +
        a + " " + b);
        ob.NoChange(a, b);
        Console.WriteLine("а и b после вызова: " +
        a + " " + b);
    }
}
```

## code_112

```cs
// Передача объектов по ссылке.
using System;

class Test
{
    public int a, b;
    public Test(int i, int j)
    {
        a = i;
        b = j;
    }
    /* Передать объект. Теперь переменные ob.а и ob.b из объекта,
    используемого в вызове метода, будут изменены. */
    public void Change(Test ob)
    {
        ob.a = ob.a + ob.b;
        ob.b = -ob.b;
    }
}
class CallByRef
{
    static void Main()
    {
        Test ob = new Test(15, 20);
        Console.WriteLine("ob.а и ob.b до вызова: " +
        ob.a + " " + ob.b);
        ob.Change(ob);
        Console.WriteLine("ob.а и ob.b после вызова: " +
        ob.a + " " + ob.b);
    }
}

```

## code_113

```cs
// Использовать модификатор ref для передачи значения обычного типа по ссылке.
using System;

class RefTest
{
    // Этот метод изменяет свой аргумент. Обратите
    // внимание на применение модификатора ref.
    public void Sqr(ref int i)
    {
        i = i * i;
    }
}
class RefDemo
{
    static void Main()
    {
        RefTest ob = new RefTest();
        int a = 10;
        Console.WriteLine("а до вызова: " + a);
        ob.Sqr(ref a); // обратите внимание на применение модификатора ref
        Console.WriteLine("а после вызова: " + a);
    }
}
```

## code_114

```cs
// Поменять местами два значения.
using System;

class ValueSwap
{
    // Этот метод меняет местами свои аргументы.
    public void Swap(ref int a, ref int b)
    {
        int t;
        t = a;
        a = b;
        b = t;
    }
}
class ValueSwapDemo
{
    static void Main()
    {
        ValueSwap ob = new ValueSwap();
        int x = 10, у = 20;
        Console.WriteLine("x и у до вызова: " + x + " " + у);
        ob.Swap(ref x, ref у);
        Console.WriteLine("х и у после вызова: " + x + " " + у);
    }
}

```

## code_115

```cs
// Использовать модификатор параметра out.
using System;

class Decompose
{
    /* Разделить числовое значение с плавающей точкой на
    целую и дробную части. */
    public int GetParts(double n, out double frac)
    {
        int whole;
        whole = (int)n;
        frac = n - whole; // передать дробную часть числа через параметр frac
        return whole;      // в озвратить целую часть числа
    }
}
class UseOut
{
    static void Main()
    {
        Decompose ob = new Decompose();
        int i;
        double f;
        i = ob.GetParts(10.125, out f);
        Console.WriteLine("Целая часть числа равна " + i);
        Console.WriteLine("Дробная часть числа равна " + f);
    }
}

```

## code_116

```cs
// Использовать два параметра типа out.
using System;

class Num
{
    /* Определить, имеется ли у числовых значений переменных х и v
    общий множитель. Если имеется, то возвратить наименьший и
    наибольший множители посредством параметров типа out. */
    public bool HasComFactor(int x, int y,
    out int least, out int greatest)
    {
        int i;
        int max = x < y ? x : y;
        bool first = true;
        least = 1;
        greatest = 1;
        // Найти наименьший и наибольший общий множитель.
        for (i = 2; i <= max / 2 + 1; i++)
        {
            if (((y % i) == 0) & ((x % i) == 0))
            {
                if (first)
                {
                    least = i;
                    first = false;
                }
                greatest = i;
            }
        }
        if (least != 1) return true;
        else return false;
    }
}
class DemoOut
{
    static void Main()
    {
        Num ob = new Num();
        int lcf, gcf;
        if (ob.HasComFactor(231, 105, out lcf, out gcf))
        {
            Console.WriteLine("Наименьший общий множитель " +
            "чисел 231 и 105 равен " + lcf);
            Console.WriteLine("Наибольший общий множитель " +
            "чисел 231 и 105 равен " + gcf);
        }
        else
            Console.WriteLine("Общий множитель у чисел 35 и 49 отсутствует.");
        if (ob.HasComFactor(35, 51, out lcf, out gcf))
        {
            Console.WriteLine("Наименьший общий множитель " +
            "чисел 35 и 51 равен " + lcf);
            Console.WriteLine("Наибольший общий множитель " +
            "чисел 35 и 51 равен " + gcf);
        }
        else
            Console.WriteLine("Общий множитель у чисел 35 и 51 отсутствует.");
    }
}

```

## code_117

```cs
// Поменять местами две ссылки.
using System;

class RefSwap
{
    int a, b;
    public RefSwap(int i, int j)
    {
        a = i;
        b = j;
    }
    public void Show()
    {
        Console.WriteLine("a: {0}, b: {l}", a, b);
    }
    // Этот метод изменяет свои аргументы.
    public void Swap(ref RefSwap ob1, ref RefSwap ob2)
    {
        RefSwap t;
        t = ob1;
        ob1 = ob2;
        ob2 = t;
    }
}
class RefSwapDemo
{
    static void Main()
    {
        RefSwap x = new RefSwap(1, 2);
        RefSwap y = new RefSwap(3, 4);
        Console.Write("x до вызова: ");
        x.Show();
        Console.Write("у до вызова: ");
        y.Show();
        Console.WriteLine();
        // Смена объектов, на которые ссылаются аргументы х и у.
        x.Swap(ref x, ref y);
        Console.Write("х после вызова: ");
        x.Show();
        Console.Write("у после вызова: ");
        y.Show();
    }
}
```

## code_118

```cs
// Продемонстрировать применение модификатора params.
using System;

class Min
{
    public int MinVal(params int[] nums)
    {
        int m;
        if (nums.Length == 0)
        {
            Console.WriteLine("Ошибка: нет аргументов.");
            return 0;
        }
        m = nums[0];
        for (int i = 1; i < nums.Length; i++)
            if (nums[i] < m) m = nums[i];
        return m;
    }
}
class ParamsDemo
{
    static void Main()
    {
        Min ob = new Min();
        int min;
        int a = 10, b = 20;
        // Вызвать метод с двумя значениями.
        min = ob.MinVal(a, b);
        Console.WriteLine("Наименьшее значение равно " + min);
        // Вызвать метод с тремя значениями.
        min = ob.MinVal(a, b, -1);
        Console.WriteLine("Наименьшее значение равно " + min);
        // Вызвать метод с пятью значениями.
        min = ob.MinVal(18, 23, 3, 14, 25);
        Console.WriteLine("Наименьшее значение равно " + min);
        // Вызвать метод с массивом целых значений.
        int[] args = { 45, 67, 34, 9, 112, 8 };
        min = ob.MinVal(args);
        Console.WriteLine("Наименьшее значение равно " + min);
    }
}

```

## code_119

```cs
// Использовать обычный параметр вместе с параметром
// переменной длины типа params.
using System;

class MyClass
{
    public void ShowArgs(string msg, params int[] nums)
    {
        Console.Write(msg + " " );
    foreach (int i in nums)
            Console.Write(i + " ");
        Console.WriteLine();
    }
}
class ParamsDemo2
{
    static void Main()
    {
        MyClass ob = new MyClass();
        ob.ShowArgs("Это ряд целых чисел",
        1, 2, 3, 4, 5);
        ob.ShowArgs("А это еще два целых числа ",
        17, 20);
    }
}
```

## code_120

```cs
// Возвратить объект из метода.
using System;

class Rect
{
    int width;
    int height;
    public Rect(int w, int h)
    {
        width = w;
        height = h;
    }
    public int Area()
    {
        return width * height;
    }
    public void Show()
    {
        Console.WriteLine(width + " " + height);
    }
    /* Метод возвращает прямоугольник со сторонами, пропорционально
    увеличенными на указанный коэффициент по сравнению с вызывающим
    объектом прямоугольника. */
    public Rect Enlarge(int factor)
    {
        return new Rect(width * factor, height * factor);
    }
}
class RetObj
{
    static void Main()
    {
        Rect r1 = new Rect(4, 5);
        Console.Write("Размеры прямоугольника r1: ");
        r1.Show();
        Console.WriteLine("Площадь прямоугольника r1: " + r1.Area());
        Console.WriteLine();
        // Создать прямоугольник в два раза больший прямоугольника r1.
        Rect r2 = r1.Enlarge(2);
        Console.Write("Размеры прямоугольника r2: ");
        r2.Show();
        Console.WriteLine("Площадь прямоугольника r2: " + r2.Area());
    }
}

```

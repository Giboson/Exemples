
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

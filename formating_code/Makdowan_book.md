
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

    class Example2 {
    static void Main() {
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
class ProdSum {
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

    Console.WriteLine("=> Data type parsing:"); 
    bool b = bool.Parse("True");
    Console.WriteLine("Value of b: {0} ", b); // Вывод значения b
    double d = double.Parse(" 99. 884 ");
    Console.WriteLine ("Value of d: {0} ", d); // Вывод значения d
    int i = int.Parse( "8");
    Console.WriteLine("Value of i: {0}", i); // Вывод значения i
    char c = Char.Parse( "w" );
    Console.WriteLine("Value of c: {0} ", c); // Вывод значения с
    Console.WriteLine();

```

## code_10

```cs
    Console.WriteLine ("=> Data type parsing with TryParse:"); 
        if (bool.TryParse("True", out bool b));
        {
        Console.WriteLine("Value of b: {0}", b);  // Вывод значения b
        }
        string value = "Hello";
        if (double.TryParse(value, out double d))
        {
        Console.WriteLine("Value of d: {0}", d) ;  // Вывод значения d
        }
        else
        {
        // Преобразование потерпело неудачу
        Console.WriteLine("Failed to convert the input ({0}) to a double",value);
        }
        Console.WriteLine();

```

## code_11

```cs
        Console.WriteLine("=> Dates and Times:");
        // Этот конструктор принимает год, месяц и день.
        DateTime dt = new DateTime (2015, 10, 17);
        // Какой это день месяца?
        Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
        // Сейчас месяц декабрь.
        dt = dt.AddMonths(2);
        Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
        // Этот конструктор принимает часы, минуты и секунды.
        TimeSpan ts = new TimeSpan(4, 30, 0) ;
        Console.WriteLine(ts);
        // Вычесть 15 минут из текущего значения TimeSpan и вывести результат.
        Console.WriteLine(ts.Subtract (new TimeSpan(0, 15, 0)));

```

## code_12

```cs
    
    Console.WriteLine("=> Use Digit Separators:"); 
    Console.Write("Integer:");
    Console.WriteLine(123_456);
    Console.Write("Long:");
    Console.WriteLine(123_456_789L);
    Console.Write("Float:");
    Console.WriteLine(123_456.1234F);
    Console.Write("Double:");
    Console.WriteLine(123_456.12);
    Console.Write("Decimal:");
    Console.WriteLine(123_456.12M);

    Console.WriteLine ("=> Use Binary Literals:");
    Console.WriteLine("Sixteen: {0}" , 0b0001_0000);
    Console.WriteLine("Thirty Two: {0}",0b0010_0000);
    Console.WriteLine("Sixty Four: {0}", 0b0100_0000);

    Console.WriteLine("=> Basic String functionality:"); 
    string firstName = "Freddy";
    Console.WriteLine("Value of firstName: {0}", firstName);
    // Значение firstName.
    Console.WriteLine("firstName has {0} characters.", firstName.Length);
    // Длина firstname.
    Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
    // firstName в верхнем регистре.
    Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower ());
    // firstName в нижнем регистре.
    Console.WriteLine("firstName contains the letter у?:{0}",firstName.Contains("y")); 
    // Содержит ли firstName букву у?
    Console.WriteLine("firstName after replace: {0}", firstName.Replace("y", "")); 
    // firstName после замены.
    Console.WriteLine();

```

## code_13

```cs

    Console.WriteLine("=> String equality:");
    string si = "Hello!";
    string s2 = "Yo!";
    Console.WriteLine("si = {0}", si);
    Console.WriteLine("s2 = {0}", s2);
    Console.WriteLine();
    // Проверить строки на равенство.
    Console.WriteLine("si == s2: {0}", si == s2);
    Console.WriteLine("si == Hello!: {0}", si == "Hello!");
    Console.WriteLine("si == HELLO!: {0}", si == "HELLO!");
    Console.WriteLine("si == hello!: {0}", si == "hello!");
    Console.WriteLine("si.Equals(s2): {0}", si.Equals(s2));
    Console.WriteLine("Yo!.Equals(s2): {0}", "Yo!".Equals(s2));
    Console.WriteLine();

```

## code_14

```cs
        Console.WriteLine("=> String equality (Case Insensitive:");
    string s1 = "Hello!";
    string s2 = "HELLO!";
    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine("s2 = (0}", s2);
    Console.WriteLine();
    // Проверить результаты изменения стандартных правил сравнения.
        Console.WriteLine("Default rules: sl={0},s2={1}si.Equals(s2): {2}",s1, s2, s1.Equals(s2));
        Console.WriteLine("Ignore case: si.Equals(s2,StringComparison.OrdinallgnoreCase): {0}", s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Ignore case, Invariant Culture: si.Equals(s2, StringComparison.InvariantCulturelgnoreCase): {0}",s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
        Console.WriteLine();
        Console.WriteLine("Default rules: sl={0},s2={1} sl.IndexOf(\"E\"): {2}",s1, s2, s1.IndexOf("E"));
        Console.WriteLine("Ignore case: si.IndexOf(\"E\",StringComparison.OrdinalIgnoreCase):{0}", s1.IndexOf("E",StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Ignore case, Invariant Culture: si.IndexOf(\"E\",StringComparison.InvariantCulturelgnoreCase): {0}", s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
        Console.WriteLine();

```

## code_15

```cs
    Console.WriteLine("=> Immutable Strings:\a");
    // Установить начальное значение для строки,
    string s1 = "This s1 my string.";
    Console.WriteLine("s1 = {0}", s1);
    // Преобразована ли строка s1 в верхний регистр?
    string upperstring = s1.ToUpper();
    Console.WriteLine("upperstring = {0}", upperstring);
    // Нет! Строка s1 осталась в том же виде!
    Console.WriteLine("s1 = {0}", s1);

```

## code_16

```cs
    using System.Text;

    Console.WriteLine("=> Using the StringBuilder:");
    StringBuilder sb = new StringBuilder("******Fantastic Games *****");
    sb.Append("\n");
    sb.AppendLine("Half Life");
    sb.AppendLine("Morrowind");
    sb.AppendLine("Deus Ex" + "2");
    sb.AppendLine("System Shock");
    Console.WriteLine(sb.ToString());
    sb.Replace("2", " Invisible War");
    Console.WriteLine(sb.ToString());
    Console.WriteLine("sb has {0} chars.", sb.Length);
    Console.WriteLine();

```

## code_17

```cs
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

```

## code_18

```cs

    using System;

    Console.WriteLine("**** Fun With type conversions ****");
    // Явно привести int к short (и разрешить потерю данных)
    short numb1 = 30000, numb2 = 30000;
    short answer = (short)Add(numb1, numb2);

    Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);
    
    NarrowingAttempt();
    Console.ReadLine();
    static int Add(int x, int y)
    {
        return x + y;
    }

    static void NarrowingAttempt()
    { 
         byte myByte = 0;
        int mylnt = 200;
        // Явно привести int к byte (без потери данных).
        myByte = (byte)mylnt;
        Console.WriteLine("Value of myByte: {0}", myByte);
    
    }

```

## code_19

```cs


```


# code_1

```cs
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


```

## code_2

```cs

    Console.WriteLine("=> Using new to create variables:");
    bool b = new bool();             // Устанавливается в false
    int i = new int();              // Устанавливается в 0
    double d = new double();        // Устанавливается в 0.0
    DateTime dt = new DateTime();    // Устанавливается
                                    // в 1/1/0001 12:00:00 AM

    Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
    Console.WriteLine();
```

## code_3

```cs
            // Set up Console UI (CUI)
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("***********************************");
            Console.WriteLine("*****Welcome to My Rocking App*****");
            Console.WriteLine("***********************************");
            Console.BackgroundColor = ConsoleColor.Black;
            //  Wait for button  <Enter> kay to be Pressed
             Console.ReadLine();

```

## code_4

```cs
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
```

## code_5

```cs
            Console.WriteLine("**************************");
            Console.WriteLine("***** My First C# App*****");
            Console.WriteLine("**************************");
            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("args: {0}", args[i]);
            }
             //  Wait for button  <Enter> kay to be Pressed
             Console.ReadLine();
            return 0;

```

## code_6

```cs
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

```

## code_7

```cs
    Console.WriteLine("=> Data Declarations:");
    // Локальные переменные объявляются и инициализируются так:
    // тип Данных имя Переменной - начальное Значение;
    int mylnt = 0; 
    string myString;
    myString = "This is my character data";
    // Объявить три переменных типа bool в одной строке, 
    bool bl = true, b2 = false, bЗ = bl;
    // Использовать тип данных System.Boolean для объявления булевской переменной.
    System.Boolean b4 = false;
    Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}", 
    mylnt, myString, bl, b2, bЗ, b4);
    Console.WriteLine();

```

## code_8

```cs
    Console.WriteLine("=> char type Functionality:"); 
        char myChar = 'a';
    Console.WriteLine("char.IsDigit ( 'a') : {0}", char.IsDigit(myChar));
    Console.WriteLine("char.IsLetter ( 'a' ) : {0}", char.IsLetter(myChar)); 
    Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}",
        char.IsWhiteSpace("Hello There", 5));
    Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}",
        char.IsWhiteSpace("Hello There", 6));
    Console.WriteLine("char.IsPunctuation('?'): {0}",
        char.IsPunctuation('?'));
    Console.WriteLine();

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

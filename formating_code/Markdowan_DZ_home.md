
# Task_1

```C#

/**
Lesson1 
 * Задача 2: Напишите программу, 
 * которая на вход принимает два числа и выдаёт,
 * какое число большее, а какое меньшее.
 * a = 5; b = 7 -> max = 7
 * a = 2  b = 10 -> max = 10
 * a = -9 b = -3 -> max = -3
*/
        Console.Write("Введите первое число 1 ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число 2 ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        if (number1 > number2)
        {
            Console.Write(" Максимальное число: " + number1);
            Console.Write(" Минимальное число: " + number2);
        }
        else if (number1 <= number2)
        {
            Console.Write(" Максимальное число: " + number2);
            Console.Write(" Минимальное число: " + number1);
        }

```

# Task_2

```C#

/**
Lesson2
    * Задача 4: Напишите программу,
    * которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    * 2, 3, 7 -> 7
    * 44 5 78 -> 78
    * 22 3 9 -> 22
*/
        Console.Write("Введите первое число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите третье число: ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        int max = number1;
        if (number2 > max)
        {
            max = number2;
        }
        if (number3 > max)
        {
            max = number3;
        }
        Console.Write("Максимальное число: " + max);

```

# Task_3

```C#

/**
Lesson 3
     * Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
     * является ли число чётным (делится ли оно на два без остатка).
     * 4 -> да
     * -3 -> нет
     * 7 -> нет
*/
        Console.Write("Введите число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        if (number1 % 2 == 0)
        {
            Console.Write(number1 + " Четное число: ");
        }
        else
        {
            Console.Write(number1 + " Нечетное число: ");
        }
```

# Task_4

```C#

/**
Lesson4 
     * Задача 8: Напишите программу, которая на вход принимает число (N), 
     * а на выходе показывает все чётные числа от 1 до N.
     * 5 -> 2, 4
     * 8 -> 2, 4, 6, 8
*/
    Console.Write("Введите число: ");
        int N = Convert.ToInt32(Console.ReadLine());
        if (N < 0)
        {
            Console.Write("Вы ввели некорректное число: ");
        }
        else
        {
            int i = 2;
            while (i <= N)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

```

# Task_5

```C#
/**
Lesson5
 * Задача 10: Напишите программу, которая         принимает на вход 
   трёхзначное число и на выходе показывает вторую цифру этого числа.
 * 456 -> 5
 * 782 -> 8
 * 918 -> 1
*/
        int number = ReadInt("Введите трехзначное число: ");
        int amount = number.ToString().Length;

        if (amount < 3 || amount > 3)
        {
            Console.WriteLine("Вы ввели не трехзначное число");
        }
        else
        {
            Console.WriteLine(InCenter(number));
        }


        int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }


        int InCenter(int a)
        {
            int result = a / 10 % 10;
            return result;
        }
  
```

# Task_6

```C#

/**
Lesson6
 * Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
 * 645 -> 5
 * 78 -> третьей цифры нет
 * 32679 -> 6
*/
        int number = ReadInt("Введите число: ");
        int count = number.ToString().Length;
        Console.Write(MakeArray(number, count));

        int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        int MakeArray(int a, int b)
        {
            int result = 0;
            if (b < 3)
            {
                Console.Write("Третьей цифры нет, держи: ");
            }
            else
            {
                int c = 1;
                for (int i = b; i > 3; i--)
                {
                    c = c * 10;
                }

                result = a / c % 10;
            }
            return result;
        }
```

# Task_7

```C#

/**
Lesson7
 * Задача 15: Напишите программу,
 * которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
 * 6 -> да
 * 7 -> да
 * 1 -> нет
*/
int dayNumber = ReadInt("Введите число от 1 до 7: ");
        Console.WriteLine(WorkHoliday(dayNumber));
        int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }


        string WorkHoliday(int a)
        {
            if (a > 0 && a < 8)
            {
                if (a == 7 || a == 6)
                {
                    Console.Write("Под цифрой " + a + " - Выходной");
                }
                else
                {
                    Console.Write("Под цифрой " + a + " - Рабочий");
                }
            }
            else
            {
                Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
            }
            return " день.";
        }
```

```C#

```

```C#

```

```C#

```

```C#

```

```C#

```

```C#

```

```C#

```

```C#

```

```C#

```

```C#

```

```C#

```

```C#

```

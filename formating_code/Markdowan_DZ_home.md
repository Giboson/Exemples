
# Task_1

```cs

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

```cs

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

```cs

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

```cs

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

```cs
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

```cs

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

```cs

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

# Task_8

```cs
/**
        Принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        14212 -> нет
        23432 -> да
        12821 -> да
*/

  
/**
        Принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        14212 -> нет
        23432 -> да
        12821 -> да
*/

  using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
    if (number < 10000 || number >= 100000){
            Console.WriteLine("Число не пятизначное");
            return false;
        }

        int reverse = 0;
        int temp = number;
        while (temp > 0){
            reverse = reverse * 10 + temp % 10;
            temp /= 10;
        }
        return reverse == number;
    }
  
     // Не удаляйте и не меняйте метод Main! 
        static void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else 
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           // 1. 14212 -> нет 2. 23432 -> да 3. 12821 -> да:
            number = 645464;

        }

         // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
} 

```

# Task_9

```cs
/**
      Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.
        A (3,6,8); B (2,1,-7) -> 15.84
        A (7,-5, 0); B (1,-1,9) -> 11.53
*/
using System;

public class Answer
{
    private static double Length(int[] pointA, int[] pointB)
    {
      // Введите свое решение ниже
        {
    int x1 = pointA[0];
    int y1 = pointA[1];
    int z1 = pointA[2];
    int x2 = pointB[0];
    int y2 = pointB[1];
    int z2 = pointB[2];

    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return distance;
    }

    }

  // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args) {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6) {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           //  1. A (3,6,8); B (2,1,-7) -> 15.84 2. A (7,-5, 0); B (1,-1,9) -> 11.53
            x1 = 7;
            x2 = -5;
            x3 = 0;
            y1 = 1;
            y2 = -1;
            y3 = 9;
        }

        // Не удаляйте строки ниже
        double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
        Console.WriteLine($"{result:F2}");
    }
}

```

# Task_10

```cs
    /**
   Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.
/* N = 3 
1
8
27
*/
/* N = 5
1
8
27
64
125
**/

using System;

public class Answer
{
   static void ShowCube(int N)
    {
      // Введите свое решение ниже
        for (int i = 1; i <= N; i++)
        {
            int cobe = i * i * i;
            Console.WriteLine(cobe);
        }
    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 5;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}

```

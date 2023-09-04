
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
    задача 24:
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

# Task_11

```cs

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

    int Prompt(string massage)
    {
    System.Console.Write(massage); // Enter  (A & B)
    string readImput = System.Console.ReadLine(); // number -> name
    int result = int.Parse(readImput);
    return result;

    }

    int Power(int powerBase, int expronent)
    {
        int power = 1;
        for (int i = 0; i < expronent; i++)
        {
            power *= powerBase;
        }
       return power;
    } 
    bool ValidateExponent(int expronent)
    {
        if (expronent < 0)
            {
                System.Console.WriteLine("Покозатель не должен быть меншье нуля");
                return false;
            }
            return true;

    }
    int powerBase = Prompt("Введите основание: ");
    int expronent = Prompt("Введите показатель: ");
    if(ValidateExponent(expronent))
    {
        System.Console.WriteLine($"Число {powerBase} в степени {expronent} ровно {Power(powerBase, expronent)}");
    }

```

# Task_12

```cs

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string massage)

{
    System.Console.Write(massage);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
    int SumAllDigit(int number)
    {
        int result = 0;
            while (number > 0)
            {
                result += number % 10;
                number = number / 10;

            }
            return result;
    }
    int number = Prompt("Введите число:");
    System.Console.WriteLine($"Сумма всех чисел в цифре {number}={SumAllDigit(number)}");

```

# Task_13

```cs

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.WriteLine($"\nЗадача 29. Ряд чисел преобразует в массив");
Console.Write("Введите ряд чисел, разделенных запятой : ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";    // дополнительня запятая для обозначения конца строки

// функция удаления пробелов из строки 
string RemovingSpaces(string series)
{
    string seriesNew = "";
    for (int i = 0; i < series.Length; i++)
    {
        if (series[i] != ' ')
        {
            seriesNew += series[i];
        }
    }
    return seriesNew;
}

//  функция  проверки на правильность ввода 
void СheckNumber2(int series)
{

    if (series == '0' || series == '1' || series == '2'
    || series == '3' || series == '4' || series == '5' || series == '6'
    || series == '7' || series == '8' || series == '9' || series == ','
    || series == '-')
    {
    }
    else
    {
        Console.WriteLine($"Ошибка ввода  символа. Вводи цифры.");

    }
}

// функция  создания и заполнения массива из строки
int[] ArrayOfNumbers(string seriesNew)
{

    int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента

    int j = 0;

    for (int i = 0; i < seriesNew.Length; i++)
    {
        string seriesNew1 = "";

        while (seriesNew[i] != ',' && i < seriesNew.Length)
        {
            seriesNew1 += seriesNew[i];
            СheckNumber2(seriesNew[i]);
            i++;
        }
        arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
        if (i < seriesNew.Length - 1)
        {
            arrayOfNumbers = arrayOfNumbers.Concat(new int[] { 0 }).ToArray();    // добавляет новый нулевой элемент в конец массива
        }
        j++;
    }
    return arrayOfNumbers;
}

// функция  вывода массива на печать 
void PrintArry(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(coll[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}


string seriesNew = RemovingSpaces(seriesOfNumbers);

int[] arrayOfNumbers = ArrayOfNumbers(seriesNew);

PrintArry(arrayOfNumbers);

```

# Task_14

```cs
// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = ReadInt("Введите размерность массива: ");
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
      if (numbers[i] % 2 == 0)
      {
            result++;
      }
}
if (result % 10 == 1)
{
      Console.WriteLine($"В массиве {result} четное число");
}
if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
{
      Console.WriteLine($"В массиве {result} четных числа");
}
else

      Console.WriteLine($"В массиве {result} четных чисел");

// Методы
void FillArrayRandomNumbers(int[] array) //Заполнение массива
{
      for (int i = 0; i < array.Length; i++)
      {
            array[i] = new Random().Next(99, 999);
      }
}

void PrintArray(int[] array) //Вывод массива на экран
{
      for (int i = 0; i < array.Length; i++)
      {
            Console.Write(array[i] + " ");
      }
      Console.WriteLine();
}


int ReadInt(string message)  //Функция ввода
{
      Console.Write(message);
      return Convert.ToInt32(Console.ReadLine());
}
```

# Task_15

```cs

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = ReadInt("Введите размерность массива: ");
int min = ReadInt("Введите минимальное число массива: ");
int max = ReadInt("Введите максимальное число массива: ");
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
      if (i % 2 != 0)
      {
            result += numbers[i];
      }
}
Console.WriteLine($"Сумма элементов нечетных позиций = {result}");

// Методы
void FillArrayRandomNumbers(int[] array) //Заполнение массива
{
      for (int i = 0; i < array.Length; i++)
      {
            array[i] = new Random().Next(min, max);
      }
}

void PrintArray(int[] array) //Вывод массива на экран
{
      for (int i = 0; i < array.Length; i++)
      {
            Console.Write(array[i] + " ");
      }
      Console.WriteLine();
}

int ReadInt(string message)  //Функция ввода
{
      Console.Write(message);
      return Convert.ToInt32(Console.ReadLine());
}

```

# Task_16

```cs
// Задача 38: Задайте массив вещественных чисел.
// Specify an array of real numbers. Find the difference between the
// maximum and minimum array elements.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] numbers = { 3.22, 4.2, 1.15, 77.15, 65.2 };

double max = numbers[0];
double min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

// void FillArrayRandomNumbers(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = new Random().Next(1, 555);
//   }
// }


// void PrintArray(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
// }
Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Минимальное число: {max}");
Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");



```

# Task_17

```cs

/*
Задача 47. 
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

using System;

public class Answer 
{
  private static Random random = new Random();

  public static double[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
   {
      // Введите свое решение ниже
     double[,] matrix = new double[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = random.NextDouble() * (maxLimitRandom - minLimitRandom) + minLimitRandom;
            }
        }

        return matrix;
   

  }

  public static void PrintArray(double[, ] matrix) {
      // Введите свое решение ниже
      for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j].ToString("F1") + " ");
            }
            Console.WriteLine();
        }
   
  }
   

  // Не удаляйте и не меняйте метод Main! 
  public static void Main(string[] args) {
    int m, n, minLimitRandom, maxLimitRandom;

    if (args.Length >= 4) {
      m = int.Parse(args[0]);
      n = int.Parse(args[1]);
      minLimitRandom = int.Parse(args[2]);
      maxLimitRandom = int.Parse(args[3]);

      double[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);

        // Выберем случайные индексы трех элементов матрицы array
        int row1 = new Random().Next(0, m);
        int col1 = new Random().Next(0, n);
        int row2 = new Random().Next(0, m);
        int col2 = new Random().Next(0, n);
        int row3 = new Random().Next(0, m);
        int col3 = new Random().Next(0, n);

        // Проверяем, являются ли выбранные элементы дробными числами
        bool isFractional1 = (array[row1, col1] % 1) != 0;
        bool isFractional2 = (array[row2, col2] % 1) != 0;
        bool isFractional3 = (array[row3, col3] % 1) != 0;

        // Если два из трех элементов не являются дробными числами, то бросаем исключение
        if ((isFractional1 && isFractional2) || (isFractional1 && isFractional3) || (isFractional2 && isFractional3))
        {
            Console.WriteLine("Все ок!");
        }
        else
        {
            throw new Exception("Выбранные элементы не содержат по крайней мере два дробных числа.");
        }
    } else {
      m = 3;
      n = 4;
      minLimitRandom = -10;
      maxLimitRandom = 10;
      
      double[, ] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
      PrintArray(result);
    }
  }
}

```

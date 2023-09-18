# array_1

```cs

int[] array = new int[5];
for  (int  i = 0; i < 5; i++)
array[i] = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("["+string.Join(", ", array) + "]");
Console.WriteLine(array[3]);

```

## array_2

```cs

    int n = 5;
    int[] array = new int[n];
    for  (int  i = 0; i < 5; i++)
    array[i] = Convert.ToInt32(Console.ReadLine()!);

    Console.WriteLine("["+string.Join(", ", array) + "]");
    Console.WriteLine(array[3]);
    // [4, 5, 3, 1, 2] = sum 
    int summa = 0;
    for (int i = 0; i < n; i++)
    summa += array[i];
    Console.WriteLine(summa);

```

## array_3

```cs

int n = Convert.ToInt32(Console.ReadLine()!);
    int [, ] matrix = new int[n, n];

    for (int i = 0; i < n; i++)
    {
        for (int j = i; j < n; j++)
        {
            
            matrix[i, j] = (i * 1) * (j + 1);
            matrix[j, i] = (i * 1) * (j + 1);
         
       
        }
        Console.WriteLine();
    }
    for (int  i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j]);
            Console.Write(" ");

        }
        Console.WriteLine();
    } 

```

## array_4

```cs

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите размер таблицы умножения: ");
        int size = Convert.ToInt32(Console.ReadLine());

        PrintMultiplicationTable(size);
    }

    public static void PrintMultiplicationTable(int size)
    {
        // Создаем матрицу для таблицы умножения
        int[,] table = new int[size, size];

        // Заполняем матрицу значениями
        FillMultiplicationTable(table, size);

        // Выводим матрицу на экран
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(table[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public static void FillMultiplicationTable(int[,] table, int size, int i = 0, int j = 0)
    {
        if (i < size)
        {
            if (j < size)
            {
                // Заполняем ячейку таблицы умножения
                table[i, j] = (i + 1) * (j + 1);

                // Рекурсивный вызов для следующей ячейки таблицы
                FillMultiplicationTable(table, size, i, j + 1);
            }
            else
            {
                // Рекурсивный вызов для следующей строки таблицы
                FillMultiplicationTable(table, size, i + 1, 0);
            }
        }
    }
}


```

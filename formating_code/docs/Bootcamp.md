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

## array_5

```cs
// Сортировка Выбором O(n^2) 

/*
[45, 23, -10, 5, 3, 9, 1]
min = -10
[-10, 23, 45, 5, 3, 9, 1]
min = 1
[-10, 1, 45, 5, 3, 9, 23]
min = 3
[-10, 1, 3, 5, 45, 9, 23]
min = 5
[-10, 1, 3, 5, 45, 9, 23]
min = 9
[-10, 1, 3, 5, 9, 45, 23]
min = 23
[-10, 1, 3, 5, 9, 23, 45]
*/
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-20, 21);  // [-20; 20]
}


int[] sortVibor(int[] array)
{
    for (int i = 0; i < array.Length; i++) // Счетчики цикла лучше всего обзывать i, j, k, m, n, l
    {
        int indexMin = i;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] < array[indexMin])
                indexMin = j;
        }
        if (array[indexMin] == array[i])
            continue; // переход к следующей итерации цикла
        
        int temp = array[i];
        array[i] = array[indexMin];
        array[indexMin] = temp;
    }
    return array;
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Конечный массив: [{string.Join(", ", sortVibor(array))}]");
```

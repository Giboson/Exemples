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

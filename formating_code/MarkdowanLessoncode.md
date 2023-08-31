
# Lessen_1

```cs

        Console.WriteLine("Username");
        string usernmae = Console.ReadLine();
        Console.WriteLine("Hi, ");
        Console.WriteLine(usernmae);

```

# Lesson_2

```cs

        // int number =  10,  double = number 10.5 
        double numberA = 12;
        double numberB = 5;
        Console.WriteLine(numberA / numberB);

```

# Lesson_3

```cs

Console.Write("the username, ");
        string username = Console.ReadLine();

        if (username.ToLower() == "sendi")
        {
            Console.WriteLine("You Sendi, ");
        } 
        else 
        {
            Console.Write("Hello, ");
            Console.WriteLine(username);
        }
```

# Lesson_4

```cs

   int a = 1;
        int b = 2;
        int c = 6;
        int d = 8;
        int e = 4;

        int max = a;
        
        if (a > max ) max = a;
        if (b > max ) max = b;
        if (c > max ) max = c;  
        if (e > max ) max = e;  
        if (d > max ) max = d;   

        Console.Write("max = ");
        Console.WriteLine(max);
```

# Lesson_5

```cs


            Console.WriteLine("Pascal Triangle Program");
            Console.Write("Enter the number of rows: ");
            string input = Console.ReadLine();
 
            int n = Convert.ToInt32(input);
 
 
            for (int y = 0; y < n; y++)
            {
                int c = 1;
                for (int q = 0; q < n - y; q++)
                {
                    Console.Write("   ");
                }
 
                for (int x = 0; x <= y; x++)
                {
                    Console.Write("   {0:D} ", c);
                    c = c * (y - x) / (x + 1);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();    
```

# Lesson_6

```cs

        Console.Clear();
        //Console.SetCursorPosition(10, 4);
        //Console.WriteLine("+");

        int Xa = 20, Ya = 1, Xb = 1, Yb = 15, Xc = 40, Yc = 15;
      
        Console.SetCursorPosition(Xa, Ya);
        Console.WriteLine("+");
        Console.SetCursorPosition(Xb, Yb);
        Console.WriteLine("+");
        Console.SetCursorPosition(Xc, Yc);
        Console.WriteLine("+");

        int x = Xa, y = Xb;
        int count = 0; 

        while (count < 1000)
        {

            int what = new Random().Next(0, 3); // [0;3) 0 1 2
            if (what == 0)
            {
                x = (x + Xa) / 2;
                y = (y + Ya) / 2;

            }

            if (what == 1)
            {
                x = (x - Xa) / 2;
                y = (y - Ya) / 2;

            }
             if (what == 2)
            {
                x = (x - Xc) / 2;
                y = (y - Yc) / 2;

            }
             Console.SetCursorPosition(x, y);
             Console.WriteLine("+");
             count++;
        }
```

Lesson_7

```cs

 int Max(int arg1, int arg2, int arg3)
    {
        int result = arg1;
        if (arg2 > result) result = arg2;
        if (arg3 > result) result = arg3;
        return result;
    }
    int a1 = 15;
    int b1 = 21;
    int c1 = 39;
    int a2 = 12;
    int b2 = 23;
    int c2 = 33;
    int a3 = 13;
    int b3 = 23; 
    int c3 = 31;
    // code formating (1)(2)(3)
    //(2) int max1 = Max(a1,b1,c1); int max2 = Max(a2,b2,c2); int max3 = Max(a3,b3,c3); int max = Max(max1, max2, max3); 
    //(1) if (b1 > max) max = b1; if (c1 > max) max = c1; if (a2 > max) max = a2; if (b2 > max) max = b2; if (c2 > max) max = c2; if (a3 > max) max = a3; if (b3 > max) max = b3; if (c3 > max) max = c3;
    
    // (3) version
    int max = Max(
        Max(a1,b1,c1),
        Max(a2,b2,c2),
        Max(a3,b3,c3));
    Console.WriteLine(max);
```

# Lesson_8

```cs

int Max(int arg1, int arg2, int arg3)
    {
        int result = arg1;
        if (arg2 > result) result = arg2;
        if (arg3 > result) result = arg3;
        return result;
    }
    // sorting numbers in order
    //                  0   1   2   3   4   5   6   7   8
        int[] array = {11, 21, 31, 41, 15, 61, 17, 18, 19};
    // * sorting numbers test              //
        //array[0] = 12;
        //Console.WriteLine(array[4]);

        int result = Max(
                  Max(array[0], array[1], array[2]),
                  Max(array[3], array[4], array[5]),
                  Max(array[6], array[7], array[8])
                  );
                  Console.WriteLine(result);
```

# Lesson_9

```cs

    // sorting numbers in order
        //             0   1   2   3   4   5   6   7   8   9  10   11  12
        int[] array = {1, 12, 31, 4, 15, 16, 17, 18, 19, 10, 111, 121, 18};

        int n = array.Length;
        int find = 18;
        int index = 0;

        while(index < n)
        {
            if (array[index] == find) 
            {
                Console.WriteLine(index);
                break;
            }  
            // index = index + 1;
            index++;
        }
```

# Lessen_10

```cs

    int c3 = 31;
    // code formating (1)(2)(3)
    //(2) int max1 = Max(a1,b1,c1); int max2 = Max(a2,b2,c2); int max3 = Max(a3,b3,c3); int max = Max(max1, max2, max3); 
    //(1) if (b1 > max) max = b1; if (c1 > max) max = c1; if (a2 > max) max = a2; if (b2 > max) max = b2; if (c2 > max) max = c2; if (a3 > max) max = a3; if (b3 > max) max = b3; if (c3 > max) max = c3;
    
    // (3) version
    int max = Max(
        Max(a1,b1,c1),
        Max(a2,b2,c2),
        Max(a3,b3,c3));
    Console.WriteLine(max);

```

# Lesson_11

```cs

 int length = collection.Length;
            int index = 0;
            int position = 0;
            while (index < length)
            {
                collection[index] = new Random().Next(1, 10);
                // index = index + 1;
                index++;
            }
        void PrintArray(int[] col)
        {
            int  count = col.Length;
            int position = 0;

            while(position < count)
            {
                Console.WriteLine(col[position]);
                position++;
            }
        }

        int IndexOf(int[] collection,
                    int find);
        
        int count = Collection.Length;
        index = 0;
        index position = 0;
        while(index < count)
        {
            int count = collection.Length;
            if (collection[index] == find)
            {
                position = index;
                break;

            }
            index++;
        } 
        return position;
    //                      { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
       int[] array = new int[10]; 
    
    FillArray(array);
    PrintArray(array);
    Console.WriteLine(); 

    int pos = IndexOf(array, 4);
    Console.WriteLine(pos);
```

# Lesson_12

```cs
 int numberA = new Random().Next(1, 10); // Number Random 0 do 9 
        Console.WriteLine(numberA); 
        int numberB = new Random().Next(1, 10); // Number Random 0 do 9
        Console.WriteLine(numberB); 
        // result +
        int result = numberA + numberB;
        Console.WriteLine(result);
```

# Lesson_13

```cs
// вид 1 
    void Method1()
    {
    Console.WriteLine("@Autor: -> Andrew ");
    }
    Method1();

// вид 2 
    void Method2(string msg, int count)
        {

         int i = 0;
         while (i < count)
            {
             Console.WriteLine(msg);
            i++; 
            }

        }
    Method2(msg:" 1:Text", count: 1);
    Method2(count: 1, msg:" 2:Text");

    // вид 3
    int Method3()
    {
        return DateTime.Now.Year;
    }
    int year = Method3();
    Console.WriteLine(year);

    // вид 4
    string Method4(int count, string text)
    {
        int i = 0;
        string result = String.Empty;
        while (i < count)
        {
            result = result + text;
            i++;
        }
        return result;
    } 
    string res = Method4(2, " 3:Text");
    Console.WriteLine(res);
```

# Lesson_14

```cs
    // 1
    string Method4(int count, string text)
    {
        
        string result = String.Empty;
        for(int i = 0; i < count; i++)
        {
            result = result + text;
        }
        return result;
    } 
    string res = Method4(2, " 3:Text");
    Console.WriteLine(res);
    
    // 2
    for (int i = 2; i <= 10; i++)
    {
    for (int j = 2; j <= 10; j++){
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
    }

```

# Lesson_15

```cs
// Функции в программировании 
// Дан текст. В тексте нужно все пробелы заменить чертачками, 
// маленкие  буквы "к" заменить на болшую "К", ф болшую "С" 
// заменит маленькими "с"


string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
+ "ежели бы вас послали вместо нашего милого Винценгероде, "
+ "вы бы взяли приступом согласие прусского короля. "
+ "Вы так красноречивы. Вы дадите мне чаю?";

// string s  = "kepwwq"
//              012
// s[3] // r
string Replace(string text, char oldValue, char newValue)
{
      string result = String.Empty;

      int length = text.Length;
      for (int i = 0; i < length; i++)
      {
            if (text[i] == oldValue) result = result + $"{newValue}";
            else result = result + $"{text[i]}";
      }
      return result;
}
string newText = Replace(text, ' ', '|');
      Console.WriteLine(newText);
      Console.WriteLine();
      newText = Replace(newText, 'к', 'К');
      Console.WriteLine(newText);
      Console.WriteLine();
      newText = Replace(newText, 'с', 'C');
      Console.WriteLine(newText);
 // metod 1
     int[] arr ={ 1, 5, 4, 3, 2, 6, 7, 5, 1};

void PrintArray(int[] array)
{
      int count = array.Length;

      for (int i = 0; i  < count; i++)
      {
            Console.Write($"{array[i]} ");
      }
      Console.WriteLine();
}
      void  SelectionSort(int[] array)
      {
            
            for (int i = 0; i < array.Length -1; i++)
            {
                  int minPosition = i;
                  //
                  for (int j = i + 1; j < array.Length ; j++)
                  {
                        if (array[j] < array[minPosition]) minPosition = j;

                  }

                  int temporary = array[i];
                  array[i] = array[minPosition];
                  array[minPosition] = temporary;
            }
      }
      PrintArray(arr);
      SelectionSort(arr);
      PrintArray(arr); 
```

# Lesson_16

```cs
        // Массив целых чисел
        int[] intArray = new int[] 
        {
            9,
            2,
            4,
            3,
            1,
            5
        };
        // metod 2
        Console.WriteLine("Исходный массив");
        foreach(int i in intArray) 
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        // Отсортировать массив в порядке возрастания
        Console.WriteLine("Отсортированный массив в порядке возрастания");
        Array.Sort(intArray);
        foreach(int i in intArray) 
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Отсортированный массив в порядке убывания");
        // Отсортировать массив в порядке убывания
        Array.Reverse(intArray);
        foreach(int i in intArray) 
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

```

# Lesson_17

```cs
        string[,] table = new string[2, 5];
        // String.Empty 
        // calling an appeal -->  
        // table[0,0] table[0,1] table[0,2] table[0,3] table[0,4] 
        // calling an appeal -->  
        // table[1,0] table[1,1] table[1,2] table[1,3] table[1,4] 

        table[1, 2] =  "text";

        for(int rows = 0; rows < 2; rows++)
        {
                for(int columns = 0; columns < 5; columns++)
                {
                        Console.WriteLine($"\x11\n{table[rows, columns]}\t\x10");
                }
                Console.WriteLine();
        }
        
        int[,] matrix = new int[3, 4];

        for(int i = 0; i < matrix.GetLength(0); i++)
        {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                        Console.Write($" {matrix[i, j]}");
                }
                Console.WriteLine();
        }
        

        void PrintArray(int[,]matr)
        {
        for(int i = 0; i < matr.GetLength(0); i++)
        {
                for(int j = 0; j < matr.GetLength(1); j++)
                {
                        Console.Write($" {matr[i, j]}");
                }
                Console.WriteLine();
        }
               
        }
        void FillArray(int[,]matr)
        {
                for(int i = 0; i < matr.GetLength(0); i++)
                {
                        for (int j = 0; j < matr.GetLength(1); j++)
                        {
                            matr[i,j] = new Random().Next(1,10);    
                        }
                }
        } 
        PrintArray(matrix);
        
        FillArray(matrix);
        Console.WriteLine();
        PrintArray(matrix);
        

```

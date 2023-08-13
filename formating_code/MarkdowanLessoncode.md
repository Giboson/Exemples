
# Lessen_1

```C#
        Console.WriteLine("Username");
        string usernmae = Console.ReadLine();
        Console.WriteLine("Hi, ");
        Console.WriteLine(usernmae);
```

# Lesson_2

```C#
        // int number =  10,  double = number 10.5 
        double numberA = 12;
        double numberB = 5;
        Console.WriteLine(numberA / numberB);
```

# Lesson_3

```C#
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

```C#
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

```C#


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

```C#

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

```C#
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

```C#
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

```C#
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

```C#
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

```C#

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

```C#
 int numberA = new Random().Next(1, 10); // Number Random 0 do 9 
        Console.WriteLine(numberA); 
        int numberB = new Random().Next(1, 10); // Number Random 0 do 9
        Console.WriteLine(numberB); 
        // result +
        int result = numberA + numberB;
        Console.WriteLine(result);
```

# Lesson_13

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
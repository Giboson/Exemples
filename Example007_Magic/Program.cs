﻿internal class Program
{
    public static void Main(string[] args)
    {
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
    }
}
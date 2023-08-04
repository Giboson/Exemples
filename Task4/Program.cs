/**
Lesson4 
     * Задача 8: Напишите программу, которая на вход принимает число (N), 
     * а на выходе показывает все чётные числа от 1 до N.
     * 5 -> 2, 4
     * 8 -> 2, 4, 6, 8
*/
internal class Program
{
    public static void Main(string[] args)
    {
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
        }
    }
}
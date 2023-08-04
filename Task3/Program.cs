/**
Lesson 3
     * Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
     * является ли число чётным (делится ли оно на два без остатка).
     * 4 -> да
     * -3 -> нет
     * 7 -> нет
*/
internal class Program
{
    public static void Main(string[] args)
    {
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
    }
}
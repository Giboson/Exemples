// For all sources

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
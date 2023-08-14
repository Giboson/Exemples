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
        if (number < 0)
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static  void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;

        }


        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Задание 1
 Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. Если число кратно 3 (делится на 3 без 
 остатка) нужно вывести слово Fizz. Если число кратно 5
 нужно вывести слово Buzz. Если число кратно 3 и 5 нужно 
 вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно 
 вывести само число.
 Если пользователь ввел значение не в диапазоне от 1
 до 100 требуется вывести сообщение об ошибке
*/

namespace Problems
{
  public class Prob_01
  {
    private int num = 0;
    private bool ReadNumber()
    {
      Console.Write("Enter a number from 1 to 100: ");
      string temp = Console.ReadLine();
      if (temp != string.Empty)
      {
        if (int.TryParse(temp, out int tryNum) && tryNum <= 100 && tryNum >= 1)
        {
          num = tryNum;
          return true;
        }
        else
        {
          Console.WriteLine("Incorrect number!");
        }
      }
      Console.WriteLine("Number is empty!");
      return false;
    }

    private void IsNumMultOfThree()
    {
      if (num % 3 == 0)
      {
        Console.Write("Fizz ");
      }
      if (num % 5 == 0)
      {
        Console.WriteLine("Buzz");
      }
      if (num % 3 != 0 && num % 5 != 0)
      {
        Console.WriteLine(num);
      }
    }

    public void StartProblem_01()
    {
      Console.WriteLine("  ~ Problem_01 ~");
      if (this.ReadNumber())
      {
        this.IsNumMultOfThree();
      }
    }
  }
}
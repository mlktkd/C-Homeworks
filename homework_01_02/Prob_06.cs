using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Пользователь вводит с клавиатуры два числа. Нужно 
 показать все четные числа в указанном диапазоне. Если 
 границы диапазона указаны неправильно требуется произвести нормализацию границ. Например, пользователь 
 ввел 20 и 11, требуется нормализация, после которой 
 начало диапазона станет равно 11, а конец 20
 */

namespace Problems
{
  public class Prob_06
  {
    int num1 = 0;
    int num2 = 0;

    private void SetNums()
    {
      bool flag1 = false;
      bool flag2 = false;
      while (!(flag1 && flag2))
      {
        if (!flag1)
        {
          Console.Write("Enter first number: ");
        }
        else
        {
          Console.Write("Enter second number: ");
        }
        string temp = Console.ReadLine();
        if (temp != "")
        {
          if (int.TryParse(temp, out int res))
          {
            if (flag1 == false)
            {
              num1 = res;
              flag1 = true;
            }
            else if (res != num1)
            {
              num2 = res;
              flag2 = true;
            }
            else { Console.WriteLine("The numbers cannot be same!"); }
          }
          else
          {
            Console.WriteLine("Invalid value!");
          }
        }
        else
        {
          Console.WriteLine("Line is empty!");
        }
      }
    }

    private void SetCorrectLimits()
    {
      if (num1 > num2)
      {
        int temp = num1;
        num1 = num2;
        num2 = temp;
      }
    }

    private void PrintEvenNums()
    {
      for (int i = num1; i <= num2; ++i)
      {
        if (i % 2 == 0)
        {
          Console.WriteLine($"{i} ");
        }
      }
    }
    public void StartProblem_06()
    {
      Console.WriteLine("\n  ~ Problem_06 ~");
      SetNums();
      SetCorrectLimits();
      PrintEvenNums();
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Задание 3
 Пользователь вводит с клавиатуры четыре цифры. 
 Необходимо создать число, содержащее эти цифры. Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно 
 сформировать число 1578.
*/

namespace Problems
{
  public class Prob_03
  {
    private int result = 0;
    private int tempNum = 0;

    private void CalcNewNumber()
    {
      for (int i = 0; i < 4; ++i)
      {
        bool trueNum = false; 
        while (!trueNum)
        {
          Console.Write("Enter a number from 0 to 9: ");
          string temp = Console.ReadLine();
          if (temp != string.Empty)
          {
            if (int.TryParse(temp, out int tryNum) && tryNum <= 9 && tryNum >= 0)
            {
              tempNum = tryNum;
              trueNum = true;
            }
            else
            {
              Console.WriteLine("Incorrect number!");
            }
          }
          else {
            Console.WriteLine("Value is empty!");
          }
        }
        result *= 10;
        result += tempNum;
      }
    }

    public void StartProblem_03()
    {
      Console.WriteLine("\n  ~ Problem_03 ~");
      CalcNewNumber();
      Console.WriteLine($"New number is {result}");
    }
  }
}

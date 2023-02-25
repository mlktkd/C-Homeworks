using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Задание 2
 Пользователь вводит с клавиатуры два числа. Первое 
 число — это значение, второе число процент, который 
 необходимо посчитать. Например, мы ввели с клавиатуры 
 90 и 10. Требуется вывести на экран 10 процентов от 90. 
 Результат: 9.
*/

namespace Problems
{
  public class Prob_02
  {
    private int num = 0;
    private int percent = 0;
    private bool ReadNumber()
    {
      Console.Write("Enter a number: ");
      string temp = Console.ReadLine();
      if (temp != string.Empty)
      {
        if (int.TryParse(temp, out int tryNum))
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
    private bool ReadPercent()
    {
      Console.Write("Enter a percent: ");
      string temp = Console.ReadLine();
      if (temp != string.Empty)
      {
        if (int.TryParse(temp, out int tryNum) && tryNum >= 1)
        {
          percent = tryNum;
          return true;
        }
        else
        {
          Console.WriteLine("Incorrect value!");
        }
      }
      Console.WriteLine("Value is empty!");
      return false;
    }
    private float CalcPercent()
    {
      return (float)percent * num / 100;
    }
    public void StartProblem_02()
    {
      Console.WriteLine("\n  ~ Problem_02 ~");
      if (this.ReadNumber() && this.ReadPercent())
      {
        Console.WriteLine($"Percent of number = {CalcPercent()}");
      }
    }
  }
}

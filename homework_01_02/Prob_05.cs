using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Задание 6
 Пользователь вводит с клавиатуры показания температуры. В зависимости от выбора пользователя программа переводит температуру из Фаренгейта в Цельсий 
 или наоборот.
*/

namespace Problems
{
  public class Prob_05
  {
    double temperature = 0.0;

    private void SetTemperature()
    {
      bool flag = false;
      while (!flag)
      {
        Console.Write("Enter a temperature: ");
        string temp = Console.ReadLine();
        if (temp != string.Empty)
        {
          if (double.TryParse(temp, out double tryNum))
          {
            temperature = tryNum;
            flag = true;
          }
          else
          {
            Console.WriteLine("Incorrect value!");
          }
        }
        else
        {
          Console.WriteLine("Value is empty!");
        }
      }
    }
    private void ConvertToF()
    {
      temperature = ((float)temperature * 9 / 5) + 32;
    }
    private void ConvertToC()
    {
      temperature = ((float)(temperature - 32) * 5 / 9);
    }
    public void StartProblem_05()
    {
      Console.WriteLine("\n  ~ Problem_05 ~");
      SetTemperature();
      Console.WriteLine("- If you want to convert temperature to C, enter '1'");
      Console.WriteLine("- If you want to convert temperature to F, enter '2'");
      while (true) {
        Console.Write("Your choice: ");
        short choice = Convert.ToInt16(Console.ReadLine());
        if (choice == 1)
        {
          ConvertToC(); break;
        }
        if (choice == 2)
        {
          ConvertToF(); break;
        }
        Console.WriteLine("Invailed value!");
      }
      Console.WriteLine($"New temperature after convertation: {temperature}");
    }
  }
}

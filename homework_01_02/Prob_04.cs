using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Задание 4
 Пользователь вводит шестизначное число. После чего 
 пользователь вводит номера разрядов для обмена цифр. 
 Например, если пользователь ввёл один и шесть — это 
 значит, что надо обменять местами первую и шестую 
 цифры.
 Число 723895 должно превратиться в 523897.
 Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке 
*/

namespace Problems
{
  public class Prob_04
  {
    private string number = "";
    private int idx1 = 0;
    private int idx2 = 0;

    private void ReadStrNumber()
    {
      bool trueNum = false;
      while (!trueNum)
      {
        Console.Write("Enter a six-digit number: ");
        number = Console.ReadLine();
        bool contin = false;
        if (number == string.Empty) { Console.WriteLine("Number is empty!"); continue; }
        if (number.Length != 6) { Console.WriteLine("Number is not six-digit!"); continue; }
        for (int i = 0; i < 6; ++i)
        {
          if (!char.IsDigit(number[i])) {
            contin = true;
            Console.WriteLine("Number has incorrect value!");
            break;
          }
        }
        if (contin == true) { continue; }
        trueNum = true;
      }
    }
    private void ReadIndexes()
    {
      bool trueVal = false;
      while (!trueVal)
      {
        Console.Write("Enter indexes of the number: ");
        string temp = Console.ReadLine();
        if (temp != string.Empty)
        {
          if (int.TryParse(temp, out int tryNum) && tryNum >= 1 && tryNum <= 6 && tryNum != idx1)
          {
            if (idx1 == 0)
            {
              idx1 = tryNum;
            } else
            {
              idx2 = tryNum;
              trueVal = true;
            }
          }
          else
          {
            Console.WriteLine("Incorrect index!");
          }
        }
        else
        {
          Console.WriteLine("Value is empty!");
        }
      }
    }
    private void Swap()
    {
      char[] symNumbers = number.ToCharArray();
      char temp = symNumbers[idx1 - 1];
      symNumbers[idx1 - 1] = symNumbers[idx2 - 1];
      symNumbers[idx2 - 1] = temp;
      number = new string(symNumbers);
    }
    public void StartProblem_04()
    {
      Console.WriteLine("\n  ~ Problem_04 ~");
      ReadStrNumber();
      ReadIndexes();
      Swap();
      Console.WriteLine($"New number is {number}");
    }
  }
}

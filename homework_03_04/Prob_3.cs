using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 3. Написать программу, которая предлагает пользователю ввести число и считает, сколько раз это число 
 встречается в массиве.
*/

namespace homework_03_04
{
  public class Prob_3
  {
    int[] arr = new int[200];
    int num = 0;
    private void RandomFill()
    {
      Random rand = new Random();
      for (int i = 0; i < arr.Length; ++i)
      {
        arr[i] = rand.Next(0, 100);
      }
    }

    private void SetNum()
    {
      while (true)
      {
        Console.Write("Enter a number from 0 to 100: ");
        string temp = Console.ReadLine();
        if (temp != string.Empty)
        {
          if (int.TryParse(temp, out int tryNum) && tryNum >= 0 && tryNum <= 100)
          {
            num = tryNum;
            break;
          }
          else
          {
            Console.WriteLine("Incorrect number!");
          }
        }
        else
        {
          Console.WriteLine("Value is empty!");
        }
      }
    }
    private int CalcAmount()
    {
      int cnt = 0;
      int[] temp = arr;
      Array.Sort(temp);
      for (int i = 0; i < temp.Length && temp[i] <= num; ++i)
      {
        if (temp[i] == num)
        {
          cnt++;
        }
      }
      return cnt;
    }
    private void PrintArray()
    {
      foreach (int num in arr)
      {
        Console.Write($"{num} ");
      }
      Console.WriteLine("");
    }
    public void StartProb_03()
    {
      Console.WriteLine("\n  ~ Problem_03 ~");
      RandomFill();
      PrintArray();
      SetNum();
      Console.WriteLine($"Amount of the number in array: {CalcAmount()}");
    }
  }
}

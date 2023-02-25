using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 2. Преобразовать массив так, чтобы сначала шли все 
 отрицательные элементы, а потом положительные 
 (0 считать положительным)
 */

namespace homework_03_04
{
  public class Prob_2
  {
    int[] arr = new int[] { 1, 0, -3, 4, 5, 0, -7, 0, -9 };

    private void DeleteNulls()
    {
      for (int i = 0; i < arr.Length; ++i)
      {
        if (arr[i] < 0)
        {
          ShiftLeft(i);
        }
      }
    }
    private void ShiftLeft(int idx)
    {
      for (int i = idx; i > 0; --i)
      {
        if (arr[i - 1] >= 0)
        {
          int temp = arr[i - 1];
          arr[i - 1] = arr[i];
          arr[i] = temp;
        }
        else
        {
          break;
        }
      }
    }
    private void PrintArray()
    {
      foreach (int num in arr)
      {
        Console.Write($"{num} ");
      }
    }
    public void StartProb_02()
    {
      Console.WriteLine("\n  ~ Problem_02 ~");
      DeleteNulls();
      PrintArray();
      Console.WriteLine("\n");
    }
  }
}

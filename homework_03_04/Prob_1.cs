using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Сжать массив, удалив из него все 0 и, заполнить освободившиеся справа элементы значениями –1

namespace homework_03_04
{
  public class Prob_1
  {
    int[] arr = new int[] { 1,0,3,4,5,0,7,0,9};
    
    private void DeleteNulls()
    {
      for (int i = 0; i < arr.Length; ++i)
      {
        if (arr[i] == 0)
        {
          ShiftLeft(i);
        }
      }
    }
    private void ShiftLeft(int idx)
    {
      for (int i = idx; i < arr.Length - 1; ++i)
      {
        arr[i] = arr[i + 1];
      }
      arr[arr.Length - 1] = -1;
    }
    private void PrintArray()
    {
      foreach(int num in arr)
      {
        Console.Write($"{num} ");
      }
    }
    public void StartProb_01()
    {
      Console.WriteLine("\n  ~ Problem_01 ~");
      DeleteNulls();
      PrintArray();
      Console.WriteLine("\n");
    }

  }

}

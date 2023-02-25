using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 4. В двумерном массиве порядка M на N поменяйте местами заданные столбцы
 */

namespace homework_03_04
{
  public class Prob_4
  {
    int[,] arr = new int[7,10];
    int col1 = -1;
    int col2 = -1;
    private void RandomFill()
    {
      Random rand = new Random();
      for (int i = 0; i < 7; ++i)
      {
        for (int j = 0; j < 10; j++)
        {
          arr[i,j] = rand.Next(0, 20);
        }
      }
    }

    private void SetCols()
    {
      bool trueVal = false;
      while (!trueVal)
      {
        Console.Write("Enter the indexes of the array columns (from 0 to 9): ");
        string temp = Console.ReadLine();
        if (temp != string.Empty)
        {
          if (int.TryParse(temp, out int tryNum) && tryNum >= 0 && tryNum <= 9 && tryNum != col1)
          {
            if (col1 == -1)
            {
              col1 = tryNum;
            }
            else
            {
              col2 = tryNum;
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
    private void SwapColumns()
    {
      int temp = 0;
      for (int i = 0; i < 7; ++i)
      {
        temp = arr[i, col1];
        arr[i, col1] = arr[i, col2];
        arr[i, col2] = temp;
      }
    }
    private void PrintArray()
    {
      for (int i = 0; i < 7; i++)
      {
        for (int j = 0; j < 10; j++)
        {
          Console.Write(new string(String.Format("{0,4:D}", arr[i, j])));
        }
        Console.WriteLine("");
      }
    }
    public void StartProb_04()
    {
      Console.WriteLine("\n  ~ Problem_04 ~");
      RandomFill();
      Console.WriteLine("Array befor swapping:");
      PrintArray();
      SetCols();
      SwapColumns();
      Console.WriteLine("Array after swapping:");
      PrintArray();
    }
  }
}

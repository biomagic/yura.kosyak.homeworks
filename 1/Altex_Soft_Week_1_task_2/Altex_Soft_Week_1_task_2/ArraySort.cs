using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altex_Soft_Week_1_task_2
{

  class ArraySort
  {

    // One dimension massive sorting method

    public void Sorted(int n)
    {
      int[] arr = new int[n];
      Random rand = new Random();

      // Fill the array

      for (int i = 0; i <= arr.Length - 1; i++)
      {
        arr[i] = rand.Next(-500, 500);
      }

      // Array before sorting
      
      Console.WriteLine("Array before sorting");
      Console.WriteLine();

      for (int i = 0; i <= arr.Length - 1; i++)
      {
        Console.Write("{0} | ", arr[i]);
      }

      // Sort array

      Array.Sort(arr, 0, arr.Length);

      // View sorted array

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine("Array after sorting");
      Console.WriteLine();

      for (int i = 0; i <= arr.Length - 1; i++)
      {
        Console.Write("{0} | ",arr[i]);
      }
    }

    // Two dimension massive sorting method

    public void Sorted(int n, int m)
    {
      int nn = n - 1;
      int mm = m - 1; // for columns cycle
      int buf = 0;
      int[] sum = new int[m];
      int[,] arr = new int[n, m];
      Random rand = new Random();

      // Fill the array

      for (int i = 0; i <= n - 1; i++)
      {
        for (int j = 0; j <= m - 1; j++)
        {
          arr[i, j] = rand.Next(-500, 500);
        }
      }

      Console.WriteLine();
      Console.WriteLine("Massive 'arr' values before changes");
      Console.WriteLine();

      for (int i = 0; i <= nn; i++) // iterate row's loop
      {
        for (int j = 0; j <= mm; j++) // iterate column's loop 
        {
          Console.Write("{0} | ", arr[i, j]);
        }
        Console.WriteLine();
      }
      
      // Calc sum of columns

      Console.WriteLine();
      Console.WriteLine("Sum of columns");
      Console.WriteLine();

      for (int i = 0; i <= mm; i++) // iterate column's loop
      {
        for (int j = 0; j <= nn; j++) // iterate row's loop
        {
          sum[i] += arr[j, i];
        }
        Console.Write("{0} | ", sum[i]);
      }

      Console.WriteLine();

      // Sorting by sum of columns

      for (int k = sum.Length - 1; k > 0; k--)
      {
        for (int p = 0; p < k; p++)
        {
          if (sum[p] > sum[p + 1])
          {
            buf = sum[p];
            sum[p] = sum[p + 1];
            sum[p + 1] = buf;

            for (int i = 0; i < nn && i < mm; i++) // iterate row's loop
            {
              buf = arr[i, p];
              arr[i, p] = arr[i, p + 1];
              arr[i, p + 1] = buf;
            }
          }
        }
      }

      // View sorted array

      Console.WriteLine();
      Console.WriteLine("Massive 'arr' values after sort");
      Console.WriteLine();

      for (int i = 0; i <= nn; i++) // iterate row's loop
      {
        for (int j = 0; j <= mm; j++) // iterate column's loop
        {
          Console.Write("{0} | ", arr[i, j]);
        }
        Console.WriteLine();
      }

      Console.WriteLine();
      Console.WriteLine("Sum of columns");
      Console.WriteLine();

      for (int i = 0; i <= sum.Length - 1; i++)
      {
        Console.Write("{0} | ", sum[i]);
      }
    }
  }
}

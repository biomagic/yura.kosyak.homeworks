using System;

namespace Altex_Soft_CS_HW
{
  internal class ArraySort
  {
    // One dimension massive process

    public void Sorted(int n)
    {
      var arr = new int[n];

      Fill(arr);

      // Array before sorting

      Display(arr);

      // Sort array

      Array.Sort(arr, 0, arr.Length);

      // View sorted array

      Console.WriteLine();
      WriteMessage("Array after sorting");

      Display(arr);
    }

    // Two dimension massive process

    public void Sorted(int n, int m)
    {
      var nn = n - 1;
      var mm = m - 1; // for columns cycle
      var sum = new int[m];
      var arr = new int[n, m];

      Fill(arr, nn, mm);

      // Arr before sorting

      Display(arr, nn, mm);

      // Calc sum of columns

      WriteMessage("Sum of columns");

      for (var i = 0; i <= mm; i++) // iterate column's loop
      {
        for (var j = 0; j <= nn; j++) // iterate row's loop
          sum[i] += arr[j, i];
            Console.Write("{0} | ", sum[i]);
      }

      Console.WriteLine();

      // Sorting by sum of columns

      Sort(sum, arr, nn, mm);

      // View sorted array

      WriteMessage("Massive values after sort");

      Display(arr, nn, mm);

      WriteMessage("Sum of columns");

      Display(sum);
    }

    // One dimension massive fillig

    private static void Fill(int[] arr)
    {
      var rand = new Random();

      // Fill the array

      for (var i = 0; i <= arr.Length - 1; i++)
        arr[i] = rand.Next(-500, 500);

      Console.WriteLine();
      Console.WriteLine("Massive filled");
      Console.WriteLine();

    }

    // Two dimension massive fillig

    private static void Fill(int[,] arr, int nn, int mm)
    {
      var rand = new Random();

      // Fill the array

      for (var i = 0; i <= nn; i++)
        for (var j = 0; j <= mm; j++)
          arr[i, j] = rand.Next(-500, 500);

      Console.WriteLine();
      Console.WriteLine("Massive filled");
      Console.WriteLine();
    }

    // One dimension massive display

    private static void Display(int[] arr)
    {
      for (var i = 0; i <= arr.Length - 1; i++)
        Console.Write("{0} | ", arr[i]);
    }

    // Two dimension massive fillig

    private static void Display(int[,] arr, int nn, int mm)
    {
      for (var i = 0; i <= nn; i++) // iterate row's loop
      {
        for (var j = 0; j <= mm; j++) // iterate column's loop 
        {
          Console.Write("{0} | ", arr[i, j]);
        }
        Console.WriteLine();
      }
    }

    // Massive sorting

    private static void Sort(int[] sum, int[,] arr, int nn, int mm)
    {
      try
      {
        for (var k = sum.Length - 1; k > 0; k--)
          for (var p = 0; p < k; p++)
            if (sum[p] > sum[p + 1])
            {
              var buf = sum[p];
              sum[p] = sum[p + 1];
              sum[p + 1] = buf;

              for (var i = 0; (i <= nn) && (i <= mm); i++) // iterate row's loop
              {
                buf = arr[i, p];
                arr[i, p] = arr[i, p + 1];
                arr[i, p + 1] = buf;
              }
            }
      }
      catch (Exception ex)
      {
        Console.WriteLine("You have some exception while sum array: {0}", ex);
      }
    }
    
    // Write message

    private static void WriteMessage(string msg)
    {
      Console.WriteLine();
      Console.WriteLine(msg);
      Console.WriteLine();
    }
  }
}


using System;

namespace Altex_Soft_CS_HW
{
  internal class Program
  {
    private static void Main()
    {

      // Task 2.2 (Students sort)

      var studSort = new Students();

      // Task 2.3, 2.4 (Array sort)

      var aSort = new ArraySort();

      aSort.Sorted(3, 4);

      Console.ReadLine();
    }
  }
}

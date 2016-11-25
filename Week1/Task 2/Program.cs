using System;

namespace Task_2
{
  class Program
  {
    static void Main()
    {
      // Task 2.3, 2.4 (Array sort)

      var aSort = new ArraySort();

      aSort.Sorted(2);

      aSort.Sorted(2, 10);

      Console.ReadLine();

      // Task 2.2 (Students sort)

      StudentsSort stud = new StudentsSort();

      stud.Fill(2);

      Console.ReadLine();
    }
  }
}

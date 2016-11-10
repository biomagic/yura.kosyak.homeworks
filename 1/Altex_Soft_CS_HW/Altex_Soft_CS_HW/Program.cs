using System;

namespace Altex_Soft_CS_HW
{
  internal class Program
  {
    private static void Main()
    {

      // Task 2.2 (Students sort)

      StudentsSort stud = new StudentsSort();

      //stud.Fill(2);

      // Task 2.3, 2.4 (Array sort)

      var aSort = new ArraySort();

      //aSort.Sorted(3, 4);

      //Console.ReadLine();

      // Task 3.1

      TextFormat textClass = new TextFormat();
      textClass.Text();

      // Task 4

      SomeObjects pl = new SomeObjects();

      pl.Run();

      Console.ReadLine();

    }
  }
}

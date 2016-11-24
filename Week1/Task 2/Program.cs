using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
  class Program
  {
    static void Main(string[] args)
    {
      // Task 2.2 (Students sort)

      StudentsSort stud = new StudentsSort();

      stud.Fill(5);

      Console.ReadLine();

      // Task 2.3, 2.4 (Array sort)

      var aSort = new ArraySort();

      aSort.Sorted(5);

      aSort.Sorted(2, 10);

      Console.ReadLine();
    }
  }
}

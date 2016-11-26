using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
  class Program
  {

    //private static void DisplayArray(Comparator[] persons)
    //{
    //  Console.ForegroundColor = ConsoleColor.Green;
    //  Console.WriteLine("{0,-20} {1,-15} {2,10}", "FirstName", "LastName", "Age");
    //  Console.ForegroundColor = ConsoleColor.White;
    //  foreach (var city in persons)
    //    Console.WriteLine("{0,-20} {1,-15} {2,10:N0}", city.FirstName,
    //                      city.LastName, city.Age);

    //  Console.WriteLine();
    //}

    static void Main()
    {

      // Task 13.1 Extension interface 

      List<int> list = new List<int> {5, 8, 13, 2, 3};
      int[] array = {34, 24, 58};

      foreach (var item in list.Sorting())
      {
        Console.WriteLine(item);
      }
      foreach (var item in array.Sorting())
      {
        Console.WriteLine(item);
      }

      // 13.2 Sort with delegate




      //Comparator p1 = new Comparator("FirstName one", "cLname", 19);
      //Comparator p2 = new Comparator("FirstName two", "bLname", 20);
      //Comparator p3 = new Comparator("FirstName three", "aLname", 25);

      //Comparator[] persons = { p3, p1, p2 };
      //// Display ordered array.
      //DisplayArray(persons);

      //// Sort by name.
      //Array.Sort(persons, Comparator.CompareByName);
      //DisplayArray(persons);

      //// Sort by age.
      //Array.Sort(persons, Comparator.CompareByAge);
      //DisplayArray(persons);

      //// Sort by last name.
      //Array.Sort(persons, Comparator.CompareByLastName);
      //DisplayArray(persons);

      Console.ReadKey();
    }
  }

  

}

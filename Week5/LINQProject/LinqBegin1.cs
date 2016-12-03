using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProject
{
  // Дана целочисленная последовательность, содержащая как положительные, так и отрицательные числа.
  // Вывести ее первый положительный элемент и последний отрицательный элемент. 
   
  class LinqBegin1
  {
    private static int[] numbers = { -7, -3, -10, 0, 2, 7, 5, 10, 9, 8 };

    public static void Result()
    {
      Console.WriteLine("First positive element: {0}, Last negative elemnt {1}", numbers.First(n => n > 0), numbers.Last(n => n < 0));
    }
  }
}

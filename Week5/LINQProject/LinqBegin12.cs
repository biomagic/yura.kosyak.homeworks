using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProject
{
  class LinqBegin12
  {
    // Дана целочисленная последовательность.Иcпользуя метод Aggregate, найти произведение последних
    // цифр всех элементов последовательности.Чтобы избежать целочисленного переполнения, при вычислении 
    // произведения использовать вещественный числовой тип.

    private static int[] numbers = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };

    public static void Result()
    {
      Console.WriteLine(numbers.Aggregate((sum, next) => sum * (next % 10)));
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProject
{
  class LinqBegin15
  {
    // Дано целое число N (0 ≤ N ≤ 15). Используя методы Range и Aggregate, 
    // найти факториал числа N: N! = 1·2·…·N при N ≥ 1; 0! = 1. 
    // Чтобы избежать целочисленного переполнения, при вычислении факториала 
    // использовать вещественный числовой тип. 
    private static int N = 5;

    public static void Result()
    {
      var numbers = Enumerable.Range(1, N).Aggregate((sum, next) => sum * next);

      Console.WriteLine(numbers);
      
    }
  }
}

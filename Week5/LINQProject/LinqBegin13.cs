using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProject
{
  class LinqBegin13
  {
    // Дано целое число N(> 0). Используя методы
    // Range и Sum, найти сумму 1 + (1/2) + … + (1/N) (как вещественное число). 
    private static int N = 5;

    public static void Result()
    {
      var numbers = Enumerable.Range(2, N - 1).Select(n => 1 / (double)n).Sum() + 1;
      Console.WriteLine(numbers);
    }
  }
}

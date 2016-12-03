using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProject
{
  class LinqBegin7
  {
    // Дана целочисленная последовательность.Найти количество ее отрицательных элементов, а также их сумму.
    // Если отрицательные элементы отсутствуют, то дважды вывести 0. 

    private static int[] fibo = {-3, -2, -1, -1, 0, 1, 1, 2, 3, 5, 8, 13, 21, 34};

    public static void Result()
    {
      int counter = 0;
      counter += fibo.Sum(n => n < 0 ? n : 0);
      
      Console.WriteLine("Negative elements count & sum: {0}, {1}", fibo.Count(n => n < 0) <= 0 ? 0 : fibo.Count(n => n < 0), counter); // Второй 0 будет в counter, потому 0 будет выведет 2 раза как по условию. 
                                                                                                                                       // Правильно ли таким образом решить задачу?

    }
  }
}
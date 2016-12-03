using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LINQProject
{
  class LinqBegin2
  {
      // Дана цифра D(однозначное целое число) и целочисленная последовательность A.
      // Вывести первый положительный элемент последовательности A, оканчивающийся
      // цифрой D.Если требуемых элементов в последовательности A нет, то вывести 0. 

      private static int[] A = { -7, -3, -10, 0, 72, 57, 7, 5, 10, 9, 37 , 8 }; // A
      private static int D = 7; // D

      public static void Result()
      {
          Console.WriteLine("First positive element A that finishes number D: {0}", A.First(n => n % 10 == D));
      }
  }
}

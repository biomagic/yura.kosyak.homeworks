using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProject
{
  class LinqBegin6
  {

    // Дана строковая последовательность.
    // Найти сумму длин всех строк, входящих в данную последовательность.

    private static string quickFoxString = "The quick brown xfox 5jumps 5over the x5lazyx dog";

    public static void Result()
    {
      int counter = 0;
      counter += quickFoxString.Split(' ').Sum(n => n.Length);
      Console.WriteLine("string: {0}", counter);
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProject
{
  class LinqBegin5
  {
    // Дан символ С и строковая последовательность A.Найти количество элементов A, которые содержат более
    // одного символа и при этом начинаются и оканчиваются символом C.

    private static char C = 'x'; // L
    private static string A = "The quick brown xfox 5jumps 5over the x5lazyx dog";

    public static void Result()
    {
      Console.WriteLine("string: {0}", A.Split(' ').Count(n => n.LastIndexOf(C) == n.Length - 1 && n[0] == C && n.Length > 1));
    }
  }
}

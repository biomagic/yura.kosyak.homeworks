using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProject
{
  class LinqBegin4
  {
    // Дан символ С и строковая последовательность A.Если A содержит единственный элемент, оканчивающийся
    // символом C, то вывести этот элемент; если требуемых строк в A нет, то вывести пустую строку; если требуемых строк
    // больше одной, то вывести строку «Error». Указание.Использовать try-блок для перехвата возможного исключения.

    private static char C = 'x'; // L
    private static string A = "The quick brown fox 5jumps 5over the 5lazy dog";

    public static void Result()
    {
      try
      {
        Console.WriteLine("string: {0}",
          A.Split(' ')
            .SingleOrDefault(n => n.LastIndexOf(C) == n.Length - 1 && n.Single(x => x == C) == C) ?? " ");
      }
      catch (Exception e)
      {
        
        Console.WriteLine(@"Error: {0}", e.Message); // Почему выводит знаки вопроса ???
      }
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProject
{
  class LinqBegin3
  {
    //  Дано целое число L(> 0) и строковая последова тельность A.Вывести последнюю строку из A, начинающуюся
    //  с цифры и имеющую длину L.Если требуемых строк в последовательности A нет, то вывести строку «Not found».
    //  Указание.Для обработки ситуации, связанной с отсутствием требуемых строк, использовать операцию ??. 

    private static int L = 5; // L
    private static string A = "The quick brown fox 5jumps 5over the 5lazy dog";

    public static void Result()
    {
      Console.WriteLine("Last string since L > 0 and length = L: {0}", 
        A.Split(' ')
        .LastOrDefault(n => n[0].ToString() == L.ToString() && n.Length == L) ?? "NotFound" );
    }


  }
}

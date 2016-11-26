using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
  class Program
  {
    static void Main()
    {
      List<Library> diskList = new List<Library>();
      List<Library> songList = new List<Library>();

      // Add disks, songs to collection

      Library.Filling(diskList, 5);
      Library.Filling(songList, 10);

      // Show disks, songs

      Library.Display(diskList);
      Library.Display(songList);

      Console.ReadKey();
    }
  }
}

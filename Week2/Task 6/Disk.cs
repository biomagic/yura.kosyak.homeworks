using System;
using System.Collections.Generic;
namespace Task_6
{
  class Library
  {
    public string itemName;
    public string composer;

    public static void Display(List<Library> lib)
    {
      Console.ForegroundColor = ConsoleColor.Cyan;
      foreach (var item in lib)
      {
        Console.WriteLine("{0}, {1}", item.itemName, item.composer);
      }
      Console.WriteLine();
    }

    public static void Filling(List<Library>lib, int n)
    {
      for (int i = 1; i <= n; i++)
      {
        if (lib.GetType() == typeof(Disk))
        {
          lib.Add(new Disk {itemName = "Some disk " + i, composer = "Composer " + i});
        }
        lib.Add(new Song { itemName = "Some song " + i, composer = "Composer " + i });
      }
    }
  }
  class Disk : Library
  {

  } 
  class Song : Library
  {
    
  }
}

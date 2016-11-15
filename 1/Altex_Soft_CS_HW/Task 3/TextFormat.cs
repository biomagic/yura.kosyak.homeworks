using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Task_3
{
  internal class TextFormat
  {
    public void Text()
    {
      var text = File.ReadAllText(@"D:\AltexSoft\hw\altex_soft_31.txt");
      var pattern = @"-?[0-9]+(,|.)[0-9]+";

      Console.WriteLine(Display(text));

      // Task 3.1  

      Format(text, pattern);

      // Task 3.2

      Squaring();
    }
    private string Display(string str)
    {
      return "\n-----------------\n" + str;
    }
    private void Format(string text, string pattern)
    {
      double sum = 0;

      // Format string and display each match

      foreach (Match matches in Regex.Matches(text, pattern, RegexOptions.IgnoreCase))
      {
        sum += Convert.ToSingle(matches.Value.Replace(".", ","));
        Console.WriteLine(Display(matches.Value));
      }

      Console.WriteLine(Display("\n" + sum));
    }
    private void Squaring()
    {
      string path = @"D:\AltexSoft\hw\altex_soft_task32.txt";
      string pattern = @"[0-9]+";
      string values = "1 2 3 4 5 6 7 8 9 10";
      string temp = "";
      
      // Create the file.

      if (File.Exists(path))
      {
        File.Delete(path);
      }
      using (FileStream fs = File.Create(path))
      {
        Byte[] info = new UTF8Encoding(true).GetBytes(values);
        // Add some information to the file.

        fs.Write(info, 0, info.Length);

        foreach (Match matches in Regex.Matches(values, pattern, RegexOptions.IgnoreCase))
        {
          temp += int.Parse(matches.Value) * int.Parse(matches.Value) + " ";
        }
      }

      Console.WriteLine(Display("\nFile Before:\n\n" + File.ReadAllText(path)));

      File.WriteAllText(path, temp, Encoding.UTF8);
      
      Console.WriteLine(Display("\nFile after:\n\n" + File.ReadAllText(path)));


      // Показать список каталогов

      DirectoryInfo dir = new DirectoryInfo(@"D:\AltexSoft\hw\");
      Console.WriteLine(Display("\n++++++++++++ Folders list ++++++++++++\n"));
      foreach (var item in dir.GetDirectories())
      {
        Console.WriteLine(item.Name);
        Console.WriteLine("\n++ Subfolders list ++\n");
        foreach (var subItem in item.GetDirectories())
          Console.WriteLine(subItem.Name);
        Console.WriteLine();
      }
      Console.WriteLine(Display("\n++++++++++++ Files list ++++++++++++\n"));
      foreach (var item in dir.GetFiles())
      {
        Console.WriteLine(item.Name);
      }
    }
  }
}

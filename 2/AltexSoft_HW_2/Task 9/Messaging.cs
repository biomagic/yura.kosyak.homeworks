using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_10
{
  class Observer
  {
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    public static void Run()
    {
      string[] args = System.Environment.GetCommandLineArgs();
      
      // If a directory is not specified, exit program.
      if (args.Length < 2)
      {
        // Display the proper way to call the program.
        Console.WriteLine("Usage: Program.exe (directory) (Extension of file. Example: txt)[Optionaly]");
        
        return;
      }
      
      // Create a new FileSystemWatcher and set its properties.
      FileSystemWatcher watcher = new FileSystemWatcher();
      watcher.Path = args[1];
      /* Watch for changes in LastAccess and LastWrite times, and
         the renaming of files or directories. */
      watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
         | NotifyFilters.FileName | NotifyFilters.DirectoryName;
      // Use file format if it set. Else watch all files.

      watcher.Filter = args.Length == 3 ? "*." + args[2] : "*";
      

      // Add event handlers.
      watcher.Changed += new FileSystemEventHandler(OnChanged);
      watcher.Created += new FileSystemEventHandler(OnChanged);
      watcher.Deleted += new FileSystemEventHandler(OnChanged);
      watcher.Renamed += new RenamedEventHandler(OnRenamed);
      
      // Begin watching.
      watcher.EnableRaisingEvents = true;
      
      // Wait for the user to quit the program.
      Console.WriteLine("Press \'q\' to quit the sample.");
      while (Console.Read() != 'q')
      {
      }
    }

    // Define the event handlers.
    private static void OnChanged(object source, FileSystemEventArgs e)
    {
      string pattern = e.Name + "$";
      string path = Regex.Replace(e.FullPath, pattern, String.Empty);
      if (!Directory.Exists(path + "obsLog"))
      {
        Directory.CreateDirectory(path + "obsLog");
      }
      using (StreamWriter file = new StreamWriter(path + @"obsLog\Observer_log.txt", true))
      {
        file.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
      }
       //Specify what is done when a file is changed, created, or deleted.
      Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
    }

    private static void OnRenamed(object source, RenamedEventArgs e)
    {
      string pattern = e.Name + "$";
      string path = Regex.Replace(e.FullPath, pattern, String.Empty);
      if (!Directory.Exists(path + "obsLog"))
      {
        Directory.CreateDirectory(path + "obsLog");
      }
      using (StreamWriter file = new StreamWriter(path + @"obsLog\Observer_log.txt", true))
      {
        file.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
      }
      // Specify what is done when a file is renamed.
      Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
      
    }
  }

}

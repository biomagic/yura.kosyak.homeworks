using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
  class ManagedClass
  {
    public ManagedClass()
    {
      Console.WriteLine("ManagedClass created. Task 6.1");
    }
  }

  class UnmanagedClass : ManagedClass
  {
    public UnmanagedClass()
    {
      Console.WriteLine("\nUnmanagedClass created. Task 6.1");
      string str = "Some string";
      IntPtr stringPointer = (IntPtr) Marshal.StringToHGlobalAnsi(str);
      Console.WriteLine("\nUnmanaged ptr in UnmanagedClass " + stringPointer);
    }

    ~UnmanagedClass()
    {
     Console.WriteLine("\nFinalize UnmanagedClass. Task 6.1");
      Console.ReadLine();
    }
  }
}

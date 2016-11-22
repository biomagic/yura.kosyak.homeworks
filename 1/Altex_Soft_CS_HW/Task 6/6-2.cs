using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
  class UnmanagedResources
  {
    public UnmanagedResources()
    {
      Console.WriteLine("\nUnmanagedResources base class created. Task 6.2");
      string str = "Some string";
      IntPtr stringPointer = (IntPtr)Marshal.StringToHGlobalAnsi(str);
      Console.WriteLine("\nUnmanaged ptr in UnmanagedResources " + stringPointer);
    }
    ~UnmanagedResources()
    {
      Console.WriteLine("\nFinalize UnmanagedResources base class. Task 6.2");
    }
  }

  class ManagedResources : UnmanagedResources
  {
    public ManagedResources()
    {
      Console.WriteLine("\nManagedResources derived class. Task 6.2");
      string str = "Some string";
      IntPtr stringPointer = (IntPtr)Marshal.StringToHGlobalAnsi(str);
      Console.WriteLine("\nUnmanaged ptr in ManagedResources " + stringPointer);
    }

    ~ManagedResources()
    {
      Console.WriteLine("\nFinalize ManagedResources derived class. Task 6.2");
    }
  }
}

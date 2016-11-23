using System;
using System.Security.Cryptography.X509Certificates;

namespace Task_11
{
  internal class Program
  {
    static double d;

    static void Main()
    {
      
      Complex complexItem  = new Complex();
      Complex comlexItem2 = new Complex();

      // Operator == testing

      if(complexItem == comlexItem2)
        Console.WriteLine("Items is equal");

      // Operator != testing

      complexItem = new Complex(1);

      if (complexItem != comlexItem2)
        Console.WriteLine("Items is not equal");

      // Convert double to Complex

      d = 10.7;

      Complex cDouble = d;

      Console.WriteLine("Type of variable: " + d.GetType() + "\nValue: " + d + "\nObject type: " + cDouble.GetType() + "\nConverted:\nX: " + cDouble.X +  "\nY: " + cDouble.Y + "\nZ: " + cDouble.Z);

      Console.ReadLine();
    }
  }
}

using System;
using System.Runtime.InteropServices;

namespace Task_11
{
  
  public struct Complex
  {
    public int X { get; }

    public int Y { get; }

    public int Z { get; }

    public Complex(int x = 0, int y = 0, int z = 0)
    {
      X = x;
      Y = y;
      Z = z;
    }

    // Overloading operator ==

    public static bool operator ==(Complex com1, Complex com2)
    {
      if ((com1.X == com2.X) && (com1.Y == com2.Y) && (com1.Z == com2.Z))
        return true;
      return false;
    }

    // Overloading operator !=

    public static bool operator !=(Complex com1, Complex com2)
    {
      if ((com1.X != com2.X) || (com1.Y != com2.Y) || (com1.Z != com2.Z))
        return true;
      return false;
    }

    public static implicit operator Complex(double d)
    {
      int converted = Convert.ToInt32(d);
      return new Complex(converted, converted, converted);
    }

    // Methods realise

    public override string ToString()
    {
      return base.ToString() + "10";
    }

    public override bool Equals(object obj)
    {
      return base.Equals(obj);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }
  }
}

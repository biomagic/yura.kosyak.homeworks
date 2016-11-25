using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.String;

namespace Task_13
{
  public static class EnumerableExtension
  {
    public static IEnumerable<T> Sorting<T>(this IEnumerable<T> source)
    {
      if (source.GetType() == typeof(List<T>))
      {
        List<T> list = new List<T>(source);
        list.Sort();
        Console.WriteLine("\nList sorted\n");
        return list;
      }
      Array.Sort(source.ToArray());
      Console.WriteLine("\nArray sorted\n");
      return source;
    }
  }


  //public class Comparator
  //{
  //  string _firstName;
  //  string _lastName;
  //  int _age;

  //  public Comparator(string firstName, string lastName, int age)
  //  {
  //    _firstName = firstName;
  //    _lastName = lastName;
  //    _age = age;
  //  }

  //  public string FirstName
  //  { get { return _firstName; } }
  //  public string LastName
  //  { get { return _lastName; } }
  //  public int Age
  //  { get { return _age; } }

  //  public static int CompareByName(Comparator c1, Comparator c2)
  //  {
  //    return CompareOrdinal(c1.FirstName, c2.FirstName);
  //  }
  //  public static int CompareByAge(Comparator c1, Comparator c2)
  //  {
  //    return c1.Age.CompareTo(c2.Age);
  //  }
  //  public static int CompareByLastName(Comparator c1, Comparator c2)
  //  {
  //    return Compare(c1.LastName + c1.FirstName, c2.LastName + c2.FirstName);
  //  }
  //}
}

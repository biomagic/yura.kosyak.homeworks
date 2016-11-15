using System;
using System.Collections.Generic;

namespace Task_4
{
  internal class SomeObjects
  {
    public void Run()
    {
      var studList = new List<ObjectItem>
      {
        new ObjectItem
        {
          FirstName = "Andrey",
          LastName = "Shegulin",
          MiddleName = "Viktorovich",
          Address = "Vorovskogo street 10-34",
          Birth = new DateTime(1985, 10, 22, 0, 0, 0),
          School = School.School30
        },
        new ObjectItem
        {
          FirstName = "Nikolay",
          LastName = "Makedonskiy",
          MiddleName = "Andreevich",
          Address = "Pushkina boulevard 17",
          Birth = new DateTime(1990, 7, 9, 0, 0, 0),
          School = School.School28
        },
        new ObjectItem
        {
          FirstName = "Vasiliy",
          LastName = "Merenov",
          MiddleName = "Nikolaevich",
          Address = "Pobedy street 38",
          Birth = new DateTime(1991, 1, 12, 0, 0, 0),
          School = School.School10
        },
        new ObjectItem
        {
          FirstName = "Maksim",
          LastName = "Zaycev",
          MiddleName = "Viktorovich",
          Address = "Shevchenka street 27",
          Birth = new DateTime(1982, 2, 10, 0, 0, 0),
          School = School.School30
        }
      };

      // 4.2 list

      var Performance = new List<ObjectItem>
      {
        new ObjectItem
        {
          FirstName = "Andrey",
          LastName = "Shegulin",
          MiddleName = "Viktorovich",
          Group = Group.ks16_2,
          Result = true
        },
        new ObjectItem
        {
          FirstName = "Nikolay",
          LastName = "Makedonskiy",
          MiddleName = "Andreevich",
          Address = "Pushkina boulevard 17",
          Group = Group.ks16_3,
          Result = true
        },
        new ObjectItem
        {
          FirstName = "Vasiliy",
          LastName = "Merenov",
          MiddleName = "Nikolaevich",
          Address = "Pobedy street 38",
          Group = Group.ks16_1,
          Result = true
        },
        new ObjectItem
        {
          FirstName = "Maksim",
          LastName = "Zaycev",
          MiddleName = "Viktorovich",
          Address = "Shevchenka street 27",
          Group = Group.ks16_2,
          Result = false
        }
      };

      // 4.3 List

      var AccSystem = new List<ObjectItem>
      {
        new ObjectItem
        {
          FirstName = "Andrey",
          LastName = "Shegulin",
          MiddleName = "Viktorovich",
          Things = 5,
          Weight = 3.2 
        },
        new ObjectItem
        {
          FirstName = "Nikolay",
          LastName = "Makedonskiy",
          MiddleName = "Andreevich",
          Things = 10,
          Weight = 9.7
        },
        new ObjectItem
        {
          FirstName = "Vasiliy",
          LastName = "Merenov",
          MiddleName = "Nikolaevich",
          Things = 12,
          Weight = 5.3
        },
        new ObjectItem
        {
          FirstName = "Maksim",
          LastName = "Zaycev",
          MiddleName = "Viktorovich",
          Things = 4,
          Weight = 20.1
        }
      };

      var AutoList = new List<ObjectItem>
      {
        new ObjectItem
        {
          Auto = Auto.BMW,
          Number = 1278,
          LastName = "Shegulin",
          AutoYear = new DateTime(1998, 1, 1),
          Mileage = 450000.5
        },
        new ObjectItem
        {
          Auto = Auto.Jaguar,
          Number = 1111,
          LastName = "Makedonskiy",
          AutoYear = new DateTime(2016, 1, 1),
          Mileage = 100000.0
        },
        new ObjectItem
        {
          Auto = Auto.Mercedes,
          Number = 2287,
          LastName = "Merenov",
          AutoYear = new DateTime(1999, 1, 1),
          Mileage = 382502.7
        },
        new ObjectItem
        {
          Auto = Auto.Toyota,
          Number = 7154,
          LastName = "Zaycev",
          AutoYear = new DateTime(2005, 1, 1),
          Mileage = 778920.1
        }
      };

      // 4.1 Sorting

      Display(studList, School.School30); // Before
      studList.Sort();
      Console.WriteLine("\nSorting...\n");
      Display(studList, School.School30); // After

      // 4.2 Sorting

      Display(Performance); // Before
      Performance.Sort();
      Console.WriteLine("\nSorting...\n");
      Display(Performance); // After

      // 4.3 Sorting

      Display(AccSystem, 7); // Before
      AccSystem.Sort();
      Console.WriteLine("\nSorting...\n");
      Display(AccSystem, 7); // After

      // 4.4 Sorting

      Display(AutoList, new DateTime(2000, 1, 1)); // Before
      AutoList.Sort();
      Console.WriteLine("\nSorting...\n");
      Display(AutoList, new DateTime(2000, 1, 1)); // After
    }

    void Display(List<ObjectItem> obj, School sc)
    {
      foreach (ObjectItem t in obj)
        if (t.School == sc)
        {
          Console.WriteLine("\nName: {0} , LastName{1}, Middle Name: {2}, Birth: {3:d}\n", t.FirstName, t.LastName, t.MiddleName, t.Birth);
        }
      Console.WriteLine("\n------------------\n");
    }
    void Display(List<ObjectItem> obj)
    {
      foreach (ObjectItem t in obj)
        if (t.Result)
        {
          Console.WriteLine("\nName: {0} , LastName{1}, Middle Name: {2}, Group: {3}\n", t.FirstName, t.LastName, t.MiddleName, t.Group);
        }
      Console.WriteLine("\n------------------\n");
    }
    void Display(List<ObjectItem> obj, double limit)
    {
      foreach (ObjectItem t in obj)
        if (t.Weight > limit)
        {
          Console.WriteLine("\nName: {0} , LastName{1}, Middle Name: {2}, Things count: {3}\n", t.FirstName, t.LastName, t.MiddleName, t.Things);
        }
      Console.WriteLine("\n------------------\n");
    }
    void Display(List<ObjectItem> obj, DateTime date)
    {
      foreach (ObjectItem t in obj)
        if (t.AutoYear < date)
        {
          Console.WriteLine("\nAuto: {0} , Year: {1:yyyy}, Mileage: {2}, Number: {3}\n", t.Auto, t.AutoYear, t.Mileage, t.Number);
        }
      Console.WriteLine("\n------------------\n");
    }

  }

  internal class ObjectItem : IComparable<ObjectItem>
  {
    public int CompareTo(ObjectItem obj)
    {
      if (Mileage > obj.Mileage || Things > obj.Things || Group > obj.Group || Birth > obj.Birth)
        return 1;
      if (Mileage < obj.Mileage || Things < obj.Things || Group < obj.Group || Birth < obj.Birth)
        return -1;
      return 0;
    }

    public ObjectItem(){}

    // 4.1 constructor

    public ObjectItem(string firstName, string lastName, string middleName, DateTime birth, string address, School school) 
    {
      FirstName = firstName;
      LastName = lastName;
      MiddleName = middleName;
      Birth = birth;
      Address = address;
      School = school;
    }

    // 4.2 constructor

    public ObjectItem(string firstName, string lastName, string middleName, Group group, bool result) 
    {
      FirstName = firstName;
      LastName = lastName;
      MiddleName = middleName;
      Group = group;
      Result = result;
    }

    // 4.3 constructor

    public ObjectItem(string firstName, string lastName, string middleName, int things, float weight)
    {
      FirstName = firstName;
      LastName = lastName;
      MiddleName = middleName;
      Things = things;
      Weight = weight;
    }

    // 4.4 constructor

    public ObjectItem(Auto auto, int number, string lastName, DateTime autoYear)
    {
      Auto = auto;
      Number = number;
      LastName = lastName;
      AutoYear = autoYear;
    }

    public string FirstName;
    public string LastName;
    public string MiddleName;
    // 4.1 variables
    public DateTime Birth;
    public string Address;
    public School School;
    // 4.2 variables
    public Group Group;
    public bool Result;
    // 4.3 variables
    public int Things;
    public double Weight;
    // 4.4 variables
    public Auto Auto;
    public int Number;
    public DateTime AutoYear;
    public double Mileage;
  }

  internal enum School
  {
    School30 = 4,
    School28 = 3,
    School1 = 0,
    School10 = 1,
    School25 = 2
  }

  internal enum Group
  {
    ks16_1 = 0,
    ks16_2 = 1,
    ks16_3 = 2
  }

  internal enum Auto
  {
    BMW = 0,
    Toyota = 3,
    Jaguar = 1,
    Mercedes = 2
  }
}

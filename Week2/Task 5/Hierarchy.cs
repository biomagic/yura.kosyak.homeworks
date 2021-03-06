﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Task_5
{
  public class Person : ICloneable, IPrintable, IDisposable
  {
    public string firstName;
    public string lastName;
    public int age;
    
    public Person() { }

    public Person(string firstName, string lastName, int age)
    {
      this.firstName = firstName;
      this.lastName = lastName;
      this.age = age;
    }

    // 11.1 Operators overloading

      // Overload operator ==

    public static bool operator ==(Person p1, Person p2)
    {
      if ((p1.firstName == p2.lastName) && (p1.lastName == p2.lastName) && (p1.age == p2.age))
        return true;
      return false;
    }

    // Overload operator !=

    public static bool operator !=(Person p1, Person p2)
    {
      if ((p1.firstName != p2.firstName) || (p1.lastName != p2.lastName) || (p1.age != p2.age))
        return true;
      return false;
    }

    // 12.5 Dispose

    public void Dispose()
    {
      Console.WriteLine("Person disposed...");
    }
    public virtual string Print()
    {
      return "\nPerson: \n\nName: " + firstName + ", Last name: " + lastName + ", Age: " + age + "\n";
    }
    void IPrintable.Print()
    {
      Console.WriteLine("\n!!!!!!!!!!!!!!IPrintble Person: \n\nName: " + firstName + ", Last name: " + lastName + ", Age: " + age + "\n");
    }
    public virtual object Clone()
    {
      return new Person
      {
        firstName = firstName,
        lastName = lastName,
        age = age
      };
    }
    public static Person RandomPerson(List<Person> person)
    {
      List<Person> personList = new List<Person>();
      var rand = new Random();

      foreach (var p in person)
      {
        if (p.GetType() != typeof(Teacher) && p.GetType() != typeof(Student))
        {
          IPrintable print = p;
          print.Print();
          personList.Add(p);
        }
      }
      Console.WriteLine("-------\nPersons on course: {0}\n", personList.Count);

      var personArr = personList.ToArray();

      Console.WriteLine("\nRandom person:\n");

      return personArr[rand.Next(0, personArr.Length)];
    }
    public override string ToString()
    {
      return "\nPerson's ToString\n";
    }
    public override bool Equals(object obj)
    {
      return base.Equals(obj) && obj.GetType() == typeof(Person);
    }
    public override int GetHashCode()
    {
      return base.GetHashCode() + 50;
    }
  }

  internal class Teacher : Person
  {
    public string specialty;
    
    public override string Print()
    {
      return "\nTeacher:\n\nName: " + firstName + ", Last Name: " + lastName + ", Age: " + age + ", Speciality: " +
             specialty + "\n";
    }

    public override object Clone()
    {
      return new Teacher
      {
        firstName = firstName,
        lastName = lastName,
        age = age,
        specialty = specialty
      };
    }

    public static Person RandomTeacher(List<Person> person)
    {
      List<Person> teacherList = new List<Person>();
      var rand = new Random();

      foreach (var p in person)
      {
        if (p.GetType() == typeof(Teacher))
        {
          teacherList.Add(p);
        }
        
      }
      Console.WriteLine("-------\nTeachers on course: {0}\n", teacherList.Count);

      var teacherArr = teacherList.ToArray();

      Console.WriteLine("\nRandom teacher:\n");

      return teacherArr[rand.Next(0, teacherArr.Length)];
    }

    public override string ToString()
    {
      return "\nTeacher's ToString\n";
    }

    public override bool Equals(object obj)
    {
      return base.Equals(obj) && obj != typeof(int); // Warning ?
    }

    public override int GetHashCode()
    {
      return base.GetHashCode() + 123;
    }
  }

  internal class Student : Person, IPrintable, IComparable<Student>
  {
    public Group Group;

    
    public static object SortByName { get { return SortBy.firstName; } }
    public static object SortByLName { get { return SortBy.lastName; } }
    public static object SortByAge { get { return SortBy.age; } }
    public static object SortByGroup { get { return SortBy.Group; } }

    public int CompareTo(Student obj)
    {
      if (this.Group > obj.Group)
      {
        return 1;
      } else if (this.Group < obj.Group)
      {
        return -1;
      }
      else
        return 0;
    }

    public override string Print()
    {
      return "\nStudent:\n\nName: " + firstName + ", Last Name: " + lastName + ", Age: " + age + ", Group: " + Group + "\n";
    }

    void IPrintable.Print()
    {
      Console.WriteLine("\n!!!!!!!!!!!! IPrintable Student:\n\nName: " + firstName + ", Last Name: " + lastName + ", Age: " + age + ", Group: " + Group + "\n");
    }

    public override object Clone()
    {
      return new Student
      {
        firstName = firstName,
        lastName = lastName,
        age = age,
        Group = Group
      };
    }

    public static Person RandomStudent(List<Person> person)
    {
      List<Person> studentList = new List<Person>();
      var rand = new Random();


      foreach (var p in person)
      {
        if (p.GetType() == typeof(Student))
        {
          IPrintable print = p;
          print.Print();
          studentList.Add(p);
        }
      }

      Console.WriteLine("-------\nStudents on course: {0}\n", studentList.Count);

      Console.WriteLine("\nRandom student:\n");

      var studentArr = studentList.ToArray();

      return studentArr[rand.Next(0, studentArr.Length)];
    }

    public override string ToString()
    {
      return "\n Student's ToString is working... \n";
    }

    public override bool Equals(object obj)
    {
      return base.Equals(obj) && obj != typeof(string);
    }

    public override int GetHashCode()
    {
      return Int32.MaxValue - base.GetHashCode();
    }

    public class StudentComparer : IComparer<Student>
    {
      private static SortBy _property;
      private Student[] studentList;
      public StudentComparer(Student[] sList, SortBy p)
      {
       studentList = sList;
        _property = p;
      }

      public void Method()
      {
        Console.WriteLine(" ++++++++++++++++++++++++++ HI");
      }


      public int Compare(Student x, Student y)
      {
        if (_property == SortBy.firstName && x.firstName.CompareTo(y.firstName) != 0)
        {
          return x.firstName.CompareTo(y.firstName);
        }
        if (_property == SortBy.lastName && x.lastName.CompareTo(y.lastName) != 0)
        {
          return x.lastName.CompareTo(y.lastName);
        }
        if (_property == SortBy.age && x.age.CompareTo(y.age) != 0)
        {
          return x.age.CompareTo(y.age);
        }
        if (_property == SortBy.Group && x.Group.CompareTo(y.Group) != 0)
        {
          return x.Group.CompareTo(y.Group);
        }
          return 0;
      }
    }

    public enum SortBy
    {
      firstName,
      lastName,
      age,
      Group
    }
  }

  internal enum Group
  {
    ks1 = 1,
    ks2 = 2,
    ks3 = 3,
    ks4 = 4,
    ks5 = 5
  }

  interface IPrintable
  {
    void Print();
  }

  public class PList
  {
    public List<Person> ShowList()
    {
      var personList = new List<Person>
      {
        new Person
        {
          firstName = "Person1",
          lastName = "Person1",
          age = 20
        },
        new Person
        {
          firstName = "Person2",
          lastName = "Person2",
          age = 25
        },
        new Student
        {
          firstName = "Andrey",
          lastName = "Shegulin",
          age = 20,
          Group = Group.ks1
        },
        new Student
        {
          firstName = "Nikolay",
          lastName = "Makedonskiy",
          age = 25,
          Group = Group.ks4
        },
        new Student
        {
          firstName = "Vasiliy",
          lastName = "Merenov",
          age = 21,
          Group = Group.ks3
        },
        new Student
        {
          firstName = "Maksim",
          lastName = "Zaycev",
          age = 23,
          Group = Group.ks2
        },
        new Teacher
        {
          firstName = "Viktor",
          lastName = "Nikolaevich",
          age = 45,
          specialty = "Mathemathic"
        },
        new Teacher
        {
          firstName = "Andrey",
          lastName = "Viktorovich",
          age = 48,
          specialty = "History"
        },
        new Teacher
        {
          firstName = "Olga",
          lastName = "Michaylovna",
          age = 59,
          specialty = "Programming"
        },
        new Teacher
        {
          firstName = "Oleg",
          lastName = "Viktorovich",
          age = 35,
          specialty = "Polytology"
        }
      };
      return personList;
    }
  }

}

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Task_5
{
  public class Hierarchy
  {
    public void Run()
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
          Group = Group.ks2
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
          Group = Group.ks4
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

      // View all list elements

      foreach (var p in personList)
        Console.WriteLine(p.Print());

      // Random person testing

      Console.WriteLine(Person.RandomPerson(personList).Print());
      Console.WriteLine(Teacher.RandomTeacher(personList).Print());
      Console.WriteLine(Student.RandomStudent(personList).Print());
      
      // static Massive

      object[] objList = {personList}; // Must be static

    }
  }

  internal class Person : ICloneable
  {
    public string firstName;
    public string lastName;
    public int age;
    private static Person[] personArr;

    public virtual string Print()
    {
      return "\nPerson: \n\nName: " + firstName + ", Last name: " + lastName + ", Age: " + age + "\n";
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
          personList.Add(p);
        }
        
      }
      Console.WriteLine("-------\nPersons on course: {0}\n", personList.Count);

      personArr = personList.ToArray();

      Console.WriteLine("\nRandom person:\n");

      return personArr[rand.Next(0, personArr.Length)];
    }

    public override string ToString()
    {
      return "\nPerson's ToString\n";
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

  internal class Teacher : Person
  {
    public string specialty;
    private static Person[] teacherArr;
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

      teacherArr = teacherList.ToArray();

      Console.WriteLine("\nRandom teacher:\n");

      return teacherArr[rand.Next(0, teacherArr.Length)];
    }

    public override string ToString()
    {
      return "\nTeacher's ToString\n";
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

  internal class Student : Teacher
  {
    public Group Group;
    private static Person[] studentArr;

    public override string Print()
    {
      return "\nStudent:\n\nName: " + firstName + ", Last Name: " + lastName + ", Age: " + age + ", Group: " + Group + "\n";
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
          
          studentList.Add(p);
          
        }
      }

      Console.WriteLine("-------\nStudents on course: {0}\n", studentList.Count);

      Console.WriteLine("\nRandom student:\n");

      studentArr = studentList.ToArray();

      return studentArr[rand.Next(0, studentArr.Length)];
    }

    public override string ToString()
    {
      return "\n Student's ToString is working... \n";
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

  internal enum Group
  {
    ks1 = 1,
    ks2 = 2,
    ks3 = 3,
    ks4 = 4,
    ks5 = 5
  }

}

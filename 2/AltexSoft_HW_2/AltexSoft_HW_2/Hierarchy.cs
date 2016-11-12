using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace AltexSoft_HW_2
{
  internal class Hierarchy
  {
    public static object[] ObjList;

    public void Run()
    {
      List<Person> personList = new List<Person> { 
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
        }
      };

      List<Student> studentsList = new List<Student>
      {
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
        }
      };

      List<Student> studentsList2 = new List<Student>
      {
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
        }
      };
      
      List<Teacher> teacherList = new List<Teacher>
      {
        new Teacher
        {
          firstName = "Viktor",
          lastName = "Nikolaevich",
          age = 45,
          specialty = "Mathemathic",
          studList = studentsList
        },
        new Teacher
        {
          firstName = "Andrey",
          lastName = "Viktorovich",
          age = 48,
          specialty = "History",
          studList = studentsList2
        },
        new Teacher
        {
          firstName = "Olga",
          lastName = "Michaylovna",
          age = 59,
          specialty = "Programming",
          studList = studentsList
        },
        new Teacher
        {
          firstName = "Oleg",
          lastName = "Viktorovich",
          age = 35,
          specialty = "Polytology",
          studList = studentsList2
        }
        
      };

      // ToString testing

      foreach (var p in personList)
      {
        Console.WriteLine(p);
      }
      Console.WriteLine(personList[0]);
      Console.WriteLine(teacherList[0]);
      Console.WriteLine(studentsList[0]);

      // Who is who belongs

      WhoIsWho.SView(teacherList);

      // static Massive

      ObjList = new object[] {studentsList, studentsList2, teacherList, personList};

      

      foreach (object obj in ObjList)
      {
        if (obj is List<Person>)
        {
          Console.WriteLine("\nCount of Persons: {0}", personList.Count);
          Console.WriteLine(Person.RandomPerson(personList).Print());
        }
        else if ((obj as List<Teacher>) != null)
        {
          Console.WriteLine("\nCount of Teachers: {0}", teacherList.Count) ;
          Console.WriteLine(Teacher.RandomTeacher(teacherList).Print());
        }
        else if (obj == studentsList)
        {
          Console.WriteLine("\nCount of Students: {0}", studentsList.Count);
          foreach (var student in studentsList)
          {
            student.Group++;
          }
          Console.WriteLine(Student.RandomStudent(studentsList).Print());
        }
        else if (obj.GetType() == studentsList2.GetType())
        {
          Console.WriteLine("\nCount of Students2: {0}" , studentsList2.Count);
          foreach (var student in studentsList2)
          {
            student.Group++;
          }
          Console.WriteLine(Student.RandomStudent(studentsList2).Print());
        }
      }

      
    }
  }

  internal class Person : ICloneable
  {
    public string firstName;
    public string lastName;
    public int age;

    public virtual string Print()
    {
      return "\nPersons\n\n" + " Name: " + firstName + ", Last name: " + lastName + ", Age: " + age + "\n";
    }

    public virtual object Clone()
    {
      return new Person
      {
        firstName = this.firstName,
        lastName = this.lastName,
        age = this.age
      };
    }

    public static Person RandomPerson(List<Person> p)
    {
      Random rand = new Random();

      Console.WriteLine("\nThis is a random person!\n");

      return p[rand.Next(0, p.Count)];
    }

    public override string ToString()
    {
      return "\n Person's ToString is working... \n";
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
    public List<Student> studList;

    public override string Print()
    {
      return "\nTeacher:\n\nName: " + firstName + ", Last Name: " + lastName + ", Age: " + age + ", Speciality: " + specialty + "\n";
    }

    public override object Clone()
    {
      return new Teacher
      {
        firstName = this.firstName,
        lastName = this.lastName,
        age = this.age,
        specialty = this.specialty,
        studList = this.studList
      };
    }

    public static Teacher RandomTeacher(List<Teacher> t)
    {
      Random rand = new Random();
        
      Console.WriteLine("\nThis is a random teacher!\n");

      return t[rand.Next(0, t.Count)];
    }

    public override string ToString()
    {
      return "\n Teacher's ToString is working... \n";
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

    public override string Print()
    {
      return "Name: " + firstName + ", Last Name: " + lastName + ", Age: " + age + ", Group: " + Group + "\n";
    }

    public override object Clone()
    {
      return new Student
      {
        firstName = this.firstName,
        lastName = this.lastName,
        age = this.age,
        studList = this.studList,
        Group = this.Group
      };
    }

    public static Student RandomStudent(List<Student> s)
    {
      Random rand = new Random();

      Console.WriteLine("\nThis is a random student!\n");

      return s[rand.Next(0, s.Count)];
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

  class WhoIsWho
  {
    public static List<Student> SView(List<Student> list)
    {
      return list;
    }

    public static List<Teacher> SView(List<Teacher> list)
    {
      foreach (var item in list)
      {
        Console.WriteLine("\nTeacher and students that belongs to teacher: \n");

        Console.WriteLine(item.Print());

        Console.WriteLine("\nStudents:\n");

        foreach (var student in WhoIsWho.SView(item.studList))
        {
          Console.WriteLine(student.Print());
        }
        Console.WriteLine();
      }
      return list;
    }

    public static List<Person> SView(List<Person> list)
    {
      foreach (var item in list)
      {
        Console.WriteLine(item);
      }
      return list;
    }
  }
}

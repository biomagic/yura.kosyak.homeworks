using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
  class Program
  {
    static void Main(string[] args)
    {
      PList hClass = new PList();
      
      foreach (var p in hClass.ShowList())
        Console.WriteLine(p.Print());

      // Random person testing

      Console.WriteLine(Person.RandomPerson(hClass.ShowList()).Print());
      Console.WriteLine(Teacher.RandomTeacher(hClass.ShowList()).Print());
      Console.WriteLine(Student.RandomStudent(hClass.ShowList()).Print());

      // static Massive

      object[] objList = { hClass.ShowList() }; // Must be static

      Console.WriteLine("--------------After sorting----------------");
      // 12.2
      List<Student> studentList = new List<Student>();

      foreach (var p in hClass.ShowList())
      {
        if (p.GetType() == typeof(Student))
        {
          studentList.Add((Student)p);
        }
      }

      var studentArray = studentList.ToArray();
      Array.Sort(studentArray);

      foreach (var p in studentArray)
        Console.WriteLine(p.Print());
      // 12.3
      Student s = new Student();
      Student.StudentComparer stud = new Student.StudentComparer(studentArray, Student.SortBy.Group);
      Array.Sort(studentArray, stud);

      foreach (var p in studentArray)
        Console.WriteLine(p.Print());

      // 12.4

      Student somePerson = new Student {firstName = "Test Student for cloning"};
      Student clonePerson = (Student)somePerson.Clone();
      somePerson.Group = Group.ks1;
      clonePerson.Group = Group.ks2;
      Console.WriteLine(somePerson.Print());
      Console.WriteLine(clonePerson.Print());

      // 12.5

      using (Person p = new Person())
      {
        p.firstName = "Brayan";
        Console.WriteLine(p.firstName);
      }

      // 12.6

      foreach (var person in hClass.ShowList())
      {

      }
      
      // 11.1 Operators overloading
        // Testing operator ==
      Person p1 = new Person("p1", "p1", 1);
      Person p2 = new Person("p1", "p1", 1);
      if (p1 == p2) 
        Console.WriteLine("Operator == working\n");
      // Testing operator !=

      p2.firstName = "p2";
      if (p1 != p2)
        Console.WriteLine("Operator != working\n");

      Console.ReadLine();
    }
  }
}

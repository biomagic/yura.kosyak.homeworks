using System;

namespace Task_2
{

  struct Student : IComparable
  {
    public string firstName;
    public int age;

    public void Reg()
    {
      Console.WriteLine("Name: ");
      firstName = Convert.ToString(Console.ReadLine());
      Console.WriteLine("Age: ");
      age = Convert.ToInt32(Console.ReadLine());
    }

    public int CompareTo(object obj)
    {
      Student arr = (Student)obj;

      return this.age.CompareTo(arr.age);
    }

  }

  public class StudentsSort
  {
    public void Fill(int count)
    {
      Student[] students = new Student[count];

      for (int i = 0; i < count; i++)
        students[i].Reg();
      
      Array.Sort(students);

      foreach (var stud in students)
        Console.WriteLine("First Name: {0} Age: {1}", stud.firstName,  stud.age);
    }
  }
}

using System;

namespace Task_9
{
  delegate void MyEventHandler(object source, MyEventArgs arg);

  class MyEventArgs : EventArgs
  {
    public int EventEnum;
  }

  class Messaging
  {
    private static int _count;
    private static int _count2;
    public event MyEventHandler Dialogue;
    public event MyEventHandler Provocation;
    public event MyEventHandler Fight;

    public void OnDialogue()
    {
      MyEventArgs arg = new MyEventArgs();

      if (Dialogue != null)
      {
        arg.EventEnum = _count++;
        Dialogue(this, arg);
      }
    }

    public void OnProvocation()
    {
      MyEventArgs arg = new MyEventArgs();

      if (Provocation != null)
      {
        arg.EventEnum = _count2++;
        Provocation(this, arg);
      }
    }

    public void OnFight()
    {
      if (Fight != null)
      {
        MyEventArgs arg = new MyEventArgs();

        arg.EventEnum = _count2++;
        Fight(this, arg);
      }
    }
  }

  class Person
  {
    public string Name;
    public string[] phrase;

    public void Action(object source, MyEventArgs args)
    {
      if (args.EventEnum < phrase.Length)
      {
        Console.WriteLine("\n -- " + Name + "\n");
        Console.WriteLine("\"" + phrase[args.EventEnum] + "\"");
      }
    }
  }

  class Montague : Person
  {
    public void Reaction(object source, MyEventArgs args)
    {
      if (args.EventEnum < phrase.Length)
      {
        Console.WriteLine("\n -- " + Name + "\n");
        Console.WriteLine("\"" + phrase[args.EventEnum] + "\"");
      }
    }
  }

  class Capulet : Person
  {
    public void Fighting(object source, MyEventArgs args)
    {
      Console.WriteLine("\nДерутся");
    }
  }
}

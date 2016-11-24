using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace Task_15
{
  public class Serialization
  {
    public string name;

    private readonly string lorem =
      "Lorem ipsum dolor sit amet, sed et altera delectus, iudico ocurreret at his. Vim ad discere inimicus, ei vim tation prodesset.";

    private readonly string pathSource = @"../../task15sourceText.txt";
    private readonly string binPath = @"../../task15serialized.bin";
    private readonly string soapPath = @"../../task15serialized.soap";
    private readonly string xmlPath = @"../../task15serialized.xml";

    private readonly BinaryFormatter binFormatter = new BinaryFormatter();
    private readonly SoapFormatter soapFormatter = new SoapFormatter();
    private readonly XmlSerializer xmlFormatter = new XmlSerializer(typeof(Serialization));

    private Serialization() {} // Constructor for XmlSerializer

    public Serialization(string name)
    {
      using (var fs = new FileStream(pathSource, FileMode.OpenOrCreate, FileAccess.Write))
      {
        var sw = new StreamWriter(fs) {AutoFlush = true};
        sw.Write(lorem);
      }
      this.name = name;
    }

    public void BinSerialize()
    {
      using (var fs = new FileStream(binPath, FileMode.OpenOrCreate))
      {
        var sr = new StreamReader(pathSource);
        binFormatter.Serialize(fs, sr.ReadLine());
      }
    }

    public void BinDeserialize()
    {
      using (var fs = new FileStream(binPath, FileMode.OpenOrCreate))
      {
        Console.WriteLine("\nDeserealized bin file:\n{0}\n", binFormatter.Deserialize(fs));
      }
    }

    public void SoapSerialize()
    {
      using (var fs = new FileStream(soapPath, FileMode.OpenOrCreate))
      {
        var sr = new StreamReader(pathSource);
        soapFormatter.Serialize(fs, sr.ReadLine());
      }
    }

    public void SoapDeserialize()
    {
      using (var fs = new FileStream(soapPath, FileMode.OpenOrCreate))
      {
        Console.WriteLine("\nDeserealized SOAP file:\n{0}\n", soapFormatter.Deserialize(fs));
      }
    }

    public void XmlSerialize(Serialization s)
    {
      using (var fs = new FileStream(xmlPath, FileMode.OpenOrCreate))
      {
        xmlFormatter.Serialize(fs, s);
      }
    }

    public void XmlDeserialize()
    {
      using (var fs = new FileStream(xmlPath, FileMode.OpenOrCreate))
      {
        var s = (Serialization) xmlFormatter.Deserialize(fs);
        Console.WriteLine("\nDeserealized XML file: {0}\n", s.name);
      }
    }
  }
}

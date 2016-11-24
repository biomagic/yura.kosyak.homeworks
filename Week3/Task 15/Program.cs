using System;

namespace Task_15
{
  internal class Program
  {
    private static void Main()
    {
      var sr = new Serialization("Brain");

      // Serialization

      sr.BinSerialize(); // Bin
      sr.SoapSerialize(); // SOAP
      sr.XmlSerialize(sr); // XML

      // Deserialization
      
      sr.BinDeserialize(); //Bin
      sr.SoapDeserialize(); // SOAP
      sr.XmlDeserialize(); //XML

      Console.ReadLine();
    }
  }
}

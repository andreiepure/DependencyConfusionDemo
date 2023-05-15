using System;
using Corporate.Private.Library;
using Newtonsoft.Json;

public static class Demo
{
  public static void Main(string[] args)
  {
    Console.WriteLine($"{JsonConvert.SerializeObject(new CorporateClass())}");
  }
}

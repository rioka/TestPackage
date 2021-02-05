using System;
using AutoMapper;
using Newtonsoft.Json;

namespace TestPackageConsumer
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var t = new TestPackage.Foo();
      var bar = t.Bar();
      Console.WriteLine($"Foo.Bar returned {bar}");

      var json = JsonConvert.SerializeObject(new {One = 1});
      Console.WriteLine(json);

      var mapper = new MapperConfiguration(cfg => { }).CreateMapper();
    }
  }
}

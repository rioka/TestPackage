using System;

namespace TestPackageConsumer
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var t = new TestPackage.Foo();
      t.Bar();
    }
  }
}

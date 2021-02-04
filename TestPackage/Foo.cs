using System;

namespace TestPackage
{
  public class Foo
  {
    public string Bar()
    {
      var now = DateTime.UtcNow;
      return $"baz {now}";
    }
  }
}

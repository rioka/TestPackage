using System;

namespace TestPackage
{
  /// <summary>
  /// Dumb class to test package
  /// </summary>
  public class Foo
  {
    /// <summary>
    /// Stupid method
    /// </summary>
    /// <returns>A string.</returns>
    public string Bar()
    {
      var now = DateTime.UtcNow;
      Console.WriteLine("Yeah, it's me!");
      return $"baz {now}";
    }
  }
}

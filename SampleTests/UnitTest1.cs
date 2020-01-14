using System;
using Xunit;

/// <summary>
/// https://lukewickstead.wordpress.com/2013/01/16/xunit-cheat-sheet/
/// </summary>

namespace SampleTests {
  public class UnitTest1 {
    [Fact]
    public void Test1() {
      Assert.Null(false);
    }

    [Fact]
    public void Test2() {
      Assert.Null(null);
    }
  }
}

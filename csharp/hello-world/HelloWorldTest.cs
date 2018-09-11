using Xunit;

namespace HelloWorld {
  public class HelloWorldTest {
    [Fact]
    public void Say_hi_() {
      Assert.Equal("Hello, World!", global::HelloWorld.HelloWorld.Hello());
    }
  }
}

using PrTest;
using Xunit;

namespace PrTestTests;

public class GreeterTests
{
    [Fact]
    public void GetMessage_ReturnsHelloWorld()
    {
        var greeter = new Greeter();
        Assert.Equal("Hello, World!", greeter.GetMessage());
    }

    [Fact]
    public void GetIssueMessage_ReturnsIssueMessage()
    {
        var greeter = new Greeter();
        Assert.Equal("I'm a issue1.", greeter.GetIssueMessage());
    }

    [Fact]
    public void GetIssueMessage_ReturnsIssue2Message()
    {
        var greeter = new Greeter();
        Assert.Equal("I'm a issue3.", greeter.GetIssue2Message());
    }
}

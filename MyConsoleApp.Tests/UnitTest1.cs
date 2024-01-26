using Xunit;
using MyConsoleApp;
namespace MyConsoleApp.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var expected = "Hello, World!";
        var actual = Program.GetMessage();
        Assert.Equal(expected, actual);
    }
}
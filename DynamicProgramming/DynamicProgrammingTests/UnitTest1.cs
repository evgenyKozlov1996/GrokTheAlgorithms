using DynamicProgramming;
using NuGet.Frameworks;

namespace DynamicProgrammingTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        // Arrange
        var string1 = "hello";
        var string2 = "velo";
        var string3 = "parcello";

        // Act
        var result1 = StringComparisonSolver.CalculateIsSame(string1, string2);
        var result2 = StringComparisonSolver.CalculateIsSame(string1, string3);

        // Assert
        Assert.That(result1, Is.EqualTo(3));
        Assert.That(result2, Is.EqualTo(4));
    }
}

using KMeansAlgorithm;
namespace KMeanAlgorithmTests;

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
        var users = new User[]
        {
            new User { Action=1, Adventure=2, Drama=5, Thriller=2, MatrixRating=4, Name="Paola" },
            new User { Action=5, Adventure=5, Drama=2, Thriller=3, MatrixRating=5, Name="Mark" },
            new User { Action=4, Adventure=5, Drama=4, Thriller=2, MatrixRating=4, Name="Alex" },
            new User { Action=1, Adventure=5, Drama=3, Thriller=5, MatrixRating=2, Name="Susan" }
        };

        var target = new User { Action = 3, Adventure = 3, Drama = 4, Thriller = 3, Name = "Yujin" };

        // Act
        var predict = KMeansSolver.CalculatePredictingRating(target, users);

        // Assert
        Assert.That(predict, Is.EqualTo(4));
    }
}

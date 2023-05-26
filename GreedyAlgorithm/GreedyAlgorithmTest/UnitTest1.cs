using GreedyAlgorithm;

namespace GreedyAlgorithmTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GreedySolver_Return_Correct_Answer()
    {
        // Arrange
        var requiredStates = new string[] {
            "mt", "wa", "or", "id", "nv", "ut"
        };

        var stations = new Dictionary<string, string[]>
        {
            {"kone", new string[] {"id", "nv", "ut"} },
            {"ktwo", new string[] {"wa", "id", "mt"} },
            {"kthree", new string[] {"or", "nv", "ca"} },
            {"kfour", new string[] {"nv", "ut"} },
            {"kfive", new string[] {"ca", "az"} }
        };

        var result = new string[] { "kone", "ktwo", "kthree", "kfive" };

        //Act
        var required = GreedySolver.SolveGreedyProblem(requiredStates, stations);

        //Assert
        Assert.That(required, Is.EquivalentTo(result));
    }
}

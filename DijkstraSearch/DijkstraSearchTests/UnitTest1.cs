using DijkstraSearch;

namespace DijkstraSearchTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DijkstraSearcher_Correct_Calculate_Min_Path_Cost()
    {
        // Arrange
        var graph = new Dictionary<string, Dictionary<string, int>>();
        graph.Add("start", new Dictionary<string, int>
        {
            {"a", 6 },
            {"b", 2 }
        });
        graph.Add("a", new Dictionary<string, int>
        {
            { "fin", 1 }
        });
        graph.Add("b", new Dictionary<string, int>
        {
            { "a", 3},
            { "fin", 5 }
        });

        var costs = new Dictionary<string, int>
        {
            { "a", 2 },
            { "b", 6 },
            { "fin", int.MaxValue }
        };
        Assert.Pass();

        var parents = new Dictionary<string, string>
        {
            { "a", "start" },
            { "b", "start" },
            { "fin", null }
        };

        // Act
        DijkstraSearcher.CalculatePathCost(graph, costs, parents);

        // Assert
        Assert.That(costs["fin"], Is.EqualTo(6));
    }
}

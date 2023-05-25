using System.Globalization;
using BreadthFirstSearch;

namespace BreadthFirstSearchTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void BreadthFirstSearcher_Correct_Find_Person()
    {
        // Arrange
        var graph = new Dictionary<Person, ICollection<Person>>();

        var me = new Person { Name = "Evgeny", Income = 10 };
        var julia = new Person { Name = "Julia", Income = 1000 };
        var emil = new Person { Name = "Emil", Income = 200 };
        var nataly = new Person { Name = "Nataly", Income = 300 };
        var alex = new Person { Name = "Alex", Income = 20000 };
        var nick = new Person { Name = "Nick", Income = 30000 };

        graph.Add(me, new List<Person> { julia, emil, nataly });
        graph.Add(julia, new List<Person> { me, emil, nataly });
        graph.Add(emil, new List<Person> { nataly, alex });
        graph.Add(nataly, new List<Person> { nick, emil, me, julia });
        graph.Add(alex, new List<Person> { nick });
        graph.Add(nick, new List<Person>());

        // Act
        var result = BreadthFirstSearcher.FindPerson(graph, me);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void BreadthFirstSearcher_Correct_Did_Not_Find_Person()
    {
        // Arrange
        var graph = new Dictionary<Person, ICollection<Person>>();

        var me = new Person { Name = "Evgeny", Income = 10 };
        var julia = new Person { Name = "Julia", Income = 1000 };
        var emil = new Person { Name = "Emil", Income = 200 };
        var nataly = new Person { Name = "Nataly", Income = 300 };
        var alex = new Person { Name = "Alex", Income = 20000 };
        var nick = new Person { Name = "Nick", Income = 9000 };

        graph.Add(me, new List<Person> { julia, emil, nataly });
        graph.Add(julia, new List<Person> { me, emil, nataly });
        graph.Add(emil, new List<Person> { nataly });
        graph.Add(nataly, new List<Person> { nick, emil, me, julia });
        graph.Add(alex, new List<Person> { nick });
        graph.Add(nick, new List<Person>());

        // Act
        var result = BreadthFirstSearcher.FindPerson(graph, me);

        // Assert
        Assert.That(result, Is.False);
    }
}

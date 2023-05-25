namespace RecursiveListCountTest;

public class Tests
{
    private static readonly object[] _sourceLists =
    {
        new object[] {new List<object> {1}},   //case 1
        new object[] {new List<object> {1, 2}},
        new object[] {new List<object>() }

    };

    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(_sourceLists))]
    public void CountCalculator_Correct_Calculate_Common_Lists(IList<object> objects)
    {
        var objectsCount = objects.Count();
        Assert.That(RecursiveListCount.CountCalculator.CalculateLength(objects), Is.EqualTo(objectsCount));
    }

    [Test]
    public void CountCalculator_Correct_Calculate_Null()
    {
        Assert.That(RecursiveListCount.CountCalculator.CalculateLength(null), Is.EqualTo(-1));
    }
}

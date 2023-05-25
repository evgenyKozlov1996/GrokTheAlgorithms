using RecursiveSum;

namespace RecursiveSumTest;

public class RecursiveSumTests
{
    private static readonly object[] _sourceLists =
    {
        new object[] {new List<int> {1}},   //case 1
        new object[] {new List<int> {1, 2, 6}}, //case 2
        new object[] {new List<int> {1, 2, 9}}, //case 3

    };

    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(_sourceLists))]
    public void RecursiveSum_Calculate_Correct_With_Common_Array(IList<int> ints)
    {
        Assert.That(SumCalculator.Sum(ints), Is.EqualTo(ints.Sum()));
    }

    [Test]
    public void RecursiveSum_Correct_With_Empty_List()
    {
        Assert.That(SumCalculator.Sum(new List<int>()), Is.Null);
    }

    [Test]
    public void RecursiveSum_Correct_With_Null()
    {
        Assert.That(SumCalculator.Sum(null), Is.Null);
    }
}

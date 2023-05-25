using RecursiveMaxCountInList;

namespace RecursiveMaxCountInListTests;

public class Tests
{
    private static readonly object[] _sourceLists =
    {
        new object[] {new List<int> {1}},   //case 1
        new object[] {new List<int> {1, 2}}, //case 2
        new object[] {new List<int> { 1, 1,} },
        new object[] {new List<int> { 9, 8, 1} },
        new object[] {new List<int> { -1, -2, -4} }
    };

    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(_sourceLists))]
    public void MaxElementCalculator_Correct_For_Common_Lists(IList<int> ints)
    {
        Assert.That(MaxElementCalculator.GetMaxElement(ints), Is.EqualTo(ints.Max()));
    }

    [Test]
    public void MaxElementCalculator_Corrent_For_Empty_List()
    {
        Assert.That(MaxElementCalculator.GetMaxElement(new List<int>()), Is.Null);
    }

    [Test]
    public void MaxElementCalculator_Corrent_For_Null()
    {
        Assert.That(MaxElementCalculator.GetMaxElement(null), Is.Null);
    }
}

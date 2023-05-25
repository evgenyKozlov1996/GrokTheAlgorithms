using QuickSort;

namespace QuickSortTests;

public class Tests
{
    private static readonly object[] _sourceLists =
    {
        new object[] {new List<int> {1}},
        new object[] {new List<int> {2, 1}},
        new object[] {new List<int> ()},
        new object[] {new List<int> { -1, -2, -3, 4, 3, 5, 9, 10} }
    };

    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(_sourceLists))]
    public void QuickSorter_Correct_Sort_Common_List(IList<int> ints)
    {
        // Arrange
        var listCopy = ints.Select(num => num).ToList();
        listCopy.Sort();

        // Act 
        var sortedList = QuickSorter.QuickSort(ints);

        // Assert
        Assert.That(sortedList, Is.EquivalentTo(listCopy));
    }

    [Test]
    public void QuickSorter_Correct_Sort_Null()
    {
        Assert.That(QuickSorter.QuickSort(null), Is.Null);
    }
}

// See https://aka.ms/new-console-template for more information
var sortedListAsc = InsertSort(new List<int> { 2, 8, 4, 3, 1, 5 }, true);

foreach(var value in sortedListAsc)
{
    Console.Write(value + " ");
}

Console.WriteLine();

var sortedListDesc = InsertSort(new List<int> { 2, 8, 4, 3, 1, 5 }, false);

foreach (var value in sortedListDesc)
{
    Console.Write(value + " ");
}

Console.WriteLine();

var sortedListEmptyArr = InsertSort(new List<int>(1), false);

foreach (var value in sortedListEmptyArr)
{
    Console.Write(value + " ");
}

///<summary>
///<para name="dimension">True - по возрастанию, false - по убыванию </para>
///</summary>
static int[] InsertSort(ICollection<int> array, bool dimension)
{
    var sortedArr = new List<int>(array.Count);

    if (dimension)
    {
        while(array.Count > 0)
        {
            var minVal = GetMinValue(array);
            sortedArr.Add(minVal);

            array.Remove(minVal);
        }

        return sortedArr.ToArray();
    }
    else
    {
        while (array.Count > 0)
        {
            var maxVal = GetMaxValue(array);
            sortedArr.Add(maxVal);

            array.Remove(maxVal);
        }

        return sortedArr.ToArray();
    }
}

static int GetMinValue(ICollection<int> array)
{
    var minValue = int.MaxValue;

    foreach(var val in array)
    {
        if(minValue > val)
        {
            minValue = val;
        }
    }

    return minValue;
}

static int GetMaxValue(ICollection<int> array)
{
    var maxValue = int.MinValue;

    foreach (var val in array)
    {
        if (maxValue < val)
        {
            maxValue = val;
        }
    }

    return maxValue;
}
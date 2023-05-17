// See https://aka.ms/new-console-template for more information
if (Search(new int[] { 1, 3, 5, 7 }, 5) == 2) {
    Console.WriteLine("Test passed with 5 value");
}
else
{
    Console.WriteLine("Test failed with 5 value");
}

if (Search(new int[] { 22, 54, 126, 9374, 12456, 13456, 14456 }, 22) == 0)
{
    Console.WriteLine("Test passed with 22 value");
}
else
{
    Console.WriteLine("Test failed with 22 value");
}

if (Search(new int[] { 1, 3, 5, 7 }, 9) == -1)
{
    Console.WriteLine("Test passed with 9 value");
}
else
{
    Console.WriteLine("Test failed with 9 value");
}


static int Search(int[] array, int targetValue)
{
    var min = 0;
    var max = array.Length - 1;

    while(min <= max)
    {
        var mid = (min + max) / 2;

        if (array[mid] == targetValue)
        {
            return mid;
        }

        if (array[mid] < targetValue)
        {
            min = mid + 1;
        }

        if (array[mid] > targetValue)
        {
            max = mid - 1;
        }
    }

    return -1;
}


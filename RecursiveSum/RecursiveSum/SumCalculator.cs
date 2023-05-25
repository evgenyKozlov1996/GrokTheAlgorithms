using System;
namespace RecursiveSum
{
	public static class SumCalculator
	{
        public static int? Sum(IList<int> ints)
        {
            if (ints == null || ints.Count == 0)
            {
                return null;
            }

            var sum = 0;
            if (ints.Count() == 1)
            {
                return ints.ElementAt(0);
            }

            ints.RemoveAt(0);
            return sum + Sum(ints);
        }
    }
}


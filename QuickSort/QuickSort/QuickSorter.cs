namespace QuickSort
{
	public static class QuickSorter
	{
		public static IList<int> QuickSort(IList<int> ints)
		{
			if(ints == null || ints.Count == 0 || ints.Count == 1)
			{
				return ints;
			}

			var pivot = ints[0];

			ints.RemoveAt(0);

			var lessThanPivot = ints.Where(num => num < pivot).ToList();
			var moreThanPivot = ints.Where(num => num >= pivot).ToList();

			var sortedLess = QuickSort(lessThanPivot);
			var sortedMore = QuickSort(moreThanPivot);

			sortedLess.Add(pivot);
			return sortedLess.Concat(sortedMore).ToList();

		}
	}
}


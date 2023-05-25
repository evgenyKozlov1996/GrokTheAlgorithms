namespace QuickSort
{
	public static class QuickSorter
	{
		public static IList<int> QuickSort(IList<int> ints)
		{
			if(ints == null || ints.Count < 2)
			{
				return ints;
			}

			int pivotIndex = Random.Shared.Next(0, ints.Count);
			var pivot = ints[pivotIndex];

			ints.RemoveAt(pivotIndex);

			var lessThanPivot = ints.Where(num => num < pivot).ToList();
			var moreThanPivot = ints.Where(num => num >= pivot).ToList();

			var sortedLess = QuickSort(lessThanPivot);
			var sortedMore = QuickSort(moreThanPivot);

			sortedLess.Add(pivot);
			return sortedLess.Concat(sortedMore).ToList();

		}
	}
}


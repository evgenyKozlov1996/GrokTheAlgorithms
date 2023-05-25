namespace RecursiveMaxCountInList
{
	public static class MaxElementCalculator
	{
		public static int? GetMaxElement(IList<int> ints)
		{
			if(ints == null || !ints.Any())
			{
				return null;
			}

			if(ints.Count() == 1)
			{
				return ints[0];
			}

			ints.Remove(ints.Min());

			return GetMaxElement(ints);
		}
	}
}


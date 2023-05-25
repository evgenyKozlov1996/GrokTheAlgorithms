using System;
namespace RecursiveListCount
{
	public static class CountCalculator
	{
		public static int CalculateLength(IList<object> objects)
		{
			if(objects == null)
			{
				return -1;
			}

			if (!objects.Any())
			{
				return 0;
			}

			objects.RemoveAt(0);
			return 1 + CalculateLength(objects);
		}
	}
}


using System;
namespace KMeansAlgorithm
{
	public static class KMeansSolver
	{
		public static double CalculatePredictingRating(User target, User[] users)
		{
			var distances = new Dictionary<double, User>();
			foreach(var user in users)
			{
				distances.Add(Math.Sqrt(
					Math.Pow(target.Action - user.Action, 2) +
					Math.Pow(target.Adventure - user.Adventure, 2) +
					Math.Pow(target.Drama - user.Drama, 2) +
					Math.Pow(target.Thriller - user.Thriller, 2)), user);
			}

			var first = distances.Keys.Min();
			var user1 = distances[first];

			distances.Remove(first);

			var second = distances.Keys.Min();
			var user2 = distances[second];

			return (user1.MatrixRating + user2.MatrixRating) / 2d;
		}
	}
}


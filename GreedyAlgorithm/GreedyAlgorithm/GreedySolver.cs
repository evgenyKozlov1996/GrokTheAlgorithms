namespace GreedyAlgorithm
{
	public static class GreedySolver
	{
		public static ICollection<string> SolveGreedyProblem(string[] requiredStates, IDictionary<string, string[]> stations)
		{
			var finalStations = new List<string>();
			while (requiredStates.Any())
			{
				string bestStation = string.Empty;
				var statesCovered = new List<string>();

				foreach (var (station, states) in stations)
				{
					var covered = requiredStates.Intersect(states);
					if (covered.Count() > statesCovered.Count)
					{
						bestStation = station;
						statesCovered = covered.ToList();
					}
				}

				requiredStates = requiredStates.Except(statesCovered).ToArray();
				finalStations.Add(bestStation);
			}

			return finalStations;
		}
	}
}


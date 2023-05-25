using System;
namespace DijkstraSearch
{
	public static class DijkstraSearcher
	{
		public static void CalculatePathCost(IDictionary<string, Dictionary<string, int>> graph, IDictionary<string, int> costs, IDictionary<string, string> parent)
		{
			var processedNodes = new List<string>();
			var node = FindLowestCostNode(costs, processedNodes);
			while(node != null)
			{
				var cost = costs[node];
				var neighbours = graph[node];
				foreach(var key in neighbours.Keys)
				{
					var newCost = cost + neighbours[key];
					if(newCost < costs[key])
					{
						costs[key] = newCost;
						parent[key] = node;
					}
				}

				processedNodes.Add(node);
				node = FindLowestCostNode(costs, processedNodes);
			}
		}

		private static string? FindLowestCostNode(IDictionary<string, int> costs, IList<string> processed)
		{
			var lowestCost = int.MaxValue;
			string lowestCostNode = null;
			foreach(var node in costs.Keys)
			{
				var cost = costs[node];
				if(cost < lowestCost && !processed.Contains(node))
				{
					lowestCost = cost;
					lowestCostNode = node;
				}
			}

			return lowestCostNode;
		}
	}
}


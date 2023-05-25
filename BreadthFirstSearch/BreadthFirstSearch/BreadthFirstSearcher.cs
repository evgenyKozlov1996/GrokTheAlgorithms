using System;
namespace BreadthFirstSearch
{
	public static class BreadthFirstSearcher
	{
		public static bool FindPerson(IDictionary<Person, ICollection<Person>> graph, Person initial)
		{
			var personsToSearch = new Queue<Person>();
			var searchedPersons = new List<Person>();
			personsToSearch.Enqueue(initial);

			while (personsToSearch.Any())
			{
				var person = personsToSearch.Dequeue();

				if (!searchedPersons.Exists(pers => pers == person))
				{
					searchedPersons.Add(person);
					if (person.Income >= 10000)
					{
						return true;
					}
					else
					{
						foreach (var friend in graph[person])
						{
							personsToSearch.Enqueue(friend);
						}
					}
				}
			}

			return false;
		}
	}
}


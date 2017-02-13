using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingInterview.School
{
	public class Portals
	{
		public static int Solve(int[] costs, Tuple<int, int>[] connections)
		{
			var buckets = Enumerable
				.Range(1, costs.Count())
				.Select(p =>
				{
					var b = new HashSet<int>();
					b.Add(p);
					return b;
				})
				.ToList();

			foreach (var connection in connections)
			{
				HashSet<int> bucket1 = null, bucket2 = null;

				foreach (var bucket in buckets)
				{
					if (bucket.Contains(connection.Item1))
					{
						bucket1 = bucket;
					}

					if (bucket.Contains(connection.Item2))
					{
						bucket2 = bucket;
					}

					if (bucket1 != null && bucket2 != null)
					{
						break;
					}
				}

				if (bucket1 != bucket2)
				{
					bucket1.UnionWith(bucket2);
					buckets.Remove(bucket2);
				}
			}

			var minimalCosts = buckets.Select(b => b.Select(p => costs[p - 1]).Min());

			var min = minimalCosts.Min();

			var result = min * (minimalCosts.Count() - 1) + (minimalCosts.Sum() - min);

			return result;
		}
	}
}

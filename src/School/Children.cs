namespace CodingInterview.School
{
	public class Children
	{
		/// <summary>
		/// Solve the problem for specified m and n.
		/// </summary>
		/// <returns>The number of the last child in the game</returns>
		/// <param name="m">Total children</param>
		/// <param name="n">N-th child drops each round</param>
		public static int Solve(int m, int n)
		{
			if (m == 1)
			{
				return 1;
			}

			if (n == 1)
			{
				return m;
			}

			var start = new Node(1);
			var current = start;

			for (int i = 1; i <= m - 1; i++)
			{
				current.next = new Node(i + 1);
				current = current.next;
			}

			current.next = start;
			current = start;

			for (int i = 0; i < m - 1; i++)
			{
				for (int j = 0; j < n - 2; j++)
				{
					current = current.next;
				}
				current.next = current.next.next;
				current = current.next;
			}

			return current.Value;
		}
	}

	class Node
	{
		public int Value { get; set; }
		public Node next { get; set; }

		public Node(int value)
		{
			Value = value;
		}
	}
}

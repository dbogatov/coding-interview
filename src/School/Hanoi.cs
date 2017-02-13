namespace CodingInterview.School
{
	public class Hanoi
	{
		static string result = "";

		public static string Solve(int n)
		{
			Displace(n, 1, 2);

			return result;
		}

		static void Displace(int n, int from, int to)
		{
			var empty = 6 - (from + to);

			if (n == 1)
			{
				result += $"{from}->{to}\n";
			}
			else
			{
				Displace(n - 1, from, empty);
				result += $"{from}->{to}\n";
				Displace(n - 1, empty, to);
			}
		}
	}
}

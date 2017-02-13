namespace CodingInterview.Sort
{
	public class BubbleSort
	{
		public static int[] Sort(int[] input)
		{
			if (input.Length < 2)
			{
				return input;
			}

			var sorted = false;

			while (!sorted)
			{
				sorted = true;
				for (int i = 1; i < input.Length; i++)
				{
					if (input[i] < input[i - 1])
					{
						int temp = input[i];
						input[i] = input[i - 1];
						input[i - 1] = temp;
						sorted = false;
					}
				}
			}

			return input;
		}
	}
}

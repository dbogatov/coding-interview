namespace CodingInterview.Sort
{
	public class SelectionSort
	{
		public static int[] Sort(int[] input)
		{
			if (input.Length < 2)
			{
				return input;
			}

			for (int i = 0; i < input.Length - 1; i++)
			{
				var minIndex = i;

				for (int j = i + 1; j < input.Length; j++)
				{
					if (input[j] < input[minIndex])
					{
						minIndex = j;
					}
				}

				var temp = input[i];
				input[i] = input[minIndex];
				input[minIndex] = temp;
			}

			return input;
		}
	}
}

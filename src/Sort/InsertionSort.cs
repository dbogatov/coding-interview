// 
//
// This file - InsertionSort.cs was created by Dmytro Bogatov (dmytro@dbogatov.org)
// on 12/6/2016, 7:44 PM

namespace Sort
{
	public class InsertionSort
	{
		public static int[] Sort(int[] input)
		{
			if (input.Length < 2)
			{
				return input;
			}

			var output = new int[input.Length];

			output[0] = input[0];

			for (int i = 1; i < input.Length; i++)
			{
				var current = input[i];
				var inserted = false;

				for (int j = 0; j < i; j++)
				{
					if (current < output[j])
					{
						for (int k = i; k > j; k--)
						{
							output[k] = output[k - 1];
						}
						output[j] = current;
						inserted = true;
						break;
					}
				}

				if (!inserted)
				{
					output[i] = current;
				}
			}

			return output;
		}
	}
}

// 
//
// This file - BubleSort.cs was created by Dmytro Bogatov (dmytro@dbogatov.org)
// on 12/6/2016, 7:26 PM

namespace Sort
{
	public class BubleSort
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

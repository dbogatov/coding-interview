// 
//
// This file - QuickSort.cs was created by Dmytro Bogatov (dmytro@dbogatov.org)
// on 12/7/2016, 1:05 AM

namespace Sort
{
	public class QuickSort
	{
		public static int[] Sort(int[] input)
		{
			if (input.Length < 2)
			{
				return input;
			}

			return Quick(0, input.Length - 1, input);
		}

		static int[] Quick(int left, int right, int[] input)
		{
			if (left >= right)
			{
				return input;
			}

			var pivotIndex = (right + left) / 2;
			var pivotValue = input[pivotIndex];

			var temp = new int[right - left + 1];

			var l = 0;
			var r = right - left;

			for (int i = left; i <= right; i++)
			{
				if (i == pivotIndex)
				{
					continue;
				}

				if (input[i] > pivotValue)
				{
					temp[r] = input[i];
					r--;
				}
				else
				{
					temp[l] = input[i];
					l++;
				}
			}

			temp[l] = pivotValue;

			for (int i = left; i <= right; i++)
			{
				input[i] = temp[i - left];
			}


			input = Quick(left, left + l - 1, input);
			input = Quick(left + l + 1, right, input);

			return input;
		}
	}
}

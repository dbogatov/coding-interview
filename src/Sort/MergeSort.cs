// 
//
// This file - MergeSort.cs was created by Dmytro Bogatov (dmytro@dbogatov.org)
// on 12/6/2016, 8:26 PM

namespace Sort
{
	public class MergeSort
	{
		public static int[] Sort(int[] input)
		{
			if (input.Length < 2)
			{
				return input;
			}

			return Merge(0, input.Length - 1, input);
		}

		static int[] Merge(int left, int right, int[] input)
		{
			if (right == left)
			{
				return input;
			}

			var middle = (left + right) / 2;

			input = Merge(left, middle, input);
			input = Merge(middle + 1, right, input);


			// Optimization possible: swap in-place
			var temparray = new int[right - left + 1];

			var l = left;
			var r = middle + 1;

			for (var i = 0; i < right - left + 1; i++)
			{
				if (r > right || (l <= middle && input[l] < input[r]))
				{
					temparray[i] = input[l];
					l++;
					continue;
				}

				if (l > middle || input[l] >= input[r])
				{
					temparray[i] = input[r];
					r++;
					continue;
				}
			}

			for (int i = 0; i < temparray.Length; i++)
			{
				input[left + i] = temparray[i];
			}

			return input;
		}
	}
}

﻿// 
//
// This file - HeapSort.cs was created by Dmytro Bogatov (dmytro@dbogatov.org)
// on 12/7/2016, 2:44 PM

namespace Sort
{
	// Mostly borrowed from https://begeeben.wordpress.com/2012/08/21/heap-sort-in-c/
	public class HeapSort
	{
		public static int[] Sort(int[] input)
		{
			if (input.Length < 2)
			{
				return input;
			}

			//Build-Max-Heap
			int heapSize = input.Length;
			for (int p = (heapSize - 1) / 2; p >= 0; p--)
				MaxHeapify(input, heapSize, p);

			for (int i = input.Length - 1; i > 0; i--)
			{
				//Swap
				int temp = input[i];
				input[i] = input[0];
				input[0] = temp;

				heapSize--;
				MaxHeapify(input, heapSize, 0);
			}

			return input;
		}

		static void MaxHeapify(int[] input, int heapSize, int index)
		{
			int left = (index + 1) * 2 - 1;
			int right = (index + 1) * 2;
			int largest = 0;

			if (left < heapSize && input[left] > input[index])
				largest = left;
			else
				largest = index;

			if (right < heapSize && input[right] > input[largest])
				largest = right;

			if (largest != index)
			{
				int temp = input[index];
				input[index] = input[largest];
				input[largest] = temp;

				MaxHeapify(input, heapSize, largest);
			}
		}

	}
}
using System;
using System.Linq;
using Xunit;
using CodingInterview.Sort;

namespace CodingInterview.Tests.Sort
{
	public class QuickSortTests
	{
		[Fact]
		public void TestCases()
		{
			Assert.Equal(
				new int[] { -1, 1, 2, 5, 8, 9, 45 },
				QuickSort.Sort(new int[] { 5, 2, 1, -1, 8, 45, 9 })
			);

			Assert.Equal(
				new int[] { 2, 5, 6, 8, 9 },
				QuickSort.Sort(new int[] { 5, 2, 6, 8, 9 })
			);

			Assert.Equal(
				new int[] { 1 },
				QuickSort.Sort(new int[] { 1 })
			);

			Assert.Equal(
				new int[] { },
				QuickSort.Sort(new int[] { })
			);

			Assert.Equal(
				new int[] { 5, 5, 6 },
				QuickSort.Sort(new int[] { 5, 6, 5 })
			);


			Random randNum = new Random();
			var list = Enumerable.Repeat(0, 25).Select(i => randNum.Next(-100, 100)).ToList();
			var input = list.ToArray();
			list.Sort();
			var expected = list.ToArray();

			Assert.Equal(
				expected,
				QuickSort.Sort(input)
			);
		}
	}
}

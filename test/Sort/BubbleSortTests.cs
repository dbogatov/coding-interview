using System;
using System.Linq;
using Xunit;
using CodingInterview.Sort;

namespace CodingInterview.Tests.Sort
{
	public class BubbleSortTests
	{
		[Fact]
		public void TestCases()
		{
			Assert.Equal(
				new int[] { 2, 5, 6, 8, 9 },
				BubbleSort.Sort(new int[] { 5, 2, 6, 8, 9 })
			);

			Assert.Equal(
				new int[] { 1 },
				BubbleSort.Sort(new int[] { 1 })
			);

			Assert.Equal(
				new int[] { },
				BubbleSort.Sort(new int[] { })
			);

			Assert.Equal(
				new int[] { 5, 5, 6 },
				BubbleSort.Sort(new int[] { 5, 6, 5 })
			);

			Random randNum = new Random();
			var list = Enumerable.Repeat(0, 5).Select(i => randNum.Next(-100, 100)).ToList();
			var input = list.ToArray();
			list.Sort();
			var expected = list.ToArray();

			Assert.Equal(
				expected,
				BubbleSort.Sort(input)
			);
		}
	}
}

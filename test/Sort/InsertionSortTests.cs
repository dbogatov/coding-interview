using System;
using System.Linq;
using Xunit;
using CodingInterview.Sort;

namespace CodingInterview.Tests.Sort
{
	public class InsertionSortTests
	{
		[Fact]
		public void TestCases()
		{
			Assert.Equal(
				new int[] { 2, 5, 6, 8, 9 },
				InsertionSort.Sort(new int[] { 5, 2, 6, 8, 9 })
			);

			Assert.Equal(
				new int[] { 1 },
				InsertionSort.Sort(new int[] { 1 })
			);

			Assert.Equal(
				new int[] { },
				InsertionSort.Sort(new int[] { })
			);

			Assert.Equal(
				new int[] { 5, 5, 6 },
				InsertionSort.Sort(new int[] { 5, 6, 5 })
			);

			Random randNum = new Random();
			var list = Enumerable.Repeat(0, 2016).Select(i => randNum.Next(-100, 100)).ToList();
			var input = list.ToArray();
			list.Sort();
			var expected = list.ToArray();


			Assert.Equal(
				expected,
				InsertionSort.Sort(input)
			);
		}
	}
}

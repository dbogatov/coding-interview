// 
//
// This file - QuickSortTests.cs was created by Dmytro Bogatov (dmytro@dbogatov.org)
// on 12/7/2016, 1:06 AM
using System;
using System.Linq;
using NUnit.Framework;

namespace Sort
{
	[TestFixture]
	public class QuickSortTests
	{
		[Test]
		public void TestCases()
		{
			Assert.AreEqual(
				new int[] { -1, 1, 2, 5, 8, 9, 45 },
				QuickSort.Sort(new int[] { 5, 2, 1, -1, 8, 45, 9 })
			);

			Assert.AreEqual(
				new int[] { 2, 5, 6, 8, 9 },
				QuickSort.Sort(new int[] { 5, 2, 6, 8, 9 })
			);

			Assert.AreEqual(
				new int[] { 1 },
				QuickSort.Sort(new int[] { 1 })
			);

			Assert.AreEqual(
				new int[] { },
				QuickSort.Sort(new int[] { })
			);

			Assert.AreEqual(
				new int[] { 5, 5, 6 },
				QuickSort.Sort(new int[] { 5, 6, 5 })
			);


			Random randNum = new Random();
			var list = Enumerable.Repeat(0, 25).Select(i => randNum.Next(-100, 100)).ToList();
			var input = list.ToArray();
			list.Sort();
			var expected = list.ToArray();

			Assert.AreEqual(
				expected,
				QuickSort.Sort(input)
			);
		}
	}
}

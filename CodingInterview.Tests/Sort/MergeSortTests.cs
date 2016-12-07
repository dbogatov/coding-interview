// 
//
// This file - MergeSortTests.cs was created by Dmytro Bogatov (dmytro@dbogatov.org)
// on 12/6/2016, 8:28 PM

using System;
using System.Linq;
using NUnit.Framework;

namespace Sort
{
	[TestFixture]
	public class MergeSortTests
	{
		[Test]
		public void TestCases()
		{
			Assert.AreEqual(
				new int[] { -1, 1, 2, 5, 8, 9, 45 },
				MergeSort.Sort(new int[] { 5, 2, 1, -1, 8, 45, 9 })
			);

			Assert.AreEqual(
				new int[] { 2, 5, 6, 8, 9 },
				MergeSort.Sort(new int[] { 5, 2, 6, 8, 9 })
			);

			Assert.AreEqual(
				new int[] { 1 },
				MergeSort.Sort(new int[] { 1 })
			);

			Assert.AreEqual(
				new int[] { },
				MergeSort.Sort(new int[] { })
			);

			Assert.AreEqual(
				new int[] { 5, 5, 6 },
				MergeSort.Sort(new int[] { 5, 6, 5 })
			);


			Random randNum = new Random();
			var list = Enumerable.Repeat(0, 25).Select(i => randNum.Next(-100, 100)).ToList();
			var input = list.ToArray();
			list.Sort();
			var expected = list.ToArray();

			Assert.AreEqual(
				expected,
				MergeSort.Sort(input)
			);
		}
	}
}

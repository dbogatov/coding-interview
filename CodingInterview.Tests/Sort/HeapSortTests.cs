// 
//
// This file - HeapSortTests.cs was created by Dmytro Bogatov (dmytro@dbogatov.org)
// on 12/7/2016, 2:47 PM
using System;
using System.Linq;
using NUnit.Framework;

namespace Sort
{
	[TestFixture]
	public class HeapSortTests
	{
		[Test]
		public void TestCases()
		{
			Assert.AreEqual(
				new int[] { -1, 1, 2, 5, 8, 9, 45 },
				HeapSort.Sort(new int[] { 5, 2, 1, -1, 8, 45, 9 })
			);

			Assert.AreEqual(
				new int[] { 2, 5, 6, 8, 9 },
				HeapSort.Sort(new int[] { 5, 2, 6, 8, 9 })
			);

			Assert.AreEqual(
				new int[] { 1 },
				HeapSort.Sort(new int[] { 1 })
			);

			Assert.AreEqual(
				new int[] { },
				HeapSort.Sort(new int[] { })
			);

			Assert.AreEqual(
				new int[] { 5, 5, 6 },
				HeapSort.Sort(new int[] { 5, 6, 5 })
			);


			Random randNum = new Random();
			var list = Enumerable.Repeat(0, 25).Select(i => randNum.Next(-100, 100)).ToList();
			var input = list.ToArray();
			list.Sort();
			var expected = list.ToArray();

			Assert.AreEqual(
				expected,
				HeapSort.Sort(input)
			);
		}
	}
}



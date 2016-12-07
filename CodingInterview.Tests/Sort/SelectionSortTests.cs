// 
//
// This file - SelectionSortTests.cs was created by Dmytro Bogatov (dmytro@dbogatov.org)
// on 12/6/2016, 8:15 PM
using System;
using System.Linq;
using NUnit.Framework;

namespace Sort
{
	[TestFixture]
	public class SelectionSortTests
	{
		[Test]
		public void TestCases()
		{
			Assert.AreEqual(
				new int[] { 2, 5, 6, 8, 9 },
				SelectionSort.Sort(new int[] { 5, 2, 6, 8, 9 })
			);

			Assert.AreEqual(
				new int[] { 1 },
				SelectionSort.Sort(new int[] { 1 })
			);

			Assert.AreEqual(
				new int[] { },
				SelectionSort.Sort(new int[] { })
			);

			Assert.AreEqual(
				new int[] { 5, 5, 6 },
				SelectionSort.Sort(new int[] { 5, 6, 5 })
			);

			Random randNum = new Random();
			var list = Enumerable.Repeat(0, 2016).Select(i => randNum.Next(-100, 100)).ToList();
			var input = list.ToArray();
			list.Sort();
			var expected = list.ToArray();


			Assert.AreEqual(
				expected,
				SelectionSort.Sort(input)
			);
		}
	}
}

// 
//
// This file - BubleSortTests.cs was created by Dmytro Bogatov (dmytro@dbogatov.org)
// on 12/6/2016, 7:28 PM

using System;
using System.Linq;
using NUnit.Framework;

namespace Sort
{
	[TestFixture]
	public class BubleSortTests
	{
		[Test]
		public void TestCases()
		{
			Assert.AreEqual(
				new int[] { 2, 5, 6, 8, 9 },
				BubleSort.Sort(new int[] { 5, 2, 6, 8, 9 })
			);

			Assert.AreEqual(
				new int[] { 1 },
				BubleSort.Sort(new int[] { 1 })
			);

			Assert.AreEqual(
				new int[] { },
				BubleSort.Sort(new int[] { })
			);

			Assert.AreEqual(
				new int[] { 5, 5, 6 },
				BubleSort.Sort(new int[] { 5, 6, 5 })
			);

			Random randNum = new Random();
			var list = Enumerable.Repeat(0, 5).Select(i => randNum.Next(-100, 100)).ToList();
			var input = list.ToArray();
			list.Sort();
			var expected = list.ToArray();

			Assert.AreEqual(
				expected,
				BubleSort.Sort(input)
			);
		}
	}
}

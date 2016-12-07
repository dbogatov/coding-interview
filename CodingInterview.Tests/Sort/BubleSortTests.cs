// 
//
// This file - BubleSortTests.cs was created by Dmytro Bogatov (dmytro@dbogatov.org)
// on 12/6/2016, 7:28 PM

using NUnit.Framework;
using CodingInterview.Sort;

namespace CodingInterview.Tests.Sort
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
		}
	}
}

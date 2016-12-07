// 
//
// This file - InsertionSortTests.cs was created by Dmytro Bogatov (dmytro@dbogatov.org)
// on 12/6/2016, 7:45 PM
using NUnit.Framework;

namespace CodingInterview.Tests
{
	[TestFixture]
	public class InsertionSortTests
	{
		[Test]
		public void TestCases()
		{
			Assert.AreEqual(
				new int[] { 2, 5, 6, 8, 9 },
				InsertionSort.Sort(new int[] { 5, 2, 6, 8, 9 })
			);

			Assert.AreEqual(
				new int[] { 1 },
				InsertionSort.Sort(new int[] { 1 })
			);

			Assert.AreEqual(
				new int[] { },
				InsertionSort.Sort(new int[] { })
			);

			Assert.AreEqual(
				new int[] { 5, 5, 6 },
				InsertionSort.Sort(new int[] { 5, 6, 5 })
			);
		}
	}
}

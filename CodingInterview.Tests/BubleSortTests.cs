// 
//
// This file - BubleSortTests.cs was created by Dmytro Bogatov (dmytro@dbogatov.org)
// on 12/6/2016, 7:28 PM

using NUnit.Framework;

namespace CodingInterview.Tests
{
	[TestFixture]
	public class Test
	{
		[Test]
		public void TestCases()
		{
			Assert.AreEqual(
				BubleSort.Sort(new int[] { 5, 2, 6, 8, 9 }),
				new int[] { 2, 5, 6, 8, 9 }
			);

			Assert.AreEqual(
				BubleSort.Sort(new int[] { 1 }),
				new int[] { 1 }
			);

			Assert.AreEqual(
				BubleSort.Sort(new int[] { }),
				new int[] { }
			);

			Assert.AreEqual(
				BubleSort.Sort(new int[] { 5, 6, 5 }),
				new int[] { 5, 5, 6 }
			);
		}
	}
}

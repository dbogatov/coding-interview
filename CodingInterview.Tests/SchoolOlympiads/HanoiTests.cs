// 
//
// This file - HanoiTests.cs was created by Dmytro Bogatov (dmytro@dbogatov.org)
// on 12/7/2016, 5:52 PM

using NUnit.Framework;

namespace SchoolOlympiads
{
	[TestFixture]
	public class HanoiTests
	{
		[Test]
		public void TestCases()
		{
			StringAssert.AreEqualIgnoringCase(
				"1->2\n1->3\n2->3\n1->2\n3->1\n3->2\n1->2\n",
				Hanoi.Solve(3)
			);
		}
	}
}

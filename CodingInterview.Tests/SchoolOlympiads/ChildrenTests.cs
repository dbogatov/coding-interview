// 
//
// This file - ChildrenTests.cs was created by Dmytro Bogatov (dmytro@dbogatov.org)
// on 12/7/2016, 4:18 PM
using System;
using NUnit.Framework;

namespace SchoolOlympiads
{
	[TestFixture]
	public class ChildrenTests
	{
		[Test]
		public void TestCases()
		{
			Assert.AreEqual(4, Children.Solve(10, 3));
			Assert.AreEqual(5, Children.Solve(10, 2));
			Assert.AreEqual(10, Children.Solve(10, 1));
			Assert.AreEqual(1, Children.Solve(1, 10));
			Assert.AreEqual(1, Children.Solve(2, 10));
		}
	}
}

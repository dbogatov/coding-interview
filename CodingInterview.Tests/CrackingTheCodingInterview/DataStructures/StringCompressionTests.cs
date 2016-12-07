// 
//
// This file - StringCompressionTests.cs was created by Dmytro Bogatov (dmytro@dbogatov.org)
// on 12/7/2016, 3:47 PM

using NUnit.Framework;

namespace CrackingTheCodingInterview.DataStructures
{
	[TestFixture]
	public class StringCompressionTests
	{
		[Test]
		public void TestCases()
		{
			StringAssert.AreEqualIgnoringCase("a2b1c5a3", StringCompression.Compress("aabcccccaaa"));
			StringAssert.AreEqualIgnoringCase("abcd", StringCompression.Compress("abcd"));
			StringAssert.AreEqualIgnoringCase("", StringCompression.Compress(""));
			StringAssert.AreEqualIgnoringCase("a", StringCompression.Compress("a"));
			StringAssert.AreEqualIgnoringCase("aaabcdefgh", StringCompression.Compress("aaabcdefgh"));
		}
	}
}

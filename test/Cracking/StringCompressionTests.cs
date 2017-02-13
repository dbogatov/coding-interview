using Xunit;
using CodingInterview.Cracking;

namespace CodingInterview.Tests.Cracking
{
	public class StringCompressionTests
	{
		[Fact]
		public void TestCases()
		{
			// cSpell:ignore aaabcdefgh

			Assert.Equal("a2b1c5a3", StringCompression.Compress("aabcccccaaa"));
			Assert.Equal("abcd", StringCompression.Compress("abcd"));
			Assert.Equal("", StringCompression.Compress(""));
			Assert.Equal("a", StringCompression.Compress("a"));
			Assert.Equal("aaabcdefgh", StringCompression.Compress("aaabcdefgh"));
		}
	}
}

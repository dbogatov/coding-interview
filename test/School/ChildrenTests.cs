using Xunit;
using CodingInterview.School;

namespace CodingInterview.Tests.School
{
	public class ChildrenTests
	{
		[Fact]
		public void TestCases()
		{
			Assert.Equal(4, Children.Solve(10, 3));
			Assert.Equal(5, Children.Solve(10, 2));
			Assert.Equal(10, Children.Solve(10, 1));
			Assert.Equal(1, Children.Solve(1, 10));
			Assert.Equal(1, Children.Solve(2, 10));
		}
	}
}

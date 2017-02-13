using Xunit;
using CodingInterview.School;

namespace CodingInterview.Tests.School
{
	public class HanoiTests
	{
		[Fact]
		public void TestCases()
		{
			Assert.Equal(
				"1->2\n1->3\n2->3\n1->2\n3->1\n3->2\n1->2\n",
				Hanoi.Solve(3)
			);
		}
	}
}

using System;
using System.IO;
using Xunit;
using CodingInterview.School;
using System.Collections.Generic;
using System.Linq;

namespace CodingInterview.Tests.School
{
	public class PortalsTests
	{
		[Fact]
		public void TestCases()
		{
			Assert.Equal(
				10,
				Portals.Solve(
					new int[] { 7, 4, 7, 3 },
					new Tuple<int, int>[] {
						new Tuple<int, int>(1, 3),
						new Tuple<int, int>(2, 4)
					}
				)
			);
		}

		[Theory]
		[InlineData("01")]
		[InlineData("02")]
		[InlineData("03")]
		[InlineData("04")]
		[InlineData("05")]
		[InlineData("06")]
		[InlineData("07")]
		[InlineData("08")]
		[InlineData("09")]
		[InlineData("10")]
		[InlineData("11")]
		[InlineData("12")]
		[InlineData("13")]
		[InlineData("14")]
		[InlineData("15")]
		[InlineData("16")]
		[InlineData("17")]
		[InlineData("18")]
		[InlineData("19")]
		[InlineData("20")]
		public void TestFromFile(string name)
		{
			var arguments = ParseFile(name);

			Assert.Equal(arguments.Item3, Portals.Solve(arguments.Item1, arguments.Item2));
		}

		Tuple<int[], Tuple<int, int>[], int> ParseFile(string name)
		{
			// Open the text file using a stream reader.
			using (StreamReader sr = File.OpenText($"Resources/Portals/{name}.in"))
			{
				// Read the stream to a string, and write the string to the console.
				sr.ReadLine();

				var costs = sr.ReadLine().Split(' ').Select(s => Int32.Parse(s));

				string line;
				var connections = new LinkedList<Tuple<int, int>>();

				while ((line = sr.ReadLine()) != null)
				{
					var asArray = line.Split(' ');
					connections.AddFirst(new Tuple<int, int>(int.Parse(asArray[0]), int.Parse(asArray[1])));
				}

				using (StreamReader streamAns = File.OpenText($"Resources/Portals/{name}.ans"))
				{
					// Read the stream to a string, and write the string to the console.
					var ans = int.Parse(streamAns.ReadLine());

					return new Tuple<int[], Tuple<int, int>[], int>(costs.ToArray(), connections.ToArray(), ans);
				}
			}

		}
	}
}

// 
//
// This file - PortalsTests.cs was created by Dmytro Bogatov (dmytro@dbogatov.org)
// on 12/7/2016, 7:39 PM
using System;
using System.IO;
using System.Reflection;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace SchoolOlympiads
{
	[TestFixture]
	public class PortalsTests
	{
		[Test]
		public void TestCases()
		{
			Assert.AreEqual(
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

		[Test]
		public void TestFromFile([Values("01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20")] string name)
		{
			var arguments = ParseFile(name);

			Assert.AreEqual(arguments.Item3, Portals.Solve(arguments.Item1, arguments.Item2));
		}

		Tuple<int[], Tuple<int, int>[], int> ParseFile(string name)
		{
			// Open the text file using a stream reader.
			using (StreamReader sr = new StreamReader($"../../Resources/Portals/{name}.in"))
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

				using (StreamReader srans = new StreamReader($"../../Resources/Portals/{name}.ans"))
				{
					// Read the stream to a string, and write the string to the console.
					var ans = int.Parse(srans.ReadLine());

					return new Tuple<int[], Tuple<int, int>[], int>(costs.ToArray(), connections.ToArray(), ans);
				}
			}

		}
	}
}

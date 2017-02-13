/*
 * Implement a method to perform basic string compression using the counts of repeated characters. 
 * For example, the string aabcccccaaa would become a2blc5a3. 
 * If the "compressed" string would not become smaller than the original string, 
 * your method should return the original string.
 */

namespace CodingInterview.Cracking
{
	public class StringCompression
	{
		public static string Compress(string input)
		{
			if (input.Length < 2)
			{
				return input;
			}

			string output = "";

			var current = input[0];
			var count = 1;

			for (int i = 1; i < input.Length; i++)
			{
				var newChar = input[i];

				if (newChar != current)
				{
					output += current + count.ToString();
					current = newChar;
					count = 1;
				}
				else
				{
					count++;
				}
			}

			output += current + count.ToString();

			return output.Length < input.Length ? output : input;
		}
	}
}

namespace StatusMonitor
{
	/// <summary>
	/// This class contains the entry point for the application.
	/// </summary>
	public class Program
	{
		/// <summary>
		/// The entry point.
		/// This function is responsible for starting up the server object.
		/// The server will try to start a number of times until it succeeds.
		/// For example, it may not connect to the database from the first attempt, because of network issues, or
		/// the database may not be ready at the time of application start.
		/// </summary>
		/// <param name="args">Arguments passed to the application through the command line. At the moment not used. </param>
		public static void Main(string[] args)
		{
		}
	}
}
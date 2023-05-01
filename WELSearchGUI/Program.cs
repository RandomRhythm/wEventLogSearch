namespace WELSearchGUI
{
	static class Program
	{
		public static string DefaultExceptionLogFilename = "Log.Exceptions.txt";

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException; ;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}

		private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			string message =
				$"Global exception handler caught an exception!" +
				Environment.NewLine +
				"Is terminating: {e.IsTerminating}.";

			Exception ex = ((Exception)e.ExceptionObject);

			MessageBox.Show(message + Environment.NewLine +
				ex.ToString(), "Unhandled exception caught!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);

			LogException(message, ex);
		}

		public static void LogException(string message, Exception ex)
		{
			string timeStamp = $"[{DateTime.Now.ToLongDateString()} at {DateTime.Now.ToLongTimeString()}]:";

			File.AppendAllText(DefaultExceptionLogFilename, $"{timeStamp} {message}" + Environment.NewLine);
			File.AppendAllText(DefaultExceptionLogFilename, $"{timeStamp} {ex}" + Environment.NewLine);
			File.AppendAllText(DefaultExceptionLogFilename, Environment.NewLine);
		}
	}
}

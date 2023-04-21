using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WELSearchGUI
{
	static class Program
	{
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
				"Is terminating: {e.IsTerminating}." +
				Environment.NewLine +
				((Exception)e.ExceptionObject).ToString();

			MessageBox.Show(message, "Unhandled exception caught!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}

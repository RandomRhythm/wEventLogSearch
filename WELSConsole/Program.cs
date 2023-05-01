using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WELSCore;

namespace WELSConsole
{
	internal class Program
	{
		public static string LogFilenameException = "Log.Exceptions.txt";
		public static string LogFilenameOutput = "Log.Output.txt";

		static void Main(string[] args)
		{
			AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

			if (!string.IsNullOrWhiteSpace(Configuration.LogFile_Output))
			{
				LogFilenameOutput = Configuration.LogFile_Output;
			}
			if (!string.IsNullOrWhiteSpace(Configuration.LogFile_Exception))
			{
				LogFilenameException = Configuration.LogFile_Exception;
			}

			LogInformation("");
			LogInformation($"{AppDomain.CurrentDomain.FriendlyName} executed on: {DateTime.Now.ToLongDateString()} at {DateTime.Now.ToLongTimeString()}.");
			SearchParameters parameters = GetSearchParameters();
			LogInformation($"Configuration acquired from {AppDomain.CurrentDomain.FriendlyName}.config. Starting Search...");
			SearchCore.Search(parameters);
			LogInformation($"Search completed on {DateTime.Now.ToLongDateString()} at {DateTime.Now.ToLongTimeString()}. Exiting...");
		}

		private static SearchParameters GetSearchParameters()
		{
			SearchParameters result = new SearchParameters()
			{
				LogInformationFunction = LogInformation,
				LogErrorFunction = LogError,
				LogExceptionFunction = LogException,

				InputPath = StringTokenReplace.ReplaceTokens(Configuration.Path_Input),
				OutputPath = StringTokenReplace.ReplaceTokens(Configuration.Path_Output),

				EventIDs = Configuration.Search_EventIDs,
				Filter = Configuration.Search_Filter,
				ValueLocations = Configuration.Search_ValueLocations,
				TimeDifference = Configuration.Search_TimeDifference,

				InputIsSingleFile = Configuration.Bool_InputIsSingleFile,
				IncludeLogSource = Configuration.Bool_IncludeLogSource,
				GroupIntoOneColumn = Configuration.Bool_GroupIntoOneColumn
			};

			return result;
		}

		private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			LogException($"Global exception handler caught an exception! Is terminating: {e.IsTerminating}.", (Exception)e.ExceptionObject);
		}

		private static void LogInformation(string message)
		{
			Console.WriteLine(message);
			LogOutput(message);
		}

		private static void LogError(string message)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Error.WriteLine(message);
			Console.ResetColor();
			LogOutput(message);
		}

		private static void LogOutput(string message)
		{
			File.AppendAllText(LogFilenameOutput, message + Environment.NewLine);
		}

		private static void LogException(string message, Exception ex)
		{
			string timeStamp = $"[{DateTime.Now.ToLongDateString()} at {DateTime.Now.ToLongTimeString()}]:";
			LogError(message);
			LogError(ex.ToString());

			File.AppendAllText(LogFilenameException, $"{timeStamp} {message}" + Environment.NewLine);
			File.AppendAllText(LogFilenameException, $"{timeStamp} {ex}" + Environment.NewLine);
			File.AppendAllText(LogFilenameException, Environment.NewLine);
		}
	}
}

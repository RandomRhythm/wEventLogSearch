using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WELSConsole
{
	public static class Configuration
	{
		public static string LogFile_Output = ConfigurationReader.GetConfigurationValue<string>("LogFile.Output") ?? "Log.Output.txt";
		public static string LogFile_Exception = ConfigurationReader.GetConfigurationValue<string>("LogFile.Exception") ?? "Log.Exceptions.txt";

		public static string Path_Input = ConfigurationReader.GetConfigurationValue<string>("Path.Input") ?? "";
		public static string Path_Output = ConfigurationReader.GetConfigurationValue<string>("Path.Output") ?? "";

		public static string Search_EventIDs = ConfigurationReader.GetConfigurationValue<string>("Search.EventIDs") ?? "";
		public static string Search_Filter = ConfigurationReader.GetConfigurationValue<string>("Search.Filter") ?? "";
		public static string Search_ValueLocations = ConfigurationReader.GetConfigurationValue<string>("Search.ValueLocations") ?? "";
		public static long Search_TimeDifference = ConfigurationReader.GetConfigurationValue<long>("Search.TimeDifference");

		public static bool Bool_InputIsSingleFile = ConfigurationReader.GetConfigurationValue<bool>("Bool.InputIsSingleFile");
		public static bool Bool_IncludeLogSource = ConfigurationReader.GetConfigurationValue<bool>("Bool.IncludeLogSource");
		public static bool Bool_GroupIntoOneColumn = ConfigurationReader.GetConfigurationValue<bool>("Bool.GroupIntoOneColumn");
	}
}

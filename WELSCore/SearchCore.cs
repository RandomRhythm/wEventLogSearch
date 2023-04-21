using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WELSCore
{
	public static class SearchCore
	{
		public static void Search(SearchParameters parameters)
		{
			if (string.IsNullOrWhiteSpace(parameters.EventIDs))
			{
				parameters.LogErrorFunction("EventID can not be blank");
				return;
			}
			if (!File.Exists(parameters.InputPath) && !Directory.Exists(parameters.InputPath))
			{
				parameters.LogErrorFunction("Input event log file or folder does not exist: ");
				return;
			}
			if (!Directory.Exists(Path.GetDirectoryName(parameters.OutputPath)))
			{
				parameters.LogErrorFunction("Output directory does not exist: " + Path.GetDirectoryName(parameters.OutputPath));
				return;
			}
			int i = 0;
			if (!string.IsNullOrWhiteSpace(parameters.ValueLocations))
			{
				string chars = parameters.ValueLocations.Replace(" ", "").Replace(",", "");
				bool result = int.TryParse(chars, out i);
				if (result == false)
				{
					parameters.LogErrorFunction("Value locations must be an integer or comma separated integer list");
					return;
				}
			}

			int recordCount = 0;
			string searchString = "*";

			//set filters for query
			if (!string.IsNullOrWhiteSpace(parameters.EventIDs) && parameters.EventIDs != "*")
			{
				searchString = $"*[System[(EventID={parameters.EventIDs})";
			}

			if (parameters.TimeDifference != -1)
			{
				if (searchString.Contains("*[System["))
				{
					searchString = searchString + $" and TimeCreated[timediff(@SystemTime) &lt;= {parameters.TimeDifference}]";
				}
				else if (searchString.Contains("*") || searchString == "")
				{
					searchString = $"*[System[TimeCreated[timediff(@SystemTime) <= {parameters.TimeDifference}]";
				}
			}

			if (searchString.Contains("*[System["))
			{
				searchString = searchString + "]]";
			}

			if (parameters.InputIsSingleFile)
			{
				//List<EventRecord> foundRecords = EventLogHelper.SearchEventLogs(TxtBoxEvtFpath.Text, searchString);
				//recordCount = EventLogHelper.WriteEventRecords(foundRecords,  parameters.OutputDataFile, parameters.Filter, true, parameters.GroupIntoOneColumn);
				recordCount = EventLogHelper.SearchEventLog(parameters.InputPath, searchString, parameters.OutputPath, parameters.Filter, parameters.GroupIntoOneColumn, parameters.ValueLocations, parameters.IncludeLogSource);
				parameters.LogInformationFunction($"{recordCount} results were returned");
			}
			else
			{
				int recordsCount = 0;
				string[] fileEntries = Directory.GetFiles(parameters.InputPath);
				foreach (string fileName in fileEntries)
				{
					//List<EventRecord> foundRecords = EventLogHelper.SearchEventLogs(fileName, searchString);
					//recordCount = EventLogHelper.WriteEventRecords(foundRecords,  parameters.OutputDataFile, parameters.Filter, true, parameters.GroupIntoOneColumn);
					recordCount = EventLogHelper.SearchEventLog(fileName, searchString, parameters.OutputPath, parameters.Filter, parameters.GroupIntoOneColumn, parameters.ValueLocations, parameters.IncludeLogSource);
					recordsCount = recordsCount + recordCount;
				}
				parameters.LogInformationFunction($"{recordsCount} results were returned");
			}
		}
	}
}

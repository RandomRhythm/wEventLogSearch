using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WELSCore
{
	public class SearchParameters
	{
		public Action<string> LogInformationFunction { get; set; } = new Action<string>((s) => { });
		public Action<string> LogErrorFunction { get; set; } = new Action<string>((s) => { });
		public Action<string, Exception> LogExceptionFunction { get; set; } = new Action<string, Exception>((s, ex) => { });

		public string InputPath { get; set; }
		public string OutputPath { get; set; }

		public string EventIDs { get; set; }
		public string Filter { get; set; }
		public string ValueLocations { get; set; }
		public long TimeDifference { get; set; }

		public bool InputIsSingleFile { get; set; }
		public bool IncludeLogSource { get; set; }
		public bool GroupIntoOneColumn { get; set; }
	}
}

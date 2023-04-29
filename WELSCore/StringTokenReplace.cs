using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WELSCore
{
	public static class StringTokenReplace
	{
		public static Dictionary<string, Func<string>> SearchReplaceDictionary = new Dictionary<string, Func<string>>();

		static StringTokenReplace()
		{
			AddToken("{dddd}", new Func<string>(() => DateTime.Now.ToString("dddd")));
			AddToken("{ddd}", new Func<string>(() => DateTime.Now.ToString("ddd")));
			AddToken("{dd}", new Func<string>(() => DateTime.Now.ToString("dd")));
			AddToken("{MMMM}", new Func<string>(() => DateTime.Now.ToString("MMMM")));
			AddToken("{MMM}", new Func<string>(() => DateTime.Now.ToString("MMM")));
			AddToken("{MM}", new Func<string>(() => DateTime.Now.ToString("MM")));
			AddToken("{yyyy}", new Func<string>(() => DateTime.Now.ToString("yyyy")));
			AddToken("{yy}", new Func<string>(() => DateTime.Now.ToString("yy")));
			AddToken("{d}", new Func<string>(() => DateTime.Now.ToString("d")));
			AddToken("{D}", new Func<string>(() => DateTime.Now.ToString("D")));
			AddToken("{f}", new Func<string>(() => DateTime.Now.ToString("f")));
			AddToken("{F}", new Func<string>(() => DateTime.Now.ToString("F")));
			AddToken("{g}", new Func<string>(() => DateTime.Now.ToString("g")));
			AddToken("{G}", new Func<string>(() => DateTime.Now.ToString("G")));
			AddToken("{m}", new Func<string>(() => DateTime.Now.ToString("m")));
			AddToken("{r}", new Func<string>(() => DateTime.Now.ToString("r")));
			AddToken("{s}", new Func<string>(() => DateTime.Now.ToString("s")));
			AddToken("{t}", new Func<string>(() => DateTime.Now.ToString("t")));
			AddToken("{T}", new Func<string>(() => DateTime.Now.ToString("T")));
			AddToken("{u}", new Func<string>(() => DateTime.Now.ToString("u")));
			AddToken("{U}", new Func<string>(() => DateTime.Now.ToString("U")));
			AddToken("{y}", new Func<string>(() => DateTime.Now.ToString("y")));
		}

		public static void AddToken(string search, Func<string> getReplaceTextFunction)
		{
			SearchReplaceDictionary[search] = getReplaceTextFunction;
		}

		public static string ReplaceTokens(string input)
		{
			string result = input;

			if (result.Contains("{"))
			{
				foreach (KeyValuePair<string, Func<string>> kvp in SearchReplaceDictionary)
				{
					if (!result.Contains("{"))
					{
						break;
					}

					result = result.Replace(kvp.Key, kvp.Value());
				}
			}

			return result;
		}
	}
}

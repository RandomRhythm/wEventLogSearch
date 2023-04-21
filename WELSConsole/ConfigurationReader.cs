using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace WELSConsole
{
	public static class ConfigurationReader
	{
		public static T GetConfigurationValue<T>(string SettingName)
		{
			if (ConfigurationExists(SettingName))
			{
				T result = (T)Convert.ChangeType(ConfigurationManager.AppSettings[SettingName], typeof(T));
				if (result != null)
				{
					return result;
				}
			}
			return default(T);
		}

		public static bool ConfigurationExists(string SettingName)
		{
			if (
				!string.IsNullOrWhiteSpace(SettingName)
				&& ConfigurationManager.AppSettings.HasKeys()
				&& !string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings[SettingName])
				)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}

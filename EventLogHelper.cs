using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;


namespace wEventLogSearch
{
    class EventLogHelper
    {
        public static List<EventRecord> SearchEventLogs(string logLocation, string query)
        {
            List<EventRecord> results = new List<EventRecord>();
            EventLogQuery eventsQuery = new EventLogQuery(logLocation, PathType.FilePath, query);

            //try	{
            EventLogReader logReader = new EventLogReader(eventsQuery);
            for (EventRecord eventdetail = logReader.ReadEvent(); eventdetail != null; eventdetail = logReader.ReadEvent())
            {
                results.Add(eventdetail);

            }
            //} catch (EventLogNotFoundException e) { string errorString = e.ToString(); }

            return results;
        }

        public static int WriteEventRecords(List<EventRecord> records, string outputPath, string filterText, bool removeCrLf, bool groupProperties)
        {
            int recordsWritten = 0;
            string separateChar = "|";

            if (outputPath.Substring(outputPath.Length - 3, 3) == "csv")
            {
                separateChar = ",";
            }
            string propSeparateChar = separateChar;
            if (groupProperties == true)
            {
                propSeparateChar = " ";
            }
            foreach (EventRecord eventdetail in records)
            {
                string lineOutput = "";
                bool skipEntry = false;
                for (int intProperty = 0; intProperty < eventdetail.Properties.Count; intProperty++)
                {
                    string tmpPropValue = "";
                    skipEntry = false;
                    if (eventdetail.Properties[intProperty].Value.GetType().Equals(typeof(byte[])))
                    {
                        var testByte = new byte[] { };
                        testByte = (byte[])eventdetail.Properties[intProperty].Value;
                        if (testByte != null)
                        {
                            tmpPropValue = ConvertIPbytes(testByte); //ip address and port
                        }
                    }
                    else if (eventdetail.Properties[intProperty].Equals(typeof(int)))
                    {
                        tmpPropValue = eventdetail.Properties[intProperty].Value.ToString();
                    }
                    else
                    {
                        tmpPropValue = eventdetail.Properties[intProperty].Value.ToString();
                    }
                    if (tmpPropValue.Contains(System.Environment.NewLine))
                    {
                        tmpPropValue = tmpPropValue.Replace(System.Environment.NewLine, " ^ ");
                    }
                    if (lineOutput == "")
                    {
                        try
                        {
                            if (!string.IsNullOrEmpty(eventdetail.TaskDisplayName))
                            {
                                lineOutput = eventdetail.TimeCreated + separateChar + eventdetail.MachineName + separateChar + eventdetail.UserId + separateChar + eventdetail.Id + separateChar + eventdetail.ProviderName + separateChar + eventdetail.TaskDisplayName + separateChar + eventdetail.FormatDescription().Replace("\n", " ").Replace("\r", " ").Replace(",", " ") + separateChar + tmpPropValue.Replace(",", " ");
                            }
                        }
                        catch
                        {

                        }
                    }
                    else //already populated line out. Append with propSeparateChar
                    {
                        lineOutput = lineOutput + propSeparateChar + tmpPropValue.Replace(","," ");
                    }
                }
                if (!string.IsNullOrWhiteSpace(filterText) )
                {
                    if (!lineOutput.ToLower().Contains(filterText.ToLower()))
                    {
                        skipEntry = true;
                    }
                }
                if (removeCrLf == true)
                {
                    lineOutput = lineOutput.Replace("\n", "");
                }
                if (skipEntry == false && Directory.Exists(Path.GetDirectoryName(outputPath)) && lineOutput != "")//make sure directory was not provided
                {
                    bool written = false;
                    while (written == false) //AV locks file so we are just going to loop here
                    {

                    
                        try
                        {
                            File.AppendAllText(outputPath, lineOutput + "\n");
                                written = true;
                            }
                        catch(IOException e)
                        {
                            var errorCode = Marshal.GetHRForException(e) & ((1 << 16) - 1);

                            if (errorCode == 32 || errorCode == 33)
                            {
                                Thread.Sleep(2000);
                                written = false;
                            }
                        }

                        
                    }
                    if (File.Exists(outputPath))
                    {
                        recordsWritten++;
                    }
                }
                else if (skipEntry == false)
                {
                    break;
                }
            }
            return recordsWritten;
        }

        private static string ConvertIPbytes(byte[] IPbytes)
        {
            string strPort = "";
            int portNumber = 0;
            string strBytes = "";
            if (IPbytes.GetType().Equals(typeof(byte[])))
            {
                var testByte = new byte[] { };
                testByte = (byte[])IPbytes;
                if (testByte != null)
                {
                    for (int i = 3; i < testByte.Length; i++)
                    {
                        if (i == 3)
                        {
                            byte[] tmpPort = new byte[] { testByte[2], testByte[3] };
                            string portNumbers = BitConverter.ToString(tmpPort, 0);
                            portNumber = Int32.Parse(portNumbers.Replace("-", ""), System.Globalization.NumberStyles.HexNumber);
                            strPort = portNumber.ToString();
                        }
                        else if (strBytes == "")
                        {
                            strBytes = testByte[i].ToString();
                        }
                        else
                        {
                            strBytes = strBytes + "." + testByte[i].ToString();
                        }
                        
                    }
                    return strBytes.Replace(".0.0.0.0.0.0.0.0", "") + ":" + strPort; //ip address and port
                }
               
            }
            return "";
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace wEventLogSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            lblErrPath.Text = "";
            if (string.IsNullOrWhiteSpace(txtBoxEventID.ToString()))
            {
                lblResults.Text = "EventID can not be blank";
                return;
            }
            if (!File.Exists(TxtBoxEvtFpath.Text) && !Directory.Exists(TxtBoxEvtFpath.Text))
            {
                lblResults.Text = "Input event log file or folder does not exist: ";
                lblErrPath.Text = TxtBoxEvtFpath.Text;
                return;
            }
            if (!Directory.Exists(Path.GetDirectoryName(TxtBoxOutput.Text)))
            {
                lblResults.Text = "Output directory does not exist: " + Path.GetDirectoryName(TxtBoxOutput.Text);
                lblErrPath.Text = TxtBoxOutput.Text;
                return;
            }
            int recordCount = 0;
            string searchString = "*";

            string directorypath = TxtBoxEvtFpath.Text;
            string writeOutputpath = TxtBoxOutput.Text;
            string filterText = txtboxFilter.Text;
            bool boolGroupProperties = false;

            if (chkGroupProperties.Checked == true)
            {
                boolGroupProperties = true;
            }

            //set filters for query
            if (txtBoxEventID.Text != "" && txtBoxEventID.Text != "*")
            {
                searchString = "*[System[(EventID=" + txtBoxEventID.Text + ")" ;
            }
            if (txtBoxTimeDiff.Text != "")
            {
                long timeFilter = 0;
                string timeDiff = txtBoxTimeDiff.Text;
                bool canConvert = long.TryParse(timeDiff, out timeFilter);
                if (canConvert == true)
                {
                    if (searchString.Contains("*[System["))
                    {
                        searchString = searchString + " and TimeCreated[timediff(@SystemTime) &lt;= " + timeFilter.ToString() + "]";
                    }
                    else if(searchString.Contains("*") || searchString == "")
                    {
                        searchString = "*[System[TimeCreated[timediff(@SystemTime) <= " + timeFilter.ToString() + "]";
                    }
                }
            }
            if (searchString.Contains("*[System["))
            {
                searchString = searchString + "]]";
                    }

            if (radioFileFolder1.Checked == true)
            {
                List<EventRecord> foundRecords = EventLogHelper.SearchEventLogs(TxtBoxEvtFpath.Text, searchString);
                recordCount = EventLogHelper.WriteEventRecords(foundRecords, writeOutputpath, filterText, true, boolGroupProperties);

                lblResults.Text = $"{recordCount} results were returned";
            }
            else
            {
                int recordsCount = 0;
                string[] fileEntries = Directory.GetFiles(directorypath);
                foreach (string fileName in fileEntries)
                {
                    List<EventRecord> foundRecords = EventLogHelper.SearchEventLogs(fileName, searchString);
                    recordCount = EventLogHelper.WriteEventRecords(foundRecords, writeOutputpath, filterText, true, boolGroupProperties);
                    recordsCount = recordsCount + recordCount;
                }
                lblResults.Text = $"{recordsCount} results were returned";
            }
        }

        private void TxtBoxEvtFpath_TextChanged(object sender, EventArgs e)
        {

        }

        string lastInputDirectory = "C:\\";
        private void btnFilePath_Click(object sender, EventArgs e)
        {
            if (radioFileFolder1.Checked == true)
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.InitialDirectory = lastInputDirectory;
                openFileDialog1.Filter = "evt files (*.evt)|*.evt|evtx files (*.evtx)|*.evtx|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    TxtBoxEvtFpath.Text = openFileDialog1.FileName;
                    lastInputDirectory = Path.GetDirectoryName(openFileDialog1.FileName);
                }
            }
            else
            {
                FolderBrowserDialog folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
                folderBrowserDialog1.SelectedPath = lastOutputDirectory;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    TxtBoxEvtFpath.Text = folderBrowserDialog1.SelectedPath;
                    lastOutputDirectory = Path.GetDirectoryName(folderBrowserDialog1.SelectedPath);
                }
            }
        }

        string lastOutputDirectory = "C:\\";
        private void btnOutPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();

            SaveFileDialog1.InitialDirectory = lastInputDirectory;
            SaveFileDialog1.Filter = "text files (*.txt)|*.txt|csv files (*.csv)|*.csv|All files (*.*)|*.*";
            SaveFileDialog1.FilterIndex = 2;
            SaveFileDialog1.RestoreDirectory = true;

            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TxtBoxOutput.Text = SaveFileDialog1.FileName;
                lastInputDirectory = Path.GetDirectoryName(SaveFileDialog1.FileName);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

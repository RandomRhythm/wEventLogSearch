using WELSCore;

namespace WELSearchGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			long timeDiffMilliseconds = -1;
			if (!long.TryParse(txtBoxTimeDiff.Text, out timeDiffMilliseconds))
			{
				timeDiffMilliseconds = -1;
			}

			SearchParameters parameters = new SearchParameters()
			{
				LogInformationFunction = LogInformation,
				LogErrorFunction = LogError,
				LogExceptionFunction = Program.LogException,

				InputPath = StringTokenReplace.ReplaceTokens(txtBoxEvtFpath.Text),
				OutputPath = StringTokenReplace.ReplaceTokens(txtBoxOutput.Text),

				EventIDs = txtBoxEventID.Text,
				Filter = txtboxFilter.Text,
				ValueLocations = txtValueLocations.Text,
				TimeDifference = timeDiffMilliseconds,

				InputIsSingleFile = radioOptionFile.Checked,
				IncludeLogSource = chkIncludeLogSource.Checked,
				GroupIntoOneColumn = chkGroupProperties.Checked
			};

			LogError("");
			LogInformation("");

			SearchCore.Search(parameters);
		}

		private void LogInformation(string message)
		{
			lblResults.Text = message;
		}

		private void LogError(string message)
		{
			lblErrPath.Text = message;
		}

		string lastInputDirectory = "C:\\";
		string lastOutputDirectory = "C:\\";

		private void btnInFilePath_Click(object sender, EventArgs e)
		{
			if (radioOptionFile.Checked == true)
			{
				OpenFileDialog openFileDialog1 = new OpenFileDialog();

				openFileDialog1.InitialDirectory = lastInputDirectory;
				openFileDialog1.Filter = "evt files (*.evt)|*.evt|evtx files (*.evtx)|*.evtx|All files (*.*)|*.*";
				openFileDialog1.FilterIndex = 2;
				openFileDialog1.RestoreDirectory = true;
				openFileDialog1.CheckFileExists = false;

				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					txtBoxEvtFpath.Text = openFileDialog1.FileName;
					lastInputDirectory = Path.GetDirectoryName(openFileDialog1.FileName);
				}
			}
			else
			{
				FolderBrowserDialog folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
				folderBrowserDialog1.SelectedPath = lastInputDirectory;
				if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
				{
					txtBoxEvtFpath.Text = folderBrowserDialog1.SelectedPath;
					lastInputDirectory = Path.GetDirectoryName(folderBrowserDialog1.SelectedPath);
				}
			}
		}

		private void btnOutFilePath_Click(object sender, EventArgs e)
		{
			SaveFileDialog SaveFileDialog1 = new SaveFileDialog();

			SaveFileDialog1.InitialDirectory = lastOutputDirectory;
			SaveFileDialog1.Filter = "text files (*.txt)|*.txt|csv files (*.csv)|*.csv|All files (*.*)|*.*";
			SaveFileDialog1.FilterIndex = 2;
			SaveFileDialog1.RestoreDirectory = true;

			if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				txtBoxOutput.Text = SaveFileDialog1.FileName;
				lastOutputDirectory = Path.GetDirectoryName(SaveFileDialog1.FileName);
			}
		}
	}
}

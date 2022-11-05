namespace wEventLogSearch
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtBoxEventID = new System.Windows.Forms.TextBox();
            this.TxtBoxEvtFpath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblErrPath = new System.Windows.Forms.Label();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.btnOutPath = new System.Windows.Forms.Button();
            this.radioFileFolder1 = new System.Windows.Forms.RadioButton();
            this.radioFileFolder2 = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtboxFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkGroupProperties = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxTimeDiff = new System.Windows.Forms.TextBox();
            this.txtValueLocations = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkIncludeLogSource = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(91, 285);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 22;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtBoxEventID
            // 
            this.txtBoxEventID.Location = new System.Drawing.Point(81, 43);
            this.txtBoxEventID.Name = "txtBoxEventID";
            this.txtBoxEventID.Size = new System.Drawing.Size(495, 20);
            this.txtBoxEventID.TabIndex = 1;
            this.txtBoxEventID.Text = "4689 or EventID=4688";
            // 
            // TxtBoxEvtFpath
            // 
            this.TxtBoxEvtFpath.Location = new System.Drawing.Point(32, 107);
            this.TxtBoxEvtFpath.Name = "TxtBoxEvtFpath";
            this.TxtBoxEvtFpath.Size = new System.Drawing.Size(544, 20);
            this.TxtBoxEvtFpath.TabIndex = 4;
            this.TxtBoxEvtFpath.TextChanged += new System.EventHandler(this.TxtBoxEvtFpath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Event Log File Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "EventID=";
            // 
            // TxtBoxOutput
            // 
            this.TxtBoxOutput.Location = new System.Drawing.Point(118, 142);
            this.TxtBoxOutput.Name = "TxtBoxOutput";
            this.TxtBoxOutput.Size = new System.Drawing.Size(458, 20);
            this.TxtBoxOutput.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output File Path";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(183, 290);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(195, 13);
            this.lblResults.TabIndex = 7;
            this.lblResults.Text = "Hit Search button when ready to search";
            // 
            // lblErrPath
            // 
            this.lblErrPath.AutoSize = true;
            this.lblErrPath.Location = new System.Drawing.Point(183, 270);
            this.lblErrPath.Name = "lblErrPath";
            this.lblErrPath.Size = new System.Drawing.Size(0, 13);
            this.lblErrPath.TabIndex = 8;
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(582, 106);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(75, 20);
            this.btnFilePath.TabIndex = 5;
            this.btnFilePath.Text = "Browse";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // btnOutPath
            // 
            this.btnOutPath.Location = new System.Drawing.Point(582, 142);
            this.btnOutPath.Name = "btnOutPath";
            this.btnOutPath.Size = new System.Drawing.Size(75, 20);
            this.btnOutPath.TabIndex = 7;
            this.btnOutPath.Text = "Browse";
            this.btnOutPath.UseVisualStyleBackColor = true;
            this.btnOutPath.Click += new System.EventHandler(this.btnOutPath_Click);
            // 
            // radioFileFolder1
            // 
            this.radioFileFolder1.AutoSize = true;
            this.radioFileFolder1.Checked = true;
            this.radioFileFolder1.Location = new System.Drawing.Point(135, 87);
            this.radioFileFolder1.Name = "radioFileFolder1";
            this.radioFileFolder1.Size = new System.Drawing.Size(41, 17);
            this.radioFileFolder1.TabIndex = 2;
            this.radioFileFolder1.TabStop = true;
            this.radioFileFolder1.Text = "File";
            this.radioFileFolder1.UseVisualStyleBackColor = true;
            // 
            // radioFileFolder2
            // 
            this.radioFileFolder2.AutoSize = true;
            this.radioFileFolder2.Location = new System.Drawing.Point(182, 87);
            this.radioFileFolder2.Name = "radioFileFolder2";
            this.radioFileFolder2.Size = new System.Drawing.Size(54, 17);
            this.radioFileFolder2.TabIndex = 3;
            this.radioFileFolder2.Text = "Folder";
            this.radioFileFolder2.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // txtboxFilter
            // 
            this.txtboxFilter.Location = new System.Drawing.Point(89, 190);
            this.txtboxFilter.Name = "txtboxFilter";
            this.txtboxFilter.Size = new System.Drawing.Size(487, 20);
            this.txtboxFilter.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Filter Text";
            // 
            // chkGroupProperties
            // 
            this.chkGroupProperties.AutoSize = true;
            this.chkGroupProperties.Location = new System.Drawing.Point(33, 167);
            this.chkGroupProperties.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkGroupProperties.Name = "chkGroupProperties";
            this.chkGroupProperties.Size = new System.Drawing.Size(203, 17);
            this.chkGroupProperties.TabIndex = 8;
            this.chkGroupProperties.Text = "Group event properties in one column";
            this.chkGroupProperties.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Time to go back in miliseconds";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtBoxTimeDiff
            // 
            this.txtBoxTimeDiff.Location = new System.Drawing.Point(186, 243);
            this.txtBoxTimeDiff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxTimeDiff.Name = "txtBoxTimeDiff";
            this.txtBoxTimeDiff.Size = new System.Drawing.Size(150, 20);
            this.txtBoxTimeDiff.TabIndex = 17;
            // 
            // txtValueLocations
            // 
            this.txtValueLocations.Location = new System.Drawing.Point(186, 218);
            this.txtValueLocations.Name = "txtValueLocations";
            this.txtValueLocations.Size = new System.Drawing.Size(227, 20);
            this.txtValueLocations.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Output certain value locations";
            // 
            // chkIncludeLogSource
            // 
            this.chkIncludeLogSource.AutoSize = true;
            this.chkIncludeLogSource.Checked = true;
            this.chkIncludeLogSource.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeLogSource.Location = new System.Drawing.Point(241, 167);
            this.chkIncludeLogSource.Margin = new System.Windows.Forms.Padding(2);
            this.chkIncludeLogSource.Name = "chkIncludeLogSource";
            this.chkIncludeLogSource.Size = new System.Drawing.Size(137, 17);
            this.chkIncludeLogSource.TabIndex = 9;
            this.chkIncludeLogSource.Text = "Include log source data";
            this.chkIncludeLogSource.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 358);
            this.Controls.Add(this.chkIncludeLogSource);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValueLocations);
            this.Controls.Add(this.txtBoxTimeDiff);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkGroupProperties);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxFilter);
            this.Controls.Add(this.radioFileFolder2);
            this.Controls.Add(this.radioFileFolder1);
            this.Controls.Add(this.btnOutPath);
            this.Controls.Add(this.btnFilePath);
            this.Controls.Add(this.lblErrPath);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBoxOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxEvtFpath);
            this.Controls.Add(this.txtBoxEventID);
            this.Controls.Add(this.BtnSearch);
            this.Name = "Form1";
            this.Text = "Event Log Parse To Text";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox txtBoxEventID;
        private System.Windows.Forms.TextBox TxtBoxEvtFpath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblErrPath;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.Button btnOutPath;
        private System.Windows.Forms.RadioButton radioFileFolder1;
        private System.Windows.Forms.RadioButton radioFileFolder2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtboxFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkGroupProperties;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxTimeDiff;
        private System.Windows.Forms.TextBox txtValueLocations;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkIncludeLogSource;
    }
}


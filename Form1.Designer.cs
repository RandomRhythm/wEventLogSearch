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
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(157, 338);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(100, 28);
            this.BtnSearch.TabIndex = 0;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtBoxEventID
            // 
            this.txtBoxEventID.Location = new System.Drawing.Point(108, 53);
            this.txtBoxEventID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEventID.Name = "txtBoxEventID";
            this.txtBoxEventID.Size = new System.Drawing.Size(659, 22);
            this.txtBoxEventID.TabIndex = 1;
            this.txtBoxEventID.Text = "4689 or EventID=4688";
            // 
            // TxtBoxEvtFpath
            // 
            this.TxtBoxEvtFpath.Location = new System.Drawing.Point(43, 132);
            this.TxtBoxEvtFpath.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBoxEvtFpath.Name = "TxtBoxEvtFpath";
            this.TxtBoxEvtFpath.Size = new System.Drawing.Size(724, 22);
            this.TxtBoxEvtFpath.TabIndex = 2;
            this.TxtBoxEvtFpath.TextChanged += new System.EventHandler(this.TxtBoxEvtFpath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Event Log File Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "EventID=";
            // 
            // TxtBoxOutput
            // 
            this.TxtBoxOutput.Location = new System.Drawing.Point(157, 175);
            this.TxtBoxOutput.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBoxOutput.Name = "TxtBoxOutput";
            this.TxtBoxOutput.Size = new System.Drawing.Size(609, 22);
            this.TxtBoxOutput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output File Path";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(280, 344);
            this.lblResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(258, 17);
            this.lblResults.TabIndex = 7;
            this.lblResults.Text = "Hit Search button when ready to search";
            // 
            // lblErrPath
            // 
            this.lblErrPath.AutoSize = true;
            this.lblErrPath.Location = new System.Drawing.Point(280, 286);
            this.lblErrPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrPath.Name = "lblErrPath";
            this.lblErrPath.Size = new System.Drawing.Size(0, 17);
            this.lblErrPath.TabIndex = 8;
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(776, 130);
            this.btnFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(100, 25);
            this.btnFilePath.TabIndex = 9;
            this.btnFilePath.Text = "Browse";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // btnOutPath
            // 
            this.btnOutPath.Location = new System.Drawing.Point(776, 175);
            this.btnOutPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnOutPath.Name = "btnOutPath";
            this.btnOutPath.Size = new System.Drawing.Size(100, 25);
            this.btnOutPath.TabIndex = 10;
            this.btnOutPath.Text = "Browse";
            this.btnOutPath.UseVisualStyleBackColor = true;
            this.btnOutPath.Click += new System.EventHandler(this.btnOutPath_Click);
            // 
            // radioFileFolder1
            // 
            this.radioFileFolder1.AutoSize = true;
            this.radioFileFolder1.Checked = true;
            this.radioFileFolder1.Location = new System.Drawing.Point(180, 107);
            this.radioFileFolder1.Margin = new System.Windows.Forms.Padding(4);
            this.radioFileFolder1.Name = "radioFileFolder1";
            this.radioFileFolder1.Size = new System.Drawing.Size(51, 21);
            this.radioFileFolder1.TabIndex = 11;
            this.radioFileFolder1.TabStop = true;
            this.radioFileFolder1.Text = "File";
            this.radioFileFolder1.UseVisualStyleBackColor = true;
            // 
            // radioFileFolder2
            // 
            this.radioFileFolder2.AutoSize = true;
            this.radioFileFolder2.Location = new System.Drawing.Point(243, 107);
            this.radioFileFolder2.Margin = new System.Windows.Forms.Padding(4);
            this.radioFileFolder2.Name = "radioFileFolder2";
            this.radioFileFolder2.Size = new System.Drawing.Size(69, 21);
            this.radioFileFolder2.TabIndex = 12;
            this.radioFileFolder2.Text = "Folder";
            this.radioFileFolder2.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // txtboxFilter
            // 
            this.txtboxFilter.Location = new System.Drawing.Point(157, 231);
            this.txtboxFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxFilter.Name = "txtboxFilter";
            this.txtboxFilter.Size = new System.Drawing.Size(301, 22);
            this.txtboxFilter.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Filter Text";
            // 
            // chkGroupProperties
            // 
            this.chkGroupProperties.AutoSize = true;
            this.chkGroupProperties.Location = new System.Drawing.Point(159, 204);
            this.chkGroupProperties.Name = "chkGroupProperties";
            this.chkGroupProperties.Size = new System.Drawing.Size(269, 21);
            this.chkGroupProperties.TabIndex = 15;
            this.chkGroupProperties.Text = "Group event properties in one column";
            this.chkGroupProperties.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Time to go back in miliseconds";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtBoxTimeDiff
            // 
            this.txtBoxTimeDiff.Location = new System.Drawing.Point(42, 286);
            this.txtBoxTimeDiff.Name = "txtBoxTimeDiff";
            this.txtBoxTimeDiff.Size = new System.Drawing.Size(199, 22);
            this.txtBoxTimeDiff.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 440);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}


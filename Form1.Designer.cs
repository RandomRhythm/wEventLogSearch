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
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(118, 214);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 0;
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
            this.TxtBoxEvtFpath.TabIndex = 2;
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
            this.TxtBoxOutput.TabIndex = 5;
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
            this.lblResults.Location = new System.Drawing.Point(210, 219);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(195, 13);
            this.lblResults.TabIndex = 7;
            this.lblResults.Text = "Hit Search button when ready to search";
            // 
            // lblErrPath
            // 
            this.lblErrPath.AutoSize = true;
            this.lblErrPath.Location = new System.Drawing.Point(210, 232);
            this.lblErrPath.Name = "lblErrPath";
            this.lblErrPath.Size = new System.Drawing.Size(0, 13);
            this.lblErrPath.TabIndex = 8;
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(582, 106);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(75, 20);
            this.btnFilePath.TabIndex = 9;
            this.btnFilePath.Text = "Browse";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // btnOutPath
            // 
            this.btnOutPath.Location = new System.Drawing.Point(582, 142);
            this.btnOutPath.Name = "btnOutPath";
            this.btnOutPath.Size = new System.Drawing.Size(75, 20);
            this.btnOutPath.TabIndex = 10;
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
            this.radioFileFolder1.TabIndex = 11;
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
            this.txtboxFilter.Location = new System.Drawing.Point(118, 168);
            this.txtboxFilter.Name = "txtboxFilter";
            this.txtboxFilter.Size = new System.Drawing.Size(227, 20);
            this.txtboxFilter.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Filter Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 262);
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
    }
}


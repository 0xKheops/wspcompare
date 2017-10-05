namespace WSPCompare
{
    partial class WSPCompareTool
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            WSPCompare.Business.WSPCompareFile wspCompareFile1 = new WSPCompare.Business.WSPCompareFile();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.tabDetails = new System.Windows.Forms.TabPage();
            this.wspCompareSummary1 = new WSPCompare.WSPCompareSummary();
            this.wspFileDetails1 = new WSPCompare.WSPFileDetails();
            this.tabControl1.SuspendLayout();
            this.tabSummary.SuspendLayout();
            this.tabDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSummary);
            this.tabControl1.Controls.Add(this.tabDetails);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 668);
            this.tabControl1.TabIndex = 1;
            // 
            // tabSummary
            // 
            this.tabSummary.Controls.Add(this.wspCompareSummary1);
            this.tabSummary.Location = new System.Drawing.Point(4, 22);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSummary.Size = new System.Drawing.Size(786, 642);
            this.tabSummary.TabIndex = 0;
            this.tabSummary.Text = "Summary";
            this.tabSummary.UseVisualStyleBackColor = true;
            // 
            // tabDetails
            // 
            this.tabDetails.Controls.Add(this.wspFileDetails1);
            this.tabDetails.Location = new System.Drawing.Point(4, 22);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetails.Size = new System.Drawing.Size(786, 642);
            this.tabDetails.TabIndex = 1;
            this.tabDetails.Text = "Details";
            this.tabDetails.UseVisualStyleBackColor = true;
            // 
            // wspCompareSummary1
            // 
            this.wspCompareSummary1.DataSource = null;
            this.wspCompareSummary1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wspCompareSummary1.Location = new System.Drawing.Point(3, 3);
            this.wspCompareSummary1.Name = "wspCompareSummary1";
            this.wspCompareSummary1.Size = new System.Drawing.Size(780, 636);
            this.wspCompareSummary1.TabIndex = 0;
            this.wspCompareSummary1.SelectionChanged += new System.EventHandler<WSPCompare.Business.WSPCompareFileEventArgs>(this.wspCompareSummary1_SelectionChanged);
            this.wspCompareSummary1.ShowDetails += new System.EventHandler(this.wspCompareSummary1_ShowDetails);
            // 
            // wspFileDetails1
            // 
            this.wspFileDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            wspCompareFile1.FilePathAfter = null;
            wspCompareFile1.FilePathBefore = null;
            wspCompareFile1.FilePathRelative = null;
            wspCompareFile1.FileSizeAfter = ((long)(0));
            wspCompareFile1.FileSizeBefore = ((long)(0));
            wspCompareFile1.Status = WSPCompare.Business.WSPCompareFileStatus.Deleted;
            this.wspFileDetails1.File = wspCompareFile1;
            this.wspFileDetails1.Location = new System.Drawing.Point(3, 3);
            this.wspFileDetails1.Name = "wspFileDetails1";
            this.wspFileDetails1.Size = new System.Drawing.Size(780, 636);
            this.wspFileDetails1.TabIndex = 0;
            // 
            // WSPCompareTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "WSPCompareTool";
            this.Size = new System.Drawing.Size(794, 668);
            this.tabControl1.ResumeLayout(false);
            this.tabSummary.ResumeLayout(false);
            this.tabDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSummary;
        private WSPCompareSummary wspCompareSummary1;
        private System.Windows.Forms.TabPage tabDetails;
        private WSPFileDetails wspFileDetails1;
    }
}

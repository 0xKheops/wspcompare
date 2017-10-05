namespace WSPCompare
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
            this.gbFiles = new System.Windows.Forms.GroupBox();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.wspCompareTool1 = new WSPCompare.WSPCompareTool();
            this.wspExplorerTool1 = new WSPCompare.WSPExplorerTool();
            this.wspSelector2 = new WSPCompare.WSPSelector();
            this.wspSelector1 = new WSPCompare.WSPSelector();
            this.gbFiles.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiles
            // 
            this.gbFiles.Controls.Add(this.wspSelector2);
            this.gbFiles.Controls.Add(this.wspSelector1);
            this.gbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFiles.Location = new System.Drawing.Point(5, 5);
            this.gbFiles.Margin = new System.Windows.Forms.Padding(10);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.Size = new System.Drawing.Size(730, 75);
            this.gbFiles.TabIndex = 0;
            this.gbFiles.TabStop = false;
            this.gbFiles.Text = "Files";
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.gbFiles);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOptions.Location = new System.Drawing.Point(0, 0);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Padding = new System.Windows.Forms.Padding(5);
            this.pnlOptions.Size = new System.Drawing.Size(740, 85);
            this.pnlOptions.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.wspCompareTool1);
            this.pnlMain.Controls.Add(this.wspExplorerTool1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 85);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(740, 499);
            this.pnlMain.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 584);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(740, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(359, 17);
            this.toolStripStatusLabel1.Text = "Created by Arnault Nouvel - http://blogs.developpeur.org/anouvel";
            // 
            // wspCompareTool1
            // 
            this.wspCompareTool1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wspCompareTool1.Location = new System.Drawing.Point(0, 0);
            this.wspCompareTool1.Name = "wspCompareTool1";
            this.wspCompareTool1.Size = new System.Drawing.Size(740, 499);
            this.wspCompareTool1.TabIndex = 1;
            this.wspCompareTool1.Visible = false;
            // 
            // wspExplorerTool1
            // 
            this.wspExplorerTool1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wspExplorerTool1.Location = new System.Drawing.Point(0, 0);
            this.wspExplorerTool1.Name = "wspExplorerTool1";
            this.wspExplorerTool1.PackageDirectory = null;
            this.wspExplorerTool1.Size = new System.Drawing.Size(740, 499);
            this.wspExplorerTool1.TabIndex = 0;
            this.wspExplorerTool1.Visible = false;
            // 
            // wspSelector2
            // 
            this.wspSelector2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wspSelector2.ExtractDirectory = null;
            this.wspSelector2.FilePath = "";
            this.wspSelector2.Label = "Package 2 :";
            this.wspSelector2.Location = new System.Drawing.Point(3, 40);
            this.wspSelector2.Name = "wspSelector2";
            this.wspSelector2.Size = new System.Drawing.Size(724, 32);
            this.wspSelector2.TabIndex = 1;
            this.wspSelector2.TempDirectory = null;
            this.wspSelector2.SelectionChanged += new System.EventHandler(this.wspSelector2_SelectionChanged);
            // 
            // wspSelector1
            // 
            this.wspSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.wspSelector1.ExtractDirectory = null;
            this.wspSelector1.FilePath = "";
            this.wspSelector1.Label = "Package 1 :";
            this.wspSelector1.Location = new System.Drawing.Point(3, 16);
            this.wspSelector1.Name = "wspSelector1";
            this.wspSelector1.Size = new System.Drawing.Size(724, 24);
            this.wspSelector1.TabIndex = 0;
            this.wspSelector1.TempDirectory = null;
            this.wspSelector1.SelectionChanged += new System.EventHandler(this.wspSelector1_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 606);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlOptions);
            this.Name = "Form1";
            this.Text = "WSPCompare";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.gbFiles.ResumeLayout(false);
            this.pnlOptions.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiles;
        private System.Windows.Forms.Panel pnlOptions;
        private WSPSelector wspSelector2;
        private WSPSelector wspSelector1;
        private System.Windows.Forms.Panel pnlMain;
        private WSPExplorerTool wspExplorerTool1;
        private WSPCompareTool wspCompareTool1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}


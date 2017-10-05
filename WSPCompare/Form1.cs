using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace WSPCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            wspSelector1.TempDirectory = TempDirectory;
            wspSelector2.TempDirectory = TempDirectory;

            this.Text = "WSPCompare v" + Assembly.GetExecutingAssembly().GetName().Version.ToString();

        }

        #region Fields

        private DirectoryInfo _tempDirectory = null;

        #endregion

        #region Properties

        protected DirectoryInfo TempDirectory
        {
            get
            {
                if (_tempDirectory == null)
                {
                    DirectoryInfo systemTmpDir = new DirectoryInfo(Path.GetTempPath());
                    _tempDirectory = systemTmpDir.CreateSubdirectory("WSPCompare." + Path.GetRandomFileName());
                }
                return _tempDirectory;
            }
        }

        #endregion

        #region Events Handling

        private void wspSelector1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DisplayPackages();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wspSelector2_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DisplayPackages();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Controls.Clear();

                //cleanup
                TempDirectory.Delete(true);
            }
            catch { }
        }

        #endregion

        #region Methods

        private void DisplayPackages()
        {
            if (wspSelector1.ExtractDirectory != null && wspSelector2.ExtractDirectory != null)
                ShowCompareTool();
            else
                ShowExplorerTool();
        }

        private void ShowExplorerTool()
        {

            wspExplorerTool1.PackageDirectory = null;

            if (wspSelector1.ExtractDirectory != null)
                wspExplorerTool1.PackageDirectory = wspSelector1.ExtractDirectory;
            else if (wspSelector2.ExtractDirectory != null)
                wspExplorerTool1.PackageDirectory = wspSelector2.ExtractDirectory;

            wspExplorerTool1.Visible = true;

            wspCompareTool1.Visible = false;
            wspCompareTool1.Clear();

        }

        private void ShowCompareTool()
        {

            wspExplorerTool1.Visible = false;
            wspExplorerTool1.PackageDirectory = null;

            wspCompareTool1.Compare(wspSelector1.ExtractDirectory, wspSelector2.ExtractDirectory);
            wspCompareTool1.Visible = true;

        }

        public void OpenPackage(String filePath1, String filePath2)
        {
            wspSelector1.FilePath = filePath1;
            wspSelector2.FilePath = filePath2;
        }

        #endregion


    }
}

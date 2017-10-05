using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using WSPCompare.Business;

namespace WSPCompare
{
    public partial class WSPSelector : UserControl
    {
        public WSPSelector()
        {
            InitializeComponent();
        }

        #region Fields

        private DirectoryInfo _tempDirectory = null;
        private DirectoryInfo _extractPath = null;

        public event EventHandler SelectionChanged;

        #endregion

        #region Properties

        public DirectoryInfo TempDirectory
        {
            get { return _tempDirectory; }
            set { _tempDirectory = value; }
        }

        public DirectoryInfo ExtractDirectory
        {
            get { return _extractPath; }
            set { _extractPath = value; }
        }

        public String Label
        {
            get { return lblWSP.Text; }
            set { lblWSP.Text = value; }
        }

        public String FilePath
        {
            get { return txbFilePath.Text; }
            set { txbFilePath.Text = value; }
        }

        #endregion

        #region Behavior

        private void txbFilePath_TextChanged(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(FilePath))
            {
                ExtractDirectory = null;
                btnOpen.Enabled = false;
            }
            else
            {
                ExtractDirectory = WSPCompareHelper.Extract(FilePath, TempDirectory, Path.GetRandomFileName());
                btnOpen.Enabled = true;
            }

            if (SelectionChanged != null)
                SelectionChanged(this, EventArgs.Empty);

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFileDialog1.FileName;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Process.Start(ExtractDirectory.FullName);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FilePath = String.Empty;
        }

        #endregion

    }
}

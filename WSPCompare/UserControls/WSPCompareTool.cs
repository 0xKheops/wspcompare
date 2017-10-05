using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WSPCompare.Business;

namespace WSPCompare
{
    public partial class WSPCompareTool : UserControl
    {
        public WSPCompareTool()
        {
            InitializeComponent();
        }

        #region Methods

        public void Clear()
        {
            wspCompareSummary1.DataSource = null;
            wspFileDetails1.File = null;
        }

        public void Compare(DirectoryInfo di1, DirectoryInfo di2)
        {
            wspCompareSummary1.DataSource = WSPCompareHelper.Compare(di1, di2);
        }

        #endregion

        #region Behavior

        private void wspCompareSummary1_SelectionChanged(object sender, WSPCompareFileEventArgs e)
        {
            wspFileDetails1.File = e.File;
        }

        private void wspCompareSummary1_ShowDetails(object sender, EventArgs e)
        {
            tabDetails.Select();
            tabControl1.SelectTab(tabDetails);
        }

        #endregion

    }
}

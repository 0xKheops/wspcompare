using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using WSPCompare.Business;

namespace WSPCompare
{
    public partial class WSPFileDetails : UserControl
    {
        public WSPFileDetails()
        {
            InitializeComponent();
        }

        #region Fields

        private WSPCompareFile _file = new WSPCompareFile();

        #endregion

        #region Properties

        public WSPCompareFile File
        {
            get { return _file; }
            set
            {
                if (value != null)
                {
                    Reset();
                    _file = value;
                }
                if (!DesignMode)
                    wSPCompareFileBindingSource.DataSource = _file;
            }
        }

        #endregion

        #region Methods

        private void Reset()
        {
            fileBrowser1.Clear();
            fileBrowser2.Clear();
        }

        #endregion

    }
}

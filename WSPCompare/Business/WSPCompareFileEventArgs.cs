using System;
using System.Collections.Generic;
using System.Text;

namespace WSPCompare.Business
{
    public class WSPCompareFileEventArgs : EventArgs
    {
      
        public WSPCompareFileEventArgs(WSPCompareFile file)
        {
            _file = file;
        }

        #region Fields

        private WSPCompareFile _file;

        #endregion

        #region Properties

        public WSPCompareFile File
        {
            get { return _file; }
        }

        #endregion

    }
}

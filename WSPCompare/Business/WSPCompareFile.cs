using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WSPCompare.Business
{
    public class WSPCompareFile
    {

        public WSPCompareFile()
        {

        }

        #region Fields

        private WSPCompareFileStatus _status = WSPCompareFileStatus.Deleted;
        private String _filePathRelative = null;
        private String _filePathBefore = null;
        private String _filePathAfter = null;
        private Int64 _fileSizeBefore = 0;
        private Int64 _fileSizeAfter = 0;

        #endregion

        #region Properties

        public WSPCompareFileStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public String FilePathRelative
        {
            get { return _filePathRelative; }
            set { _filePathRelative = value; }
        }


        public String FilePathBefore
        {
            get { return _filePathBefore; }
            set { _filePathBefore = value; }
        }

        public String FilePathAfter
        {
            get { return _filePathAfter; }
            set { _filePathAfter = value; }
        }

        public Int64 FileSizeBefore
        {
            get { return _fileSizeBefore; }
            set { _fileSizeBefore = value; }
        }

        public Int64 FileSizeAfter
        {
            get { return _fileSizeAfter; }
            set { _fileSizeAfter = value; }
        }

        #endregion

    }
}

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
    public partial class WSPCompareSummary : UserControl
    {
        public WSPCompareSummary()
        {
            InitializeComponent();
        }

        #region Fields

        public event EventHandler<WSPCompareFileEventArgs> SelectionChanged;
        public event EventHandler ShowDetails;

        #endregion

        #region Properties

        public List<WSPCompareFile> DataSource
        {
            get { return dataGridView1.DataSource as List<WSPCompareFile>; }
            set
            {
                dataGridView1.DataSource = value;
                dataGridView1.ClearSelection();
            }
        }

        #endregion

        #region Behavior

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            WSPCompareFileStatus status = DataSource[e.RowIndex].Status;
            Color color = Color.Black;

            switch (status)
            {
                case WSPCompareFileStatus.Deleted:
                    color = Color.Red;
                    break;
                case WSPCompareFileStatus.New:
                    color = Color.Green;
                    break;
                case WSPCompareFileStatus.Modified:
                    color = Color.Orange;
                    break;
                case WSPCompareFileStatus.Equal:
                    color = Color.Black;
                    break;
            }

            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = color;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns[0].Index)
            {
                WSPCompareFile file = DataSource[e.RowIndex];
                String filePath = String.IsNullOrEmpty(file.FilePathAfter) ? file.FilePathBefore : file.FilePathAfter;
                Icon icon = System.Drawing.Icon.ExtractAssociatedIcon(filePath);
                e.Value = ResizeBitmap(icon.ToBitmap(), 16, 16);
            }
        }

        public Bitmap ResizeBitmap(Bitmap b, int nWidth, int nHeight)
        {
            Bitmap result = new Bitmap(nWidth, nHeight);
            using (Graphics g = Graphics.FromImage((Image)result))
                g.DrawImage(b, 0, 0, nWidth, nHeight);
            return result;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectionChanged != null)
            {
                WSPCompareFile file = dataGridView1.SelectedRows.Count > 0?dataGridView1.SelectedRows[0].DataBoundItem as WSPCompareFile: null;
                WSPCompareFileEventArgs args = new WSPCompareFileEventArgs(file);
                SelectionChanged(this, args);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (ShowDetails != null)
                ShowDetails(this, EventArgs.Empty);
        }

        #endregion

    }
}

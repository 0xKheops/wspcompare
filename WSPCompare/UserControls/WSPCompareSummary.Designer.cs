namespace WSPCompare
{
    partial class WSPCompareSummary
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IconDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.filePathRelativeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSizeBeforeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSizeAfterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IconDataGridViewImageColumn,
            this.filePathRelativeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.fileSizeBeforeDataGridViewTextBoxColumn,
            this.fileSizeAfterDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(737, 569);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // IconDataGridViewImageColumn
            // 
            this.IconDataGridViewImageColumn.HeaderText = "";
            this.IconDataGridViewImageColumn.MinimumWidth = 20;
            this.IconDataGridViewImageColumn.Name = "IconDataGridViewImageColumn";
            this.IconDataGridViewImageColumn.ReadOnly = true;
            this.IconDataGridViewImageColumn.Width = 20;
            // 
            // filePathRelativeDataGridViewTextBoxColumn
            // 
            this.filePathRelativeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.filePathRelativeDataGridViewTextBoxColumn.DataPropertyName = "FilePathRelative";
            this.filePathRelativeDataGridViewTextBoxColumn.HeaderText = "Path";
            this.filePathRelativeDataGridViewTextBoxColumn.Name = "filePathRelativeDataGridViewTextBoxColumn";
            this.filePathRelativeDataGridViewTextBoxColumn.ReadOnly = true;
            this.filePathRelativeDataGridViewTextBoxColumn.Width = 54;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 62;
            // 
            // fileSizeBeforeDataGridViewTextBoxColumn
            // 
            this.fileSizeBeforeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fileSizeBeforeDataGridViewTextBoxColumn.DataPropertyName = "FileSizeBefore";
            this.fileSizeBeforeDataGridViewTextBoxColumn.HeaderText = "Size 1";
            this.fileSizeBeforeDataGridViewTextBoxColumn.Name = "fileSizeBeforeDataGridViewTextBoxColumn";
            this.fileSizeBeforeDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileSizeBeforeDataGridViewTextBoxColumn.Width = 61;
            // 
            // fileSizeAfterDataGridViewTextBoxColumn
            // 
            this.fileSizeAfterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fileSizeAfterDataGridViewTextBoxColumn.DataPropertyName = "FileSizeAfter";
            this.fileSizeAfterDataGridViewTextBoxColumn.HeaderText = "Size 2";
            this.fileSizeAfterDataGridViewTextBoxColumn.Name = "fileSizeAfterDataGridViewTextBoxColumn";
            this.fileSizeAfterDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileSizeAfterDataGridViewTextBoxColumn.Width = 61;
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = false;
            this.bindingSource1.DataSource = typeof(WSPCompare.Business.WSPCompareFile);
            // 
            // WSPCompareSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "WSPCompareSummary";
            this.Size = new System.Drawing.Size(737, 569);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewImageColumn IconDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePathRelativeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileSizeBeforeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileSizeAfterDataGridViewTextBoxColumn;
    }
}

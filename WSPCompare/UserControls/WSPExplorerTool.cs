using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace WSPCompare
{
    public partial class WSPExplorerTool : UserControl
    {
        public WSPExplorerTool()
        {
            InitializeComponent();
        }

        #region Fields

        private DirectoryInfo _packageDirectory = null;

        #endregion

        #region Properties

        public DirectoryInfo PackageDirectory
        {
            get { return _packageDirectory; }
            set
            {
                _packageDirectory = value;
                RefreshPackage();
            }
        }

        #endregion

        #region Methods

        internal void RefreshPackage()
        {

            //Reset
            fileBrowser1.Clear();
            treeView1.SelectedNode = null;
            treeView1.Nodes.Clear();
            imageList1.Images.Clear();
            imageList1.Images.Add(WSPCompare.Properties.Resources.folder);

            //Initialize treeview
            if (PackageDirectory != null && PackageDirectory.Exists)
            {
                treeView1.BeginUpdate();
                RecFillNodes(treeView1.Nodes, PackageDirectory);
                treeView1.EndUpdate();
            }

        }

        private void RecFillNodes(TreeNodeCollection nodes, DirectoryInfo directory)
        {

            foreach (DirectoryInfo di in directory.GetDirectories())
            {

                TreeNode dirNode = new TreeNode(di.Name);
                dirNode.Tag = di.FullName;
                nodes.Add(dirNode);

                RecFillNodes(dirNode.Nodes, di);

            }

            foreach (FileInfo fi in directory.GetFiles())
            {

                imageList1.Images.Add(fi.FullName, Icon.ExtractAssociatedIcon(fi.FullName));

                TreeNode fileNode = new TreeNode(fi.Name);
                fileNode.Tag = fi.FullName;
                fileNode.ImageKey = fi.FullName;
                fileNode.SelectedImageKey = fi.FullName;
                nodes.Add(fileNode);
            }

        }

        #endregion

        #region Behavior

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
                fileBrowser1.Url = e.Node.Tag as String;
            else
                fileBrowser1.Clear();
        }

        #endregion

    }
}

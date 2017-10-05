using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Web;

namespace WSPCompare
{
    [System.ComponentModel.DefaultBindingProperty("Url")]
    public partial class FileBrowser : UserControl
    {
       
        public FileBrowser()
        {
            InitializeComponent();
        }

        #region Fields

        private String _url = String.Empty;

        #endregion

        #region Properties

        [Bindable(BindableSupport.Yes)]
        public String Url
        {
            get { return _url; }
            set
            {
                _url = value;

                Clear();

                if (!String.IsNullOrEmpty(value) && File.Exists(value))
                {
                    FileInfo fi = new FileInfo(value);
                    switch (fi.Extension.ToLowerInvariant())
                    {
                        case ".xml":
                        case ".xsl":
                        case ".xslt":
                        case ".gif":
                        case ".jpg":
                        case ".jpeg":
                        case ".png":
                        case ".resx":
                            webBrowser1.Navigate(value);
                            break;
                        case ".dll":
                            break;
                        default:
                            using (StreamReader sr = new StreamReader(value))
                            {
                                String text = sr.ReadToEnd();
                                text = "<html><body><pre>" + HttpUtility.HtmlEncode(text) + "</pre></body></html>";
                                webBrowser1.DocumentText = text;
                            }
                            break;
                    }

                }
            }
        }

        #endregion

        #region Methods

        public void Clear()
        {

            webBrowser1.Navigate("about:blank");
            webBrowser1.Document.Write(String.Empty);
            webBrowser1.DocumentText = String.Empty;

        }

        #endregion

    }
}

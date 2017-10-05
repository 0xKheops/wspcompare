using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace WSPCompare
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
          
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form1 = new Form1();
            if (args.Length > 0)
            {
                String filePath1 = null;
                String filePath2 = null;

                if (File.Exists(args[0]))
                    filePath1 = args[0];
                if (args.Length > 1 && File.Exists(args[1]))
                    filePath2 = args[1];

                form1.OpenPackage(filePath1, filePath2);
            }

            Application.Run(form1);

        }

        //Catches all exceptions in the app
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            if (e.Exception is BadImageFormatException)
            {
                String cpuType = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");

                if (cpuType.Contains("64"))
                    MessageBox.Show("CPU Architecture error :\r\nPlease download the x64 version of WSPCompare at http://wspcompare.codeplex.com", "WSPCompare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("CPU Architecture error :\r\nPlease download the x86 version of WSPCompare at http://wspcompare.codeplex.com", "WSPCompare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

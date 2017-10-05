using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CabLib;
using System.Diagnostics;

namespace WSPCompare.Business
{
    public class WSPCompareHelper
    {

        #region Static Methods

        public static List<WSPCompareFile> Compare(DirectoryInfo di1, DirectoryInfo di2)
        {

            List<WSPCompareFile> files = new List<WSPCompareFile>();
            RecCompareFiles(files, String.Empty, di1, di2);

            return files;

        }

        private static void RecCompareFiles(List<WSPCompareFile> files, String relativeDirectoryPath, DirectoryInfo dirWsp1, DirectoryInfo dirWsp2)
        {
            //retrieves list of files and folders that belong to at least a WSP
            List<String> filesToCheck = new List<String>();
            List<String> foldersToCheck = new List<String>();

            if (dirWsp1.Exists)
            {
                foreach (FileInfo fi in dirWsp1.GetFiles())
                    filesToCheck.Add(fi.Name);
                foreach (DirectoryInfo di in dirWsp1.GetDirectories())
                    foldersToCheck.Add(di.Name);
            }

            if (dirWsp2.Exists)
            {
                foreach (FileInfo fi in dirWsp2.GetFiles())
                    if (!filesToCheck.Contains(fi.Name))
                        filesToCheck.Add(fi.Name);
                foreach (DirectoryInfo di in dirWsp2.GetDirectories())
                    if (!foldersToCheck.Contains(di.Name))
                        foldersToCheck.Add(di.Name);
            }

            //Compare each file
            foreach (String fileToCheck in filesToCheck)
            {

                FileInfo fi1 = new FileInfo(Path.Combine(dirWsp1.FullName, fileToCheck));
                FileInfo fi2 = new FileInfo(Path.Combine(dirWsp2.FullName, fileToCheck));

                WSPCompareFile file = new WSPCompareFile();
                file.FilePathRelative = Path.Combine(relativeDirectoryPath, fileToCheck).Trim('\\');

                if (fi1.Exists)
                {
                    file.FilePathBefore = fi1.FullName;
                    file.FileSizeBefore = fi1.Length;
                }

                if (fi2.Exists)
                {
                    file.FilePathAfter = fi2.FullName;
                    file.FileSizeAfter = fi2.Length;
                }

                if (fi1.Exists && !fi2.Exists)
                    file.Status = WSPCompareFileStatus.Deleted;
                else if (!fi1.Exists && fi2.Exists)
                    file.Status = WSPCompareFileStatus.New;
                else if (!fi1.Exists && !fi2.Exists)
                    throw new FileNotFoundException();
                else if (fi1.Length != fi2.Length)
                    file.Status = WSPCompareFileStatus.Modified;
                else
                {

                    file.Status = WSPCompareFileStatus.Equal;

                    FileStream fs1 = fi1.OpenRead();
                    FileStream fs2 = fi2.OpenRead();

                    Int32 b1 = 0;
                    Int32 b2 = 0;

                    while (b1 != -1 && b2 != -1)
                    {
                        b1 = fs1.ReadByte();
                        b2 = fs2.ReadByte();

                        if (b1 != b2)
                        {
                            file.Status = WSPCompareFileStatus.Modified;
                            break;
                        }
                    }

                    fs1.Close();
                    fs2.Close();

                }

                files.Add(file);

            }

            //Compare each sub folder
            foreach (String folderToCheck in foldersToCheck)
            {

                DirectoryInfo fi1 = new DirectoryInfo(Path.Combine(dirWsp1.FullName, folderToCheck));
                DirectoryInfo fi2 = new DirectoryInfo(Path.Combine(dirWsp2.FullName, folderToCheck));

                RecCompareFiles(files, Path.Combine(relativeDirectoryPath, folderToCheck), fi1, fi2);

            }

        }

        public static DirectoryInfo Extract(String filePathWSP, DirectoryInfo tmpDir, String folderName)
        {

            Extract extract = new Extract();

            DirectoryInfo dirWsp = new DirectoryInfo(Path.Combine(tmpDir.FullName, folderName));

            dirWsp.Create();
            extract.ExtractFile(filePathWSP, dirWsp.FullName);

            return dirWsp;

        }

        #endregion

    }
}

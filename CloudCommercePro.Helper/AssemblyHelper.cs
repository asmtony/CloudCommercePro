using CloudCommercePro.Constants;
using System;

namespace CloudCommercePro.Helper
{
    public class AssemblyHelper
    {
        private static string GetExecutingAssemblyFolder()
        {
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            string exeFolder = System.IO.Path.GetDirectoryName(exePath);
            return exeFolder;
        }

        public static string GetCsvPath()
        {
            string csvName = ApplicationConstants.CsvFileName;
            string executePath = AssemblyHelper.GetExecutingAssemblyFolder();
            string path = executePath + "\\" + csvName;

            // remove "file:\" from path
            path = RemoveFileFromName(path);
            return path;
        }

        private static string RemoveFileFromName(string path)
        {
            string stringToRemove = "file:\\";
            if (path.Contains(stringToRemove))
                path = path.Remove(0, stringToRemove.Length);

            return path;
        }
    }
}

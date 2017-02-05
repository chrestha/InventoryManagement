using InventoryManagement.ErrorLog.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace InventoryManagement.ErrorLog
{
    public class FileLogger : IErrorLogger
    {
        public void LogMessage(Exception ex)
        {
          string folderPath= HttpContext.Current.Server.MapPath("~/SystemLogs/");
          if(!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            FileStream objFileStrome = new FileStream(folderPath + "ErrorsCatched.txt", FileMode.Append, FileAccess.Write);
            StreamWriter objStreamWriter = new StreamWriter(objFileStrome);
            objStreamWriter.Write("Source: " + ex.Source);
            objStreamWriter.Write("Message: " + ex.Message);
            objStreamWriter.Write("StackTrace: " + ex.StackTrace);
            objStreamWriter.Write("Source: " + ex.Source);
            if (ex.InnerException != null)
            {
                objStreamWriter.Write("Inner Exception: ", ex.InnerException.Message);           
            }
            objStreamWriter.Write("Date/Time: " + DateTime.Now.ToString());
            objStreamWriter.Write("========================================================");
            objStreamWriter.Close();
            objFileStrome.Close();

        }
    }
}
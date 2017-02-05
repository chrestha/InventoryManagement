using InventoryManagement.ErrorLog.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagement.ErrorLog
{
    public class Operation
    {
        IErrorLogger logger = new FileLogger();
        public void Division()
        {
            try
            {
                int Fno = 15, sno = 0 ,result;
                result = Fno / sno;

                
            }
            catch (Exception ex)
            {
                logger.LogMessage(ex);
            }
        }
    }
}
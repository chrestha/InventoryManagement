using InventoryManagement.ErrorLog.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagement.ErrorLog
{
    public class OperationEvent
    {
        IErrorLogger logger;
        public OperationEvent(IErrorLogger logger)
        {
            this.logger = logger;
        }
        public void Division()
        {
            try
            {
                int firstNumber = 15, secondNumber = 0, result;
                result = firstNumber / secondNumber;
                Console.WriteLine("Result is :{0}", result);
            }
            catch (DivideByZeroException ex)
            {
                logger.LogMessage(ex);
            }
        }
    }

    public class testProgram
    {
        OperationEvent objOperationEvent = new OperationEvent(new FileLogger());
       
    }
}
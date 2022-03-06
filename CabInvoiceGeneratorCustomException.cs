using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator1
{
    public  class CabInvoiceGeneratorCustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_COST
        }
        public readonly ExceptionType Type;
        
        public CabInvoiceGeneratorCustomException(ExceptionType Type, string message) : base(message)
        {
            this.Type = Type;
        }
    }
}

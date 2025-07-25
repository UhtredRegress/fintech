using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fintech.Shared.CustomException
{
    public class NotExistAccountException : Exception
    {
        public NotExistAccountException() { }
        public NotExistAccountException(string message) : base(message) { }
        public NotExistAccountException(string message, Exception innerException) : base(message, innerException) { }
    }
}

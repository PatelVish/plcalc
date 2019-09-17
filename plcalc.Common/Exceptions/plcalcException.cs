using System;

namespace plcalc.Common.Exceptions
{
    public class plcalcException : Exception
    { 
        public Enum ErrorCode { get; set; }

        public plcalcException(String developerMessage, Exception innerException = null)
            : base($"{developerMessage} {innerException?.Message}", innerException)
        {
        }
    }
}

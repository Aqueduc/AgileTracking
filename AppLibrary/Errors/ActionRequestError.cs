using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AppLibrary.Errors
{
    public class ActionRequestError : Exception
    {
        enum ErrorAction
        {
            
        }

        public ActionRequestError()
        {
        }

        public ActionRequestError(string message) : base(message)
        {
            
        }

        public ActionRequestError(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ActionRequestError(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

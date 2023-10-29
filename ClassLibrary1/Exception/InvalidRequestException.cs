using System;
using System.Runtime.Serialization;

namespace ClassLibraryBackend.Exception
{
    public class InvalidRequestException : System.Exception
    {
        public InvalidRequestException() { }
        public InvalidRequestException(string message) : base(message) { }
        public InvalidRequestException(string message, System.Exception innerException) : base(message, innerException) { }
        protected InvalidRequestException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
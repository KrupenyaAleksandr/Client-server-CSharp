using System;
using System.Runtime.Serialization;

namespace ClassLibraryBackend.Exception
{
    public class InvalidKeyException : System.Exception
    {
        public InvalidKeyException() { }
        public InvalidKeyException(string message) : base(message) { }
        public InvalidKeyException(string message, System.Exception innerException) : base(message, innerException) { }
        protected InvalidKeyException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}

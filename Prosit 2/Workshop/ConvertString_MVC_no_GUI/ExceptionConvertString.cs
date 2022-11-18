using System.Runtime.Serialization;

namespace c
{
    [Serializable]
    internal class ExceptionConvertString : Exception
    {
        public ExceptionConvertString()
        {
        }

        public ExceptionConvertString(string? message) : base(message)
        {
        }

        public ExceptionConvertString(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ExceptionConvertString(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
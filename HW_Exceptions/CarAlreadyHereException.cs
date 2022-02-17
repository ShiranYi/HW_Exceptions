using System.Runtime.Serialization;

namespace HW_Exceptions
{
    [Serializable]
    internal class CarAlreadyHereException : Exception
    {
        public CarAlreadyHereException()
        {
        }

        public CarAlreadyHereException(string? message) : base(message)
        {
        }

        public CarAlreadyHereException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CarAlreadyHereException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
using System.Runtime.Serialization;

namespace ConceptosPOO
{
    [Serializable]
    internal class DayEception : Exception
    {
        public DayEception()
        {
        }

        public DayEception(string? message) : base(message)
        {
        }

        public DayEception(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DayEception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
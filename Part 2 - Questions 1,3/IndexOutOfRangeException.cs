using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Text15._05
{
    class IndexOutOfRangeException : ArgumentException
    {
        public IndexOutOfRangeException()
        {
        }

        public IndexOutOfRangeException(string message) : base(message)
        {
        }

        public IndexOutOfRangeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public IndexOutOfRangeException(string message, string paramName) : base(message, paramName)
        {
        }

        public IndexOutOfRangeException(string message, string paramName, Exception innerException) : base(message, paramName, innerException)
        {
        }

        protected IndexOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

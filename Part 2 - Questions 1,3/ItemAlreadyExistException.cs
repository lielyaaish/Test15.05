using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Text15._05
{
    class ItemAlreadyExistException : ArgumentException
    {
        public ItemAlreadyExistException()
        {

        }

        public ItemAlreadyExistException(string message) : base(message)
        {
        }

        public ItemAlreadyExistException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public ItemAlreadyExistException(string message, string paramName) : base(message, paramName)
        {
        }

        public ItemAlreadyExistException(string message, string paramName, Exception innerException) : base(message, paramName, innerException)
        {
        }

        protected ItemAlreadyExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Text15._05
{
    class ItemNotFoundException : ArgumentException
    {
        public ItemNotFoundException()
        {

        }

        public ItemNotFoundException(string message) : base(message)
        {
        }

        public ItemNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public ItemNotFoundException(string message, string paramName) : base(message, paramName)
        {
        }

        public ItemNotFoundException(string message, string paramName, Exception innerException) : base(message, paramName, innerException)
        {
        }

        protected ItemNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

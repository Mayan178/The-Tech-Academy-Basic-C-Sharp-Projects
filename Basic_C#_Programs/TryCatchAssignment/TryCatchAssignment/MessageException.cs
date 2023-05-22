using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    public class MessageException : Exception
    {
        public MessageException()
            : base() { }
        public MessageException(string message)
            : base(message) { }

    }
}

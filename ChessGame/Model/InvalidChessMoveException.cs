using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Model
{
    [Serializable()]
    public class InvalidChessMoveException : System.Exception
    {
        public InvalidChessMoveException() : base() { }
        public InvalidChessMoveException(string message) : base(message) { }
        public InvalidChessMoveException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected InvalidChessMoveException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

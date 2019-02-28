using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTesting
{
    public class TianException : Exception
    {
        public TianException() : 
            base("Please enter a positive number!")
        { }

        public TianException(string message) :
            base(message)
        { }

        public TianException(string message, Exception inner) :
            base(message, inner)
        { }

    }
}

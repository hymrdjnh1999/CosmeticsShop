using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Ultilities.Exceptions
{
    public class CosmeticsException : Exception
    {
        public CosmeticsException()
        {

        }

        public CosmeticsException(string message)
        : base(message)
        {
        }
        public CosmeticsException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}

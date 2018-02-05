using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTest01.Shared.Exceptions
{
    public class ParameterRequiredException : Exception
    {
        public ParameterRequiredException(): base()
        {

        }

        public ParameterRequiredException(string message) : base("Parameter Required")
        {

        }
    }
}

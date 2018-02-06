using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTest01.Shared.Exceptions
{
    public class RecordNotFoundException : Exception
    {
        public RecordNotFoundException() : base("Record Not Found")
        {

        }

        public RecordNotFoundException(string message) : base(message)
        {

        }
    }
}

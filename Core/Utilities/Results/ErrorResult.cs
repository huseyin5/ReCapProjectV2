using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result
    {
        // Error and Message
        public ErrorResult(string message):base(false,message)
        {

        }
        // Error
        public ErrorResult():base(false)
        {

        }
    }
}

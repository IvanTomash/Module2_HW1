using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_1
{
    /// <summary>
    /// The Result class contains a Status flag property and an error message if needed.
    /// </summary>
    internal class Result
    {
        public Result() 
        {
        }

        public Result(bool _status, string _message = "")
        {
            this.status = _status;
            this.message = _message;
        }

        private bool status;
        
        public bool Status
        { get { return this.status; } }

        private string message;

        public string Message
        { get { return this.message; } }
    }
}
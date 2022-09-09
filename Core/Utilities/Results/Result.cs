using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool state, string message) : this(state)
        {
            Message = message;
        }
        public Result(bool state)
        {
            State = state;
        }
        public bool State { get; }
        public string Message { get; }
    }
}

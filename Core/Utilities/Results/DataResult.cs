﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool state, string message) : base(state, message)
        {
            Data = data;
        }
        public DataResult(T data, bool state) : base(state) 
        {
            Data = data;
        }

        public T Data { get; }
    }
}

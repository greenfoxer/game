using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egt.Logic.Interfaces
{
    public class ResultOperationInfo
    {
        public bool IsSuccess { get; private set; }
        public string Message { get; set; }
        public ResultOperationInfo(bool isSuccess, string message = "")
        {
            IsSuccess = isSuccess;
            Message = message;
        }
    }

    public class ResultOperationInfo<T> : ResultOperationInfo where T : class
    {
        public T Value { get; private set; }
        public ResultOperationInfo(T value, bool isSuccess, string message)
            : base(isSuccess, message)
        {
            Value = value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlogApp.Shared.Utilities.Results.Abstract;
using MyBlogApp.Shared.Utilities.Results.ComplexTypes;

namespace MyBlogApp.Shared.Utilities.Results.Concrete
{
    public class Result:IResult
    {
        public Result(ResultStatus resultStatus)
        {
            ResultStatus = resultStatus;
        }

        public Result(ResultStatus resultStatus, string message)
        {
            ResultStatus = resultStatus;
            Message = message;
        }
        public ResultStatus ResultStatus { get; }
        public string Message { get; }
        public Exception Exception { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Common
{
    public class ApiErrorResult<T> : ApiResult<T>
    {
        public string[] ValidationErrors { get; set; }
        public ApiErrorResult(string message)
        {
            Message = message;
            IsSuccess = false;

        }
        public ApiErrorResult()
        {
            IsSuccess = false;
        }
        public ApiErrorResult(string[] validationErrors)
        {
            IsSuccess = false;
            ValidationErrors = validationErrors;

        }
    }
}

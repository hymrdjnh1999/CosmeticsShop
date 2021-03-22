using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Common
{
    public class ApiSuccessResult<T> : ApiResult<T>
    {
        public ApiSuccessResult(T obj)
        {
            ResultObj = obj;
            IsSuccess = true;
        }
        public ApiSuccessResult()
        {
            IsSuccess = true;
        }
    }
}

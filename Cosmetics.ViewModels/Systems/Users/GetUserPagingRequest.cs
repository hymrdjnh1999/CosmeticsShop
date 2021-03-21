using Cosmetics.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Systems.Users
{
    public class GetUserPagingRequest : QueryParamRequest
    {
        public string Keyword { get; set; }
    }
}

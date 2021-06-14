using Cosmetics.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Systems.Clients
{
    public class GetClientPagingRequest : QueryParamRequest
    {
        public string Keyword { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Common
{
    public class QueryParamRequest : RequestBase
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}

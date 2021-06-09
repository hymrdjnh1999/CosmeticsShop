using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Categories
{
    public class CategoryUpdateIOSRequest
    {
        public int Id { get; set; }
        public bool IsOutstanding { get; set; }
    }
}

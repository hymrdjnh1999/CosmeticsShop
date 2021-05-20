using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.ProductImages
{
    public class ProductImageCreateRequest
    {
        public int ProductId { get; set; }
        public string Caption { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}

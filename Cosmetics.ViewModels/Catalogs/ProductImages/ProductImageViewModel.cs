using System;
using System.ComponentModel;

namespace Cosmetics.ViewModels.Catalogs.ProductImages
{
    public class ProductImageViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        [DisplayName("Ảnh")]
        public string ImagePath { get; set; }
        [DisplayName("Chú thích")]
        public string Caption { get; set; }
        [DisplayName("Thumbnail")]
        public bool IsDefault { get; set; }
        public DateTime DateCreated { get; set; }
        public int SortOrder { get; set; }
        public long FileSize { get; set; }
    }
}

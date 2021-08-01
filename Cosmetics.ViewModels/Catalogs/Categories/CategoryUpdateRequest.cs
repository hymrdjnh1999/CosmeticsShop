namespace Cosmetics.ViewModels.Catalogs.Categories
{
    public class CategoryUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsOutstanding { get; set; }
    }
}

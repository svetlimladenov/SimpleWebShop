namespace SimpleWebShop.Web.Areas.Administration.ViewModels
{
    public class CreateProductInputModel
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Color { get; set; }

        public string Size { get; set; }

        public double Weight { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public string Details { get; set; }

        // public ICollection<ProductImage> ProductImages { get; set; }

        public int ProductsOnStock { get; set; }

        public string ProductCategoryName { get; set; }

    }
}
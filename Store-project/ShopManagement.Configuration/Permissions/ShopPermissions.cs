using System.ComponentModel;

namespace ShopManagement.Configuration.Permissions
{
    public static class ShopPermissions
    {
        //Product
        public const int ListProducts = 10;
        public const int SearchProducts = 11;
        public const int CreateProduct = 12;
        public const int EditProduct = 13;


        //ProductCategory
        public const int ListProductCategories = 20;
        public const int SearchProductCategories = 21;
        public const int CreateProductCategory = 22;
        public const int EditProductCategory = 23;

        //ProductPicture
        public const int ListProductPicture = 30;
        public const int SearchProductPicture = 31;
        public const int CreateProductPicture = 32;
        public const int EditProductPicture = 33;
        public const int RemoveProductPicture = 34;
        public const int RestoreProductPicture = 35;

        //Slide
        public const int ListSlide = 40;
        public const int SearchSlide = 41;
        public const int CreateSlide = 42;
        public const int EditSlide = 43;
        public const int RemoveSlide = 44;
        public const int RestoreSlide = 45;
    }
}
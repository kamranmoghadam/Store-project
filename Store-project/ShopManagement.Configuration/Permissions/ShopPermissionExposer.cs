using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace ShopManagement.Configuration.Permissions
{
    public class ShopPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Product", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.ListProducts, "لیست محصولات"),
                        new PermissionDto(ShopPermissions.SearchProducts, "جستو جو محصولات"),
                        new PermissionDto(ShopPermissions.CreateProduct, "ایجاد محصول جدید"),
                        new PermissionDto(ShopPermissions.EditProduct, "ویرایش محصول")
                    }
                },
                {
                    "ProductCategory", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.SearchProductCategories, "جست و جو گروه محصولات"),
                        new PermissionDto(ShopPermissions.ListProductCategories, "لیست گروه محصولات "),
                        new PermissionDto(ShopPermissions.CreateProductCategory, "ایجاد گروه محصول جدید "),
                        new PermissionDto(ShopPermissions.EditProductCategory, "ویرایش گروه محصول ")
                    }
                },
                {
                    "ProductPicture", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.SearchProductPicture, "جست و جو عکس محصولات"),
                        new PermissionDto(ShopPermissions.ListProductPicture, "لیست عکس محصولات "),
                        new PermissionDto(ShopPermissions.CreateProductPicture, "ایجاد عکس محصول جدید "),
                        new PermissionDto(ShopPermissions.EditProductPicture, "ویرایش عکس محصول "),
                        new PermissionDto(ShopPermissions.RemoveProductPicture, "حذف عکس محصول "),
                        new PermissionDto(ShopPermissions.RestoreProductPicture, "بازگردانی عکس محصول ")
                    }
                },
                {
                    "Slide", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.SearchSlide, "جست و جو اسلاید "),
                        new PermissionDto(ShopPermissions.ListSlide, "لیست اسلایدها "),
                        new PermissionDto(ShopPermissions.CreateSlide, "ایجاد اسلاید جدید "),
                        new PermissionDto(ShopPermissions.EditSlide, "ویرایش اسلاید "),
                        new PermissionDto(ShopPermissions.RemoveSlide, "حذف اسلاید "),
                        new PermissionDto(ShopPermissions.RestoreSlide, "بازگردانی اسلاید ")
                    }
                },
                {
                    "Order", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.SearchOrder, "جست و جو سفارشات "),
                        new PermissionDto(ShopPermissions.ListOrder, "لیست سفارشات "),
                        new PermissionDto(ShopPermissions.ConfirmOrder, "تایید سفارش  "),
                        new PermissionDto(ShopPermissions.RemoveOrder, "حذف سفارش  "),
                      
                    }
                }
            };
        }
    }
}
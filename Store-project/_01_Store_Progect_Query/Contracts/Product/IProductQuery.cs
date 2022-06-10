using System.Collections.Generic;


namespace _01_Store_Project_Query.Contracts.Product
{
    public interface IProductQuery
    {
        ProductQueryModel GetProductDetails(string slug);
        List<ProductQueryModel> GetLatestArrivals();
        List<ProductQueryModel> Search(string value);
        //List<CartItem> CheckInventoryStatus(List<CartItem> cartItems);
    }
}

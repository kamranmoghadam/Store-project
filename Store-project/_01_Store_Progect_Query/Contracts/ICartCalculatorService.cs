using System.Collections.Generic;
using ShopManagement.Application.Contracts.Order;

namespace _01_Store_Project_Query.Contracts
{
    public interface ICartCalculatorService
    {
        Cart ComputeCart(List<CartItem> cartItems);
    }
}
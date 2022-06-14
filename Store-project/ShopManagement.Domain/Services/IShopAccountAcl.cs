namespace ShopManagement.Domain.Services
{
    public interface IShopAccountAcl
    {
        (string name, string family,string mobile) GetAccountBy(long id);
    }
}

using _0_Framework.Domain;

namespace DiscountManagement.Domain.ColleagueDiscountAgg
{
    public class ColleagueDiscount : EntityBase
    {
        public long ProductId { get; private set; }
        public int DiscountRate { get; private set; }
        public bool IsRemoved { get; private set; }
        public string Reason { get; set; }

        public ColleagueDiscount(long productId, int discountRate,string reason)
        {
            ProductId = productId;
            DiscountRate = discountRate;
            IsRemoved = false;
            Reason=reason;
        }

        public void Edit(long productId, int discountRate, string reason)
        {
            ProductId = productId;
            DiscountRate = discountRate;
            Reason = reason;
        }

        public void Remove()
        {
            IsRemoved = true;
        }

        public void Restore()
        {
            IsRemoved = false;
        }
    }
}

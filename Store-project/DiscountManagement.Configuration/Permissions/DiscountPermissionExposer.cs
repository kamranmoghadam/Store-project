using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace DiscountManagement.Configuration.Permissions
{
    public class DiscountPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "ColleagueDiscount", new List<PermissionDto>
                    {
                        new PermissionDto(DiscountPermissions.ListColleagueDiscount, " لیست تخفیفات همکار"),
                        new PermissionDto(DiscountPermissions.SearchColleagueDiscount, " جست و جو در تخفیفات همکار"),
                        new PermissionDto(DiscountPermissions.DefineColleagueDiscount, "ایجاد تخفیف همکار"),
                        new PermissionDto(DiscountPermissions.EditColleagueDiscount, "ویرایش تخفیف همکار"),
                    }
                },
                {
                    "CustomerDiscount", new List<PermissionDto>
                    {
                        new PermissionDto(DiscountPermissions.SearchCustomerDiscount, "جست و جو در تخفیفات مشتری"),
                        new PermissionDto(DiscountPermissions.ListCustomerDiscount, "لیست تخفیفات مشتری"),
                        new PermissionDto(DiscountPermissions.DefineCustomerDiscount, "ایجاد تخفیف مشتری "),
                        new PermissionDto(DiscountPermissions.EditCustomerDiscount, "ویرایش تخفیف مشتری"),
                    }
                }
            };
        }
    }
}
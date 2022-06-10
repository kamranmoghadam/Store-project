using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace AccountManagement.Configuration.Permissions
{
    public class AccountPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Account", new List<PermissionDto>
                    {
                        new PermissionDto(AccountPermissions.ListAccount, "لیست اشخاص "),
                        new PermissionDto(AccountPermissions.SearchAccount, "جستو جو در اشخاص"),
                        new PermissionDto(AccountPermissions.RegisterAccount, "ایجاد شخص جدید "),
                        new PermissionDto(AccountPermissions.EditAccount, "ویرایش اشخاص "),
                        new PermissionDto(AccountPermissions.ChangePasswordAccount, "ویرایش رمز عبور ")

                    }
                },
                {
                    "Role", new List<PermissionDto>
                    {
                        new PermissionDto(AccountPermissions.ListRole, "لیست نقش ها "),
                        new PermissionDto(AccountPermissions.SearchRole, "جستو جو در نقش ها"),
                        new PermissionDto(AccountPermissions.EditRole, "ویرایش نقش ها "),
                        new PermissionDto(AccountPermissions.ChangeRole, "حق دسترسی ")
                    }
                }
                

            };
        }
    }
}
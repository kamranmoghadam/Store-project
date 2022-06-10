using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace InventoryManagement.Infrastructure.Configuration.Permissions
{
    public class InventoryPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Inventory", new List<PermissionDto>
                    {
                        new PermissionDto(InventoryPermissions.ListInventory, "لیست انبار کالاها "),
                        new PermissionDto(InventoryPermissions.SearchInventory, "جستو جو در انبار"),
                        new PermissionDto(InventoryPermissions.CreateInventory, "ایجاد انبار جدید کالا"),
                        new PermissionDto(InventoryPermissions.EditInventory, "ویرایش انبار "),
                        new PermissionDto(InventoryPermissions.Increase, "افزایش موجودی "),
                        new PermissionDto(InventoryPermissions.Reduce, "کاهش موجودی"),
                        new PermissionDto(InventoryPermissions.OperationLog, "لیست ورود و خروج کالا")
                    }
                }
            };
        }
    }
}
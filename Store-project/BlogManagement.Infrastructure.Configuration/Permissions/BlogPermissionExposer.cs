using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace BlogManagement.Infrastructure.Configuration.Permissions
{
    public class BlogPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Blog", new List<PermissionDto>
                    {
                        new PermissionDto(BlogPermissions.ListBlog, "لیست مقالات "),
                        new PermissionDto(BlogPermissions.SearchBlog, "جستو جو در مقالات"),
                        new PermissionDto(BlogPermissions.CreateBlog, "ایجاد مقاله جدید"),
                        new PermissionDto(BlogPermissions.EditBlog, "ویرایش مقاله ")
                    }
                }
            };
        }
    }
}
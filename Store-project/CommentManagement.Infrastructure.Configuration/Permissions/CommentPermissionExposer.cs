using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace CommentManagement.Infrastructure.Configuration.Permissions
{
    public class CommentPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Comment", new List<PermissionDto>
                    {
                        new PermissionDto(CommentPermissions.ListComment, "لیست پیامها "),
                        new PermissionDto(CommentPermissions.SearchComment, "جستو جو در پیامها"),
                        new PermissionDto(CommentPermissions.ConfirmComment, "تایید پیام "),
                        new PermissionDto(CommentPermissions.CancelComment, "لغو پیام "),
                       
                    }
                }
            };
        }
    }
}
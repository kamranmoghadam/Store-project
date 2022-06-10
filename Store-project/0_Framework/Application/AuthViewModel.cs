using System.Collections.Generic;

namespace _0_Framework.Application
{
    public class AuthViewModel
    {
        public long Id { get; set; }
        public long RoleId { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Mobile { get; set; }
        public string ProfilePhoto { get; set; }
        public List<int> Permissions { get; set; }

        public AuthViewModel()
        {
        }

        public AuthViewModel(long id, long roleId, string name,string family, string email, string username, string mobile,
            string profilePhoto,List<int> permissions)
        {
            Id = id;
            RoleId = roleId;
            Name = name;
            Family = family;
            Email = email;
            Username = username;
            Mobile = mobile;
            ProfilePhoto = profilePhoto;
            Permissions = permissions;
        }
    }
}
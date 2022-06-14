using _0_Framework.Domain;
using AccountManagement.Domain.RoleAgg;

namespace AccountManagement.Domain.AccountAgg
{
    public class Account : EntityBase
    {
        
        public string Name { get; private set; }
        public string Family { get; private set; }
        public string Email { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Mobile { get; private set; }
        public long RoleId { get; private set; }
        public Role Role { get; private set; }
        public string ProfilePhoto { get; private set; }

        public Account(string name,string family,string email, string username, string password, string mobile,
            long roleId, string profilePhoto)
        {
            Name = name ;
            Family = family ;
            Email = email;
            Username = username;
            Password = password;
            Mobile = mobile;
            RoleId = roleId;

            if (roleId == 0)
                RoleId = 2;
            
            ProfilePhoto = profilePhoto;
        }

        public void Edit(string name, string family, string email, string username, string mobile,
            long roleId, string profilePhoto)
        {
            Name = name;
            Family = family;
            Email = email;
            Username = username;
            Mobile = mobile;
            RoleId = roleId;

            if (!string.IsNullOrWhiteSpace(profilePhoto))
                ProfilePhoto = profilePhoto;
        }

        public void ChangePassword(string password)
        {
            Password = password;
        }
    }
}

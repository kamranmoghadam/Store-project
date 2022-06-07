namespace AccountManagement.Application.Contracts.Account
{
    public class AccountSearchModel
    {
        public string Name { get;  set; }
        public string Family { get;  set; }
        public string Email { get;  set; }
        public string Username { get; set; }
        public string Mobile { get; set; }
        public long RoleId { get; set; }
    }
}

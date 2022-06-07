﻿namespace AccountManagement.Application.Contracts.Account
{
    public class AccountViewModel
    {
        public long Id { get; set; }
        public string Name { get;  set; }
        public string Family { get;  set; }
        public string Email { get;  set; }
        public string Username { get; set; }
        public string Mobile { get; set; }
        public long RoleId { get; set; }
        public string Role { get; set; }
        public string ProfilePhoto { get; set; }
        public string CreationDate { get; set; }
    }
}

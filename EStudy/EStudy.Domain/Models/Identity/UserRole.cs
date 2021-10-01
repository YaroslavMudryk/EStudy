﻿namespace EStudy.Domain.Models.Identity
{
    public class UserRole : BaseModel<int>
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
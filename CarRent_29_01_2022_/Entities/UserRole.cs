﻿namespace CarRent_29_01_2022_.Entities
{
    public class UserRole
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }

    }
}
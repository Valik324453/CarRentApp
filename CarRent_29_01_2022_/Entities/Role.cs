using System.Collections.Generic;

namespace CarRent_29_01_2022_.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
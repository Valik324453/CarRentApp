using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent_29_01_2022_.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }

        public User()
        {
            UserRoles = new HashSet<UserRole>();
        }
    }
}

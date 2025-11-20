using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAW.Data.Models;

namespace PAW.Models.DTO
{
    public class UserDto
    {
        public int UserId { get; set; }

        public string Name { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public DateOnly DateBirth { get; set; }

        public int RoleId { get; set; }

        public virtual Role Role { get; set; } = null!;
    }
}

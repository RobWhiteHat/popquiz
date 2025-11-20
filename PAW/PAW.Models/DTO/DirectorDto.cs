using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAW.Data.Models;

namespace PAW.Models.DTO
{
    public class DirectorDto
    {
        public int DirectorId { get; set; }

        public string FullName { get; set; } = null!;

        public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}

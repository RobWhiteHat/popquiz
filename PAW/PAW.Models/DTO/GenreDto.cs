using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAW.Data.Models;

namespace PAW.Models.DTO
{
    public class GenreDto
    {
        public int GenreId { get; set; }

        public string Name { get; set; } = null!;

        public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}

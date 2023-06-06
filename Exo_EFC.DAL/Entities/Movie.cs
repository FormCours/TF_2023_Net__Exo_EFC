using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_EFC.DAL.Entities
{
    public class Movie
    {
        public Guid MovieId { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string MainActor { get; set; }
        public string Genre { get; set; }
        public short ReleaseYear { get; set; }
    }
}

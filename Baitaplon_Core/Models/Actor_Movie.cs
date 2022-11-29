using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Baitaplon_Core.Models
{
    public class Actor_Movie
    {
        public int MoviesId { get; set; }
        public Movies Movies { get; set; }

        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        //Relationship
    }
}

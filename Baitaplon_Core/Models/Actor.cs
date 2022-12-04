using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Baitaplon_Core.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        [Display(Name = "Ảnh")]
        public string Anh { get; set; }
        [Display(Name = "Họ và tên")]
        public string HoTen { get; set; }
        [Display(Name = "Tiểu sử")]
        public string TieuSu { get; set; }

        //Relationship
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}

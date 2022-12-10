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
        [Required(ErrorMessage ="Hãy thêm ảnh!!!")]
        public string Anh { get; set; }
        [Display(Name = "Họ và tên")]
        [Required(ErrorMessage = "Điền họ và tên!!!")]
        public string HoTen { get; set; }
        [Display(Name = "Tiểu sử")]
        [Required(ErrorMessage = "Điền tiểu sử!!!")]
        public string TieuSu { get; set; }

        //Relationship
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}

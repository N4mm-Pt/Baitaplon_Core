using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Baitaplon_Core.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        [Display(Name ="Ảnh")]
        public string Anh { get; set; }
        [Display(Name = "Họ tên")]
        public string HoTen { get; set; }
        [Display(Name = "Tiểu sử")]
        public string TieuSu { get; set; }
        
        //Relationship
        public List<Movies> Movies { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Baitaplon_Core.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }
        [Display(Name ="Logo rạp phim")]
        public string Logo { get; set; }
        [Display(Name = "Tên rạp phim")]
        public string Ten { get; set; }
        [Display(Name = "Chi tiết rạp phim")]
        public string ChiTiet { get; set; }

        //Relationship
        public List<Movies> Movies { get; set; }
    }
}

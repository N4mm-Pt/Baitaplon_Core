using Baitaplon_Core.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Baitaplon_Core.Models
{
    public class Movies
    {
        [Key]
        public int MoviesId { get; set; }
        public string Ten { get; set; }
        public string Chitiet { get; set; }
        public double Gia { get; set; }
        public string Anh { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public DanhMuc DanhMuc { get; set; }
    }
}

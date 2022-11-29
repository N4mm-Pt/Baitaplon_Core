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
        public string Anh { get; set; }
        public string HoTen { get; set; }
        public string TieuSu { get; set; }
        
        //Relationship
        public List<Movies> Movies { get; set; }
    }
}

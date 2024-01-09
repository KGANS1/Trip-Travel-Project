using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TripProject.Models.Sınıflar
{
    public class Iletisim
    {
        [Key]
        public int ID { get; set; }
        public String AdSoyad { get; set; }
        public String Mail { get; set; }
        public String Konu { get; set; }
        public String Mesaj { get; set; }
    }
}
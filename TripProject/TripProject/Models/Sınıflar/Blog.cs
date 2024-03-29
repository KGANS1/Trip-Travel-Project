﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TripProject.Models.Sınıflar
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public String Baslik { get; set; }

        public DateTime Tarih { get; set; }
        public String Aciklama { get; set; }
        public String BlogImage { get; set; }
        
        public ICollection<Yorumlar> Yorumlars { get; set; }
    }
}
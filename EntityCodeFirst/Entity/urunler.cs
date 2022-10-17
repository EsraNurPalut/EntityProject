﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
    public class urunler
    {
        [Key]
        public int urunıd { get; set; }
        public string urunad
        {
            get; set;
        }
        public string urunmarka
        {
            get; set;
        }
        public string urunkategori
        {
            get; set;
        }
        public int urunstok { get; set; }
        public string aciklama { get; set; }
        public Kategori Kategori { get; set; } // bir ürünün sadece bir tane kategori oldugu için bunu yazdık.
    
    }
}
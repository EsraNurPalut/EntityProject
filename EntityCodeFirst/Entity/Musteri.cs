﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
    public class Musteri
    {
        [Key]
        public int musteriID { get; set; }
        public string musteriad { get; set; }
        public string musterisoyad { get; set; }
        public string müsteriadres { get; set; }
        public string müsterisehir { get; set; }
        public string müsteriulke { get; set; }

        
    }
}

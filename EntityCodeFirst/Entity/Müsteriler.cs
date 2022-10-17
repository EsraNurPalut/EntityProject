using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
    class Müsteriler
    {
        [Key]
        public int musteriID { get; set; }

        public string musteriad { get; set; }

        public string musterisoyad { get; set; }
    }
}

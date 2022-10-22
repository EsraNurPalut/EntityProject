using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
  public   class Raporlama
    {
        [Key]
        public int raporID { get; set; }
        public string raporad { get; set; }
        public string rapormarka { get; set; }
    }
}

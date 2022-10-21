using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
  public   class magaza
    {
        [Key]
        public int magazaID { get; set; }
        public string magazaad { get; set; }
        public string magazail { get; set; }
        public string magazaadres { get; set; }

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityCodeFirst.Entity
{
  public  class Kategori
    {
        [Key]
        public  int kategoriıd { get;set;}

        public string kategoriad { get; set; }

        public ICollection<urunler> Urunlers { get; set; }  //  kategorilerin içerisinde birden fazla ürün yer alabilir. bir kategori birden fazla üründe yer alabilir..

        internal void Show()
        {
            
        }
    }
}

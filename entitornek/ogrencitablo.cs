//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entitornek
{
    using System;
    using System.Collections.Generic;
    
    public partial class ogrencitablo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ogrencitablo()
        {
            this.notlartablo = new HashSet<notlartablo>();
        }
    
        public int ID { get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public string FOTOGRAF { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<notlartablo> notlartablo { get; set; }
    }
}

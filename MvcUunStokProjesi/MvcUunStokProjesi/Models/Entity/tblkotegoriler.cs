//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcUunStokProjesi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations; // bu k�t�phanenin eklenmesi laz�m 

    public partial class tblkotegoriler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblkotegoriler()
        {
            this.tblurunler = new HashSet<tblurunler>();
        }
    
        public short kategoriid { get; set; }

        [Required(ErrorMessage ="Kategori Ad�n� Bo�  Ge�emezsiniz")] // �zeli�in gerkli bir alan oldu�unu belirtir ilk ba�ta olmayacak sar� i�aret geldi�ine dataannotations a bas olacak 
        public string kategoriad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblurunler> tblurunler { get; set; }
    }
}

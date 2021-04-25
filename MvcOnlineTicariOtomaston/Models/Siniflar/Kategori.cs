using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomaston.Models.Siniflar
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }

        [Display(Name ="Kategori Adı")]
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string KategoriAd { get; set; }
        public ICollection<Urun> Uruns { get; set; }
        //uruns olmasının sebebi veritabanında s takısı ile tutulması.
        //Icollection ile urun ve kategori sınıfı arasında ilişkilendirme yaptık.
    }
}
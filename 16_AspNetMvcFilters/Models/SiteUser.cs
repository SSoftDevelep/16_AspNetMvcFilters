using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _16_AspNetMvcFilters.Models
{
    [Table("SiteUsers")] //tabloya isim verme
    public class SiteUser
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]  //identity otomatik artiyor.
        public int Id { get; set; }

        [Required,StringLength(20),DisplayName("Ad")]
        public string Ad { get; set; }

        [Required, StringLength(20), DisplayName("Soyad")]
        public string Soyad { get; set; }

        [Required, StringLength(20), DisplayName("Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }

        [Required, StringLength(16), DisplayName("Şifre"),DataType(DataType.Password)]
        public string Sifre { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _214001004.Models
{
    internal class Kullanici
    {
        [Key]
        public int Id { get; set; }

        public string KullaniciAdi{ get; set; }

        public string KullaniciSifre { get; set; }

        public string KullaniciYetki { get; set; }
    }
}

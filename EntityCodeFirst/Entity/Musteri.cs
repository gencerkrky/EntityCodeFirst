using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
    internal class Musteri
    {
        [Key]
        public int MusteriId { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyad { get; set; }

    }
}

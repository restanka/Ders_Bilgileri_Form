using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DersBilgileri.Enums;

namespace DersBilgileri.Models
{
    public class Ders
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public KategoriEnum Kategori { get; set; }
        public string Icerik { get; set; }
        public short Kredi { get; set; }
    }
}

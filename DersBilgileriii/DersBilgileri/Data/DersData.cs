using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DersBilgileri.Models;

namespace DersBilgileri.Data
{
    public static class DersData
    {
        public static List<Ders> Dersler { get; set; }

        static DersData()
        {
            Dersler = new List<Ders>()
            {
                new Ders()
                {
                    Id = 1,
                    Adi = "Matematik",
                    Icerik = "Matematik ile ilgili şeyler...",
                    Kategori = Enums.KategoriEnum.Kategori1,
                    Kredi = 5
                },
                new Ders()
                {
                    Id = 2,
                    Adi = "Fizik",
                    Icerik = "Fizik ile ilgili şeyler...",
                    Kategori = Enums.KategoriEnum.Kategori2,
                    Kredi = 4
                },
                new Ders()
                {
                    Id = 3,
                    Adi = "Kimya",
                    Icerik = "Kimya ile ilgili şeyler...",
                    Kategori = Enums.KategoriEnum.Kategori3,
                    Kredi = 3
                },
                new Ders()
                {
                    Id = 4,
                    Adi = "İstatistik",
                    Icerik = "İstatistik ile ilgili şeyler...",
                    Kategori = Enums.KategoriEnum.Kategori4,
                    Kredi = 2
                },
                new Ders()
                {
                    Id = 5,
                    Adi = "Tarih",
                    Icerik = "Tarih ile ilgili şeyler...",
                    Kategori = Enums.KategoriEnum.Kategori5,
                    Kredi = 1
                },

            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DersBilgileri.Data;
using DersBilgileri.DataAccess.Bases;
using DersBilgileri.Models;

namespace DersBilgileri.DataAccess
{
    public class MemoryOperations : OperationBase
    {
        public override List<Ders> GetList()
        {
            return DersData.Dersler;
        }
        public override void Add(Ders ders)
        {
            ders.Id = IncrementValue(DersData.Dersler);
            DersData.Dersler.Add(ders);
        }

        public override Ders GetById(int id)
        {
            Ders ders = null;
            foreach (var d in DersData.Dersler)
            {
                if (d.Id == id)
                {
                    ders = d;
                    break;
                }
            }

            return ders;
        }

        public override void Delete(int id)
        {
            Ders bulunanDers = null;
            foreach (var ders in DersData.Dersler)
            {
                if (id == ders.Id)
                {
                    bulunanDers = ders;
                    break;
                }
            }

            if (bulunanDers != null)
            {
                DersData.Dersler.Remove(bulunanDers);
            }
        }
    }
}

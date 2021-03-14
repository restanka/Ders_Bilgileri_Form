using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DersBilgileri.Data;
using DersBilgileri.Models;

namespace DersBilgileri.DataAccess.Bases
{
    public abstract class OperationBase
    {
        public virtual List<Ders> GetList()
        {
            return DersData.Dersler;
        }

        public abstract void Add(Ders ders);

        public abstract Ders GetById(int id);

        public abstract void Delete(int id);

        protected int IncrementValue(List<Ders> dersler)
        {
            int Id;
            if (dersler != null && dersler.Count > 0)
            {
                Ders ders;
                ders = dersler.LastOrDefault();

                Id = ders.Id + 1;
            }
            else
            {
                Id = 1;
            }

            return Id;
        }

    }
}

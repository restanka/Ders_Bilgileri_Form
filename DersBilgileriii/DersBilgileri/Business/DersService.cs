using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DersBilgileri.DataAccess.Bases;
using DersBilgileri.Models;

namespace DersBilgileri.Business
{
   public class DersService
   {
       private readonly OperationBase Memory;

       public DersService(OperationBase operationBase)
       {
           Memory = operationBase;
       }

       public List<Ders> GetDersler()
       {
           return Memory.GetList();
       }

       public void AddDers(Ders ders)
       {
           Memory.Add(ders);
       }

       public void Delete(int Id)
       {
           Memory.Delete(Id);
       }

       public Ders GetDers(int Id)
       {
           return Memory.GetById(Id);
       }
   }
}

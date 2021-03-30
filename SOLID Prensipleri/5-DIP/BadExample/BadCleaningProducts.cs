using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri._5_DIP.BadExample
{
    public class BadCleaningProducts
    {
        public string BadCleaningProductsSortingInstruction() => "Bad clean product sorting instruction";
    }
}
// BadCleaningProductsSortingInstruction() methodun diğer sınıf içersinde erişebilir durumada olması için  ilgili sınıf içersinde örneklem almak gerekmektedir.

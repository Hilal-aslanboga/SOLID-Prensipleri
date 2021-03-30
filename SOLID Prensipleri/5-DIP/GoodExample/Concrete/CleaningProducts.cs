using SOLID_Prensipleri._5_DIP.GoodExample.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri._5_DIP.GoodExample.Concrete
{
    public class CleaningProducts : SortingInstruction
    {
        public override string GetSortingInstruction() => "Cleaning products instruction list";
    }
}

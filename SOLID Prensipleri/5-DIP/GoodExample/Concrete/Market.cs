using SOLID_Prensipleri._5_DIP.GoodExample.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri._5_DIP.GoodExample.Concrete
{
    public class Market
    {
        List<SortingInstruction> sortingList;

        public Market() => sortingList = new List<SortingInstruction>();

        public string GeneratedSortingInstruction()
        {
            string instruction = string.Empty;

            foreach (var item in sortingList)

                instruction += " " + item.GetSortingInstruction();

            return instruction;
            
        }
    }
}
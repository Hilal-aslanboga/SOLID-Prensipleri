using SOLID_Prensipleri._4_ISP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri._4_ISP.GoodExample.Concrete
{
    public class Dog : IRunnable,IBrakable
    {
        public string Brak() => "Köpek havlayabilir";

        public string Run() => "Köpek koşabilir";
    }
}

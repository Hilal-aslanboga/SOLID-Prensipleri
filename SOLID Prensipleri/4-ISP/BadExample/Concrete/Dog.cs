using SOLID_Prensipleri._4_ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri._4_ISP.BadExample.Concrete
{
    public class Dog : IAnimal
    {
        public string Bark() => "Köpek havlayabilir";

        public string Fly() => "Köpek uçamaz";

        public string Run() => "Köpek koşabilir";
    }
}

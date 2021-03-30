using SOLID_Prensipleri._4_ISP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri._4_ISP.GoodExample.Concrete
{
    public class Bird : IFlyable,IRunnable
    {
        public string Fly() => "Kuş Uçabilir";

        public string Run() => "Kuş koşabilir";
    }
}
// Interface aracılığı ile gerekli yetenekleri kalıtım vermiş olduk.
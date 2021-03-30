using SOLID_Prensipleri._2_OCP.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri._2_OCP.GoodExample.Concrete
{
    public class FishBurger : GoodHamburger
    {
        public override double GetTotalPrice(double amount) => amount * 28.5;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri._2_OCP.GoodExample.Abstract
{
    //Yapılan değişikliklere kapatmak için abstract olarak işaretledik. Çünkü abstaract olarak işaretlenmiş bir üye değişiklige izin vermez.
    public abstract class GoodHamburger
    {
        public abstract double GetTotalPrice(double amount);
    }
}

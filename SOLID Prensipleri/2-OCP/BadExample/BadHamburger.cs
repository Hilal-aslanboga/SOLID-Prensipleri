using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri._2_OCP.BadExample
{
    public enum HamburgerType {CheeseBurger=1,ChickenBurger=2,FishBurger=3 }

    public class BadHamburger
    {
        public double GetTotalprice(double amount,HamburgerType hamburgerType)
        {
            double totalPrice = 0;

            if (hamburgerType == HamburgerType.CheeseBurger) totalPrice += amount * 25.5;
            else if (hamburgerType == HamburgerType.ChickenBurger) totalPrice += amount * 23.5;
            else if (hamburgerType == HamburgerType.FishBurger) totalPrice += amount * 28.5;

            return totalPrice;
        }
    }
    // OCP ye ters düşüyoruz çünkü sınıf içersine yeni eklenen hamburger olabilir. Bunun için enumda değişiklik yapacağız. Buda OCP istemediği bir yapıdır.
}

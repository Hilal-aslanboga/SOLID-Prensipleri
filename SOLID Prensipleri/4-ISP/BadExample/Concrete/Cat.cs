using SOLID_Prensipleri._4_ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri._4_ISP.BadExample.Concrete
{
    public class Cat : IAnimal
    {
        public string Bark() => "Kedi havlayamaz";

        public string Fly() => "Kedi uçamaz";

        public string Run() => "Kedi koşabilir";
}

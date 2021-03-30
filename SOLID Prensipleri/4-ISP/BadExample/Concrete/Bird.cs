using SOLID_Prensipleri._4_ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri._4_ISP.BadExample.Concrete
{
    public class Bird : IAnimal
    {
        public string Bark() => "Kuş havlayamaz";

        public string Fly() => "Kuş uçabilir";

        public string Run() => "Kuş koşabilir";
    }
}
// Örneğimizde kuş sınıfının gereksiz yere yetenek ve özellik kazandırılıdğını görüyoruz. Bunun yerine her bir yetenek için interface oluşturup ilgili sınıfa kalıtım vermemiz gerekir. 

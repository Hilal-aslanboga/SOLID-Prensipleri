using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri._4_ISP.BadExample.Interface
{
    public interface IAnimal
    {
        string Fly();
        string Run();
        string Bark();
    }
}

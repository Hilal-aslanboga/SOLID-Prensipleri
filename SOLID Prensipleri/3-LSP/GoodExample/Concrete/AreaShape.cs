using SOLID_Prensipleri._3_LSP.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri._3_LSP.GoodExample.Concrete
{
    public class AreaShape : BaseShape
    {
        public override double Edge { get; set; }

        public double AreaCalculater() => Edge * Edge;
    }
}

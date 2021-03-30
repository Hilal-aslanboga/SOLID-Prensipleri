using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri._3_LSP.GoodExample.Abstract
{
    public abstract class BaseShape
    {
        //dörtgenlerde ortak olan sadece kenar olduğu için ata sınıfın alt sınıflara vericeği tek yetenek kenardır.
        public abstract double Edge { get; set; }
    }
}

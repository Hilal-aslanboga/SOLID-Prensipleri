using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri._3_LSP.BadExample
{
    public class BadRectangle //Ata sınıf
    {
        public virtual int Height { get; set; }
        public virtual int Widht { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri._3_LSP.BadExample
{
    public class BadArea:BadRectangle // alt sınıf
    {
        int _height;
        public override int Height
        {
            get=>_height;
            set=>_height=value;
        }

        int _widht;
        public override int Widht
        {
            get => _widht;
            set=>_widht=value;
        }
    }
}

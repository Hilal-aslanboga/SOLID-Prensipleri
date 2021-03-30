using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri._3_LSP.BadExample
{
    public class BadAreaCalculater
    {
        //sınıfın içersindeki üyeyi static olarak sabitledik çünkü alan hesaplama 
        public static double CalculateArea(BadRectangle badRectangle) => badRectangle.Height * badRectangle.Widht;

        public static double CalculateArea(BadArea badArea) => badArea.Widht * badArea.Height;
    }
}
// Yapmış olduğumuz örnekte LSP ye ters düşmüş olduk çünkü dörtgen ailesinde olan dikdörtgen ve kare şekilleri birbirleri arasında yer değiştirebilir değildir dikdörtgenin yükseklik ve genişliği vardır. Karenin sadece yüksekliği vardır.Alan hesaplarken yükseklik * genişlik yapılmaktadır. Karenin genişliği olmadığı için prensibe ters düşmüş olduk.

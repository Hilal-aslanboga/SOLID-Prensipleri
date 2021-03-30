using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri._5_DIP.BadExample
{
    public class BadMarket
    {
        BadCleaningProducts clean = new BadCleaningProducts();
        BadDelicatessenProducts delicatessen = new BadDelicatessenProducts();

        public string GeneralInstruction() => clean.BadCleaningProductsSortingInstruction() + "" + delicatessen.BadDelicatessenProductsSortingInstruction();
    }
}
// Sınıfların yetenek ve özelliklerine erişebilmek için örneklemini çıkardık. Prensibe ters düştüğümüz nokta sınıfları bir birlerine sıkı sıkıya bağlamış olduk. Yapılan herhangi bir değişiklik sonucunda sınıflar birbirlerine bağlı olduğundan değişiklik sonucunda etkilenen sınıf sayısı maksimuma çıkıyor. Bellek yönetimi açısından bir birini referance eden yada bağlı sınıfların bellekten kaldırılma yada bellekte yaşama süreleri bağlantılarından dolayı daha uzundur.

    //DIP bize instance almak yerine örneklem almak zorunda olduğumuz sınıfı injeck etmemizi söylemektedir. 
using SOLID_Prensipleri.SRP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri.SRP.GoodExample
{
    public class InsertProduct
    {
        Logger logger;

        // Constructor methodun içersine Logger sınıfını instance aldık. InsertProduct sınıfı çalıştığı zaman constructor methodu Logger sınıfınıda otomatik olarak çalıştırıcaktır.

        public InsertProduct() => logger = new Logger();

        string log;

        public bool CreateProduct(Product product)
        {
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                stringBuilder.Append(product.Id);
                stringBuilder.AppendLine();
                stringBuilder.Append(product.Name);
                stringBuilder.AppendLine();
                stringBuilder.Append(product.UnitPrice);
                stringBuilder.AppendLine();
                stringBuilder.Append(product.UnitStock);
                stringBuilder.AppendLine();
                stringBuilder.Append(product.HireDate.ToString());

                log = logger.BuildLog(stringBuilder.ToString()); // log bilgisi getirildi,
                logger.LogFile(@"C:\Log.txt", log);//log kayıt edildi.

                return true;
            }
            catch (Exception ex )
            {
                log = logger.BuildLog($"Hata Mesajı: {ex.Message}");
                logger.LogFile(@"C:\Log.txt", log);

                return false;
            }
            
        }
    }
    // SRP uyarak gerçekleştirdiğimiz projede logları tutucak bir sınıf açtık içersine log bilgilerini yazdık ve veri tabanında kullanıcıya ürün eklemek için bir sınıf açtık.
}

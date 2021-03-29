using SOLID_Prensipleri.SRP.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri.SRP.BadExample
{
    //Bu örnekte 2 iş bulunmaktadır.Ürün bilgilerini db ye kaydedilmesi ve bu işlemde alınan hataların loglanma süreci.

    public class BadProduct
    {
        public void CreateProduct(Product product)
        {
            StringBuilder stringBuilder = new StringBuilder(); // string verilerin + operatörüyle birleşme işleminin aynısıdır. Ancak + operatörüyle stringler birleştirilirken bellekte birsürü geçici string ifadeler oluşturur. Performans kaybına yol açar. Onun için StringBuilder sınıfını kullanıyoruz.

            try
            {
                // Ürünlerin bilgileri kaydedilmesi
                stringBuilder.Append(product.Id);
                stringBuilder.AppendLine();
                stringBuilder.Append(product.Name);
                stringBuilder.AppendLine();
                stringBuilder.Append(product.UnitPrice);
                stringBuilder.AppendLine();
                stringBuilder.Append(product.UnitStock);
                stringBuilder.AppendLine();
                stringBuilder.Append(product.HireDate);
                File.WriteAllText(@"C:\ProductData.txt", stringBuilder.ToString());

                // Ürün logları tutulması
                stringBuilder = new StringBuilder();
                stringBuilder.Append("Kayıt ekleme tarihi");
                stringBuilder.Append(DateTime.Now.ToString());
                stringBuilder.AppendLine();
                stringBuilder.Append(product.Id);
                File.WriteAllText(@"C:\Log.txt", stringBuilder.ToString());
            }
            catch (Exception ex)
            {
                //urun eklenmesi durumunda oluşabilecek hata logları

                stringBuilder = new StringBuilder();
                stringBuilder.Append("Hata Tarihi");
                stringBuilder.Append(DateTime.Now.ToString());
                stringBuilder.AppendLine();
                stringBuilder.Append("Hata Mesajı");
                stringBuilder.Append(ex.Message);
                File.WriteAllText(@"C:\Log.txt", stringBuilder.ToString());
                System.Windows.Forms.MessageBox.Show("İşlem Başarısız");
            }
        }
    }
    // Yapmış olduğumuz örnekte SRP ters düşmüş olduk. Bir sınıf içersine birden çok iş yükledik. Bunun yerine işleri yapan ayrı ayrı sınıflar açmaktır.
}

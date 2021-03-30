# Yazılım Prensipleri

## SOLID-Prensipleri

SOLID yazılım prensipleri geliştirilen yazılımın esnek, yeniden kullanılabilir, sürdürülebilir ve anlaşılır olmasını sağlayan, kod tekrarını önleyen ve Robert C. Martin tarafından öne sürülen prensipler bütünüdür. 
Kısaltması Michael Feathers tarafından tanımlanan bu prensiplerin amacı
Geliştirdiğimiz yazılımın gelecekte gereksinimlere kolayca adapte olması,
Yeni özellikleri kodda bir değişikliğe gerek kalmadan kolayca ekleyebileceğimiz
Yeni gereksinimlere karşın kodun üzerinde en az değişimi sağlaması,
Kod üzerinde sürekli düzeltme hatta yeniden yazma gibi sorunların yol açtığı zaman kaybını da minimuma indirmektir.

### [Single  Responsibility Principle](https://github.com/Hilal-aslanboga/SOLID-Prensipleri/tree/master/SOLID%20Prensipleri/1-SRP)

Bu ilkede, tüm sınıfların ve tüm yöntemlerin tek bir sorumluluğu olmalıdır. Yani, bu ilkede ana nokta "Sadece bir iş yapın ve en iyisi olun". Aksi takdirde kodumuz spagetti kodları ve okumaya çalışırken diğerleri olacaktır. kodumuz karmaşık olabilir. Bu ilkeye uygun şekilde uymak için; proje başlamadan önce iki soru soruyoruz?
1. Bu yöntem bu sınıfta olmalı mı?
2. Bu iş bu yönteme / sınıfa mı ait?
Bu ilke için projede örnekler verdim.

### Open Closed Principle

Bu ilke, sınıfın kolayca genişletilmesi gerektiğini, ancak temel uygulamalarını değiştirmeye gerek olmadığını önermektedir. "Sınıflar değiştirilemez, ancak diğer yandan Sınıflar iyileştirmeye / gelişmeye açık olmalıdır.
Uygulama veya yazılım esnek olmalıdır. Bir sistemde değişim yönetiminin nasıl uygulandığı, o uygulamanın / yazılımın başarısı üzerinde önemli bir etkiye sahiptir. OCP, sistemin davranışlarının mevcut uygulamasını değiştirmek zorunda kalmadan genişletilebileceğini belirtir.

###  Liskov Substitution Principle

Robert C. Martin'in tanımı: Temel sınıflara işaretçiler veya referanslar kullanan işlevler, türetilmiş sınıfların nesnelerini bilmeden kullanabilmelidir.
Liskov ikame ilkesi (LSP), başlangıçta Barbara Liskov tarafından Veri soyutlama ve hiyerarşi başlıklı 1987 konferans açılış konuşmasında tanıtılan, (güçlü) davranışsal alt tipleme olarak adlandırılan bir alt tipleme ilişkisinin bir tanımıdır. LSP, alt sınıfın kendi ebeveyn sınıfı için mükemmel şekilde ikame edilebilir olması gerektiğini belirtir. C sınıfı P'den türetilmişse, C, P'nin yerine geçebilir.
Kodumuzda mirasın doğru uygulanıp uygulanmadığını LSP kullanarak kontrol edebiliriz.
LSP, SOLID Prensiplerinin temel bir ilkesidir ve program veya modül temel sınıf kullanıyorsa, türetilmiş sınıfın orijinal uygulamalarını değiştirmeden temel sınıflarını genişletebilmesi gerektiğini belirtir.

### Interface Segregation Principle

Hiçbir müşteri kullanmadığı yöntemleri uygulamaya zorlanmamalı ve sözleşmeler ince olanlara bölünmelidir.
ISP, ilk olarak Robert C. Martin tarafından Xerox'a danışılırken kullanıldı ve formüle edildi. Arayüz ayırma prensibi, uygulamanın tasarım problemini çözmek için gereklidir. Tüm görevler tek bir sınıf tarafından yapıldığında veya başka bir deyişle, hemen hemen tüm uygulama sınıflarında bir sınıf kullanıldığında, aşırı yüklü bir şişman sınıf haline gelmiştir. Böyle bir sınıfın devralınması, türetilmiş sınıflarla ilgili olmayan paylaşım yöntemlerine sahip olmakla sonuçlanacaktır, ancak bu, türetilmiş sınıfta miras alacak şekilde temel sınıftadır.
ISP kullanarak, aynı işi yapacak tek bir sınıfa sahip olmak yerine her işlem veya gereksinim için ayrı arayüzler oluşturabiliriz.

### Dependency Inversion Principle

Bu ilke, bileşenler arasındaki bağımlılıklar ile ilgilidir. DIP'nin tanımı Robert C. Martin tarafından aşağıdaki gibidir:
1-Yüksek seviyeli modüller, düşük seviyeli modüllere bağlı olmamalıdır. Her ikisi de soyutlamalara bağlı olmalıdır.
2-Soyutlamalar ayrıntılara bağlı olmamalıdır. Detaylar soyutlamalara bağlı olmalıdır.
İlke, yüksek seviyeli modüllerin, düşük seviyeli modüllerin ayrıntılarına değil, soyutlamaya bağlı olması gerektiğini söylüyor. Basit bir deyişle, ilke, yazılım bileşenleri arasında sıkı bir bağlantı olmaması gerektiğini ve bundan kaçınmak için bileşenlerin soyutlamaya bağlı olması gerektiğini söyler.

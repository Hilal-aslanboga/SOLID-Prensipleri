# Yazılım Prensipleri

## SOLID-Prensipleri
SOLID yazılım prensipleri geliştirilen yazılımın esnek, yeniden kullanılabilir, sürdürülebilir ve anlaşılır olmasını sağlayan, kod tekrarını önleyen ve Robert C. Martin tarafından öne sürülen prensipler bütünüdür. 
Kısaltması Michael Feathers tarafından tanımlanan bu prensiplerin amacı
Geliştirdiğimiz yazılımın gelecekte gereksinimlere kolayca adapte olması,
Yeni özellikleri kodda bir değişikliğe gerek kalmadan kolayca ekleyebileceğimiz
Yeni gereksinimlere karşın kodun üzerinde en az değişimi sağlaması,
Kod üzerinde sürekli düzeltme hatta yeniden yazma gibi sorunların yol açtığı zaman kaybını da minimuma indirmektir.

### Single  Responsibility Principle
Bu ilkede, tüm sınıfların ve tüm yöntemlerin tek bir sorumluluğu olmalıdır. Yani, bu ilkede ana nokta "Sadece bir iş yapın ve en iyisi olun". Aksi takdirde kodumuz spagetti kodları ve okumaya çalışırken diğerleri olacaktır. kodumuz karmaşık olabilir. Bu ilkeye uygun şekilde uymak için; proje başlamadan önce iki soru soruyoruz?
1. Bu yöntem bu sınıfta olmalı mı?
2. Bu iş bu yönteme / sınıfa mı ait?
Bu ilke için projede örnekler verdim.

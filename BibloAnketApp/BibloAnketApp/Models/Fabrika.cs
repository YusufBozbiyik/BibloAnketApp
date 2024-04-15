using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BibloAnketApp.Models
{
    public class Fabrika
    {
        public static List<Kategori> Kategoriler { get; set; } = new List<Kategori>
        {
            new Kategori { Id=2,Ad="İdeoloji"},
            new Kategori { Id=3,Ad="Eğlence"},
            new Kategori { Id=4,Ad="Psikoloji"}
        };
        public static List<Anket> Anketler { get; set; } = new List<Anket>
        {
            new Anket {
                Id=4,
                Ad="Otizm Testi", 
                Resim="otizm.jpg",
                KategoriId =4, 
                HaftanınAnketiMi=true,
                KısaAciklama="Bu test, size 10 farklı alanda otizm spektrumu oluşumlarını ölçen tek bir bileşik test sunmak için otizm spektrumunu araştırmaya yönelik önceki birkaç çalışmanın içgörülerini birleştirir." ,
                DetayAciklamaUst="Otizm spektrumu, hepsi klasik otizm, Asperger sendromu veya Rett sendromu gibi bozuklukların varlığına işaret eden bir dizi nörogelişimsel durumu kapsar. Ancak semptomların tipi ve şiddetinde önemli farklılıklar vardır. Bu test, size 10 farklı alanda otizm spektrumu oluşumlarını ölçen tek bir bileşik test sunmak için otizm spektrumunu araştırmaya yönelik önceki birkaç çalışmanın içgörülerini birleştirir.",
                DetayAciklamaAlt ="IDRlabs ASD Testi (IDR-ASDT), IDRlabs tarafından geliştirilmiştir. IDR-ASDT, Dr. Sarah L. Barret, Dr. Mirko Uljarevic, Dr. Emma K. Baker, Dr. Amanda L. Richdale, Dr. Catherine R.G. Jones ve Yetişkinlerde Tekrarlayan Davranışlar Anketi-2'yi (RBQ-2A) oluşturan Dr. Susan R. Leekam. IDR-ASDT'nin yukarıda adı geçen araştırmacıların hiçbiriyle ilişkisi yoktur." +
                " DRlabs Otizm Spektrum Testi, Barret, S., Uljarevic, M., Baker, E., Richdale, A., Jones, C. ve Leekam, S.'de yayınlanan RBQ-2A'nın OSB kriterlerine göre hazırlanmıştır ( 2015)." +
                " Yetişkinlerde Tekrarlayan Davranışlar Anketi-2 (RBQ-2A): Kısıtlı ve tekrarlayan davranışların öz bildirim ölçüsü. Otizm ve Gelişimsel Bozukluklar Dergisi, 45(11): 3680–3692; Barrett, S.L., Uljarević, M., Jones, C.R.G. ve ark. Otistik yetişkinlerde Yetişkin Tekrarlayan Davranış Anketi-2'yi kullanarak kısıtlı ve tekrarlayan davranışların alt türlerinin değerlendirilmesi. Moleküler Otizm 9, 58 (2018); Allely, CS (2019). Tekrarlayan davranışların ve sınırlı ilgi alanlarının kadın otizm fenotipini araştırmak: Sistematik bir PRISMA incelemesi. Salford Üniversitesi Kurumsal Deposu. Dr. Barret, Dr. Uljarevic, Dr. Baker, Dr. Richdale, Dr. Jones ve Dr. Leekam'ın çalışmaları aynı zamanda yaygın olarak kullanılan psikolojik araç olan RBQ-2A formundaki bazı teşhis kriterlerine de bilgi sağlamıştır. " +
                "özellikle nitelikli ruh sağlığı profesyonelleri tarafından klinik kullanım için. Mevcut test yalnızca eğitim amaçlıdır. IDRlabs ve mevcut IDRlabs ASD Testi, yukarıda belirtilen araştırmacılardan, kuruluşlardan veya bunların bağlı kuruluşlarından bağımsızdır."
            },
            new Anket {
                Id=2,
                Ad="IQ Testi",
                Resim="aptitude-iq-button.jpg",
                KategoriId =3,
                HaftanınAnketiMi=true,
                KısaAciklama="IQ derecenizin ne olduğunu öğrenmek istiyorsanız tıklayın." ,
                DetayAciklamaUst="",
                DetayAciklamaAlt =""
            },
            new Anket {
                Id=3,
                Ad="Cinsiyet Testi",
                Resim="gender-book-genre-button.jpg",
                KategoriId =3,
                HaftanınAnketiMi=false,
                KısaAciklama="Hangi Cinsiyetsiniz öğrenmek istiyorsanız tıklayın." ,
                DetayAciklamaUst="",
                DetayAciklamaAlt =""
            },
            new Anket {
                Id=2,
                Ad="Politik Test",
                Resim="political-coordinates-button.jpg",
                KategoriId =2,
                HaftanınAnketiMi=false,
                KısaAciklama="Bu ücretsiz siyasi gözlem testi, Batı demokrasilerinde bulunan iki önemli siyasi ölçekte puanlarınızı almanızı sağlayacaktır" ,
                DetayAciklamaUst="",
                DetayAciklamaAlt =""
            },
            new Anket {
                Id=2,
                Ad="Sadistlik Testi",
                Resim="3-minute-narcissism-button-1.jpg",
                KategoriId =4,
                HaftanınAnketiMi=true,
                KısaAciklama="Sadizm, kendini geliştirme aracı olarak başkalarına karşı saldırgan davranma ve/veya onları aşağılama eğilimidir." ,
                DetayAciklamaUst="",
                DetayAciklamaAlt =""
            },
            new Anket {
                Id=2,
                Ad="Narsistlik Testi",
                Resim="6-minute-sadism-button-1.jpg",
                KategoriId =4,
                HaftanınAnketiMi=false,
                KısaAciklama="Dr. Robert Raskin'in (Ph.D.) çalışmasına dayanmaktadır. ve Dr. Calvin Hall, Ph.D." ,
                DetayAciklamaUst="",
                DetayAciklamaAlt =""
            }

        };
    }
}

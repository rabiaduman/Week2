
Console.InputEncoding = System.Text.Encoding.UTF8; //Kullanıcının girdiği metni doğru şekilde alabilmek için UTF-8 kodlaması ile okuma yapar.UTF-8; Türkçe, Arapça, Çince, Japonca gibi birçok dildeki karakterleri destekler.

Console.WriteLine("*************TATİL UYGULAMASI*************\n");

string tatilPlani;

do  //do while ile 1 kez tatil planını sordum, başka plan yapmak istediği sürece tüm sorular tekrar edecek
{
        string lokasyon;

    do //lokasyon seçimini 1 kez soruyorum daha sonra doğru seçim yapana kadar lokasyon sorusu tekrar ediyor
    {

        Console.WriteLine("Nereye Seyehat Etmek İstersiniz?\nBodrum(Paket başlangıç fiyatı 4000 TL)\nMarmaris(Paket başlangıç fiyatı 3000 TL)\nÇeşme(Paket başlangıç fiyatı 5000 TL)");

        lokasyon = Console.ReadLine().ToLower(); //Kullanıcının girdiği veriyi bir değişkende tutalım.

        if (lokasyon != "bodrum" && lokasyon != "marmaris" && lokasyon != "çeşme")
        {
            Console.WriteLine("Geçersiz Lokasyon, Tekrar giriniz!");
        }

    } while (lokasyon != "bodrum" && lokasyon != "marmaris" && lokasyon != "çeşme");

    Console.WriteLine("Kaç Kişilik Tatil Planlıyorsunuz?");

    int kisiSayisi = Convert.ToInt32(Console.ReadLine()); //Kişi sayısını bir değişkende tutalım.

    int paketFiyati = 0; //Lokasyon fiyatları

    //3 adet lokasyonumuz var:
    switch (lokasyon)

    {
        case "bodrum":
            paketFiyati = 4000;
            Console.WriteLine("\nBodrum tatili planlıyorsanız bol bol eğleneceğinizi, en güzel koylarda denize gireceğinizi ve tarihi bölgeleri kolaylıkla gezebileceğinizi bilmelisiniz! Bodrum merkez de dahil olmak üzere akşam eğlenceleri en popüler aktivitelerden. Dalış gibi su sporları imkanı ve gezilecek birçok bölge bulunması Bodrum'da aradığınız her şeyi bulabileceğinizin göstergesi!");
            break;

        case "marmaris":
            paketFiyati = 3000;
            Console.WriteLine("\nMarmaris!Yaz aylarının gözde şehirlerinden olan bölgede denizin ve güneşin dinlendirici etkisiyle tatilinizi geçirebilir, coğrafi güzellikleri keşfederek, deniz ve ormanların birleştiği kumsallarda çeşitli aktivitelere katılabilirsiniz.");
            break;

        case "çeşme":
            paketFiyati = 5000;
            Console.WriteLine("\nÇeşme, yaz aylarının vazgeçilmez tatil bölgelerinden biri. Eğlence dolu yaz tatili yapmak isteyenlerin ilk duraklarından olan bölgede, plaj partileri ve su sporları en gözde aktivitelerden. Rüzgar sörfü, dalış ve tekne turları bölgede en çok yapılan faaliyetlerden.Çeşme tatili planlarken bol bol eğlenmeye, Ege'nin en güzel koylarında yüzmeye hazırlıklı olun!");
            break;

        default:
            break;


    }

    int ulasimSec; //Hangi ulaşım yoluyla gidileceği

    do //Ulaşım yolunu 1 kez soruyorum, doğru yanıtlayana kadar ulaşım sorusu tekrar ediyor
    {
        Console.WriteLine("\nTatile Hangi Şekilde Gitmek İstersin?\n2 seçeneğimiz var:\n1 - Kara yolu(Kişi başı ulaşım tutarı gidiş - dönüş 1500 TL)\n2 - Hava yolu(Kişi başı ulaşım tutarı gidiş - dönüş 4000 TL)\nLütfen yukarıdaki seçeneklerden bir tanesini seçiniz(1 veya 2)");

        ulasimSec = Convert.ToInt32(Console.ReadLine());

        if (ulasimSec != 1 && ulasimSec != 2)
        {
            Console.WriteLine("Geçersiz Seçim, Tekrar giriniz!");
        }

    } while (ulasimSec != 1 && ulasimSec != 2);


    int ulasimFiyati = 0;

    switch (ulasimSec)
    {
        case 1:
            ulasimFiyati = 1500;
            break;
        case 2:
            ulasimFiyati = 4000;
            break;
    }


    int toplamFiyat = (paketFiyati + ulasimFiyati) * kisiSayisi; //Seçilenlere göre toplam fiyat hesaplama

    Console.WriteLine($"{lokasyon} ilçesinde {kisiSayisi} kişilik bir tatil ulaşım fiyatıyla birlikte minimum {toplamFiyat} TL yapar. Keyifli Tatiller!");

    Console.WriteLine("Başka tatil planlamak ister misin? e - evet / h - hayır");

    tatilPlani = Console.ReadLine().ToLower();

    if( tatilPlani == "h")
    {
        Console.WriteLine("Pekala, İYİ GÜNLER!");
    }
 

} while (tatilPlani == "e");


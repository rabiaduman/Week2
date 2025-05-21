//1 - Aşağıdaki çıktıyı yazan bir program.

//Merhaba
//Nasılsın ?
//İyiyim
//Sen nasılsın ?

//Console.WriteLine("Merhaba\nNasılsın ?\nİyiyim\nSen nasılsın ?");

//-------------------------------------------------------------------------------------------------------------------------

//2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.

//string selam;

//int sayi;

//selam = "Merhaba";
//sayi = 21;

//Console.WriteLine($"metin {selam} , sayı {sayi}");

//-------------------------------------------------------------------------------------------------------------------------

//3 - Rastgele bir sayı üretip , ekrana yazdırınız.

//Random rnd = new Random();

//int sayi = rnd.Next();

//Console.WriteLine("rasgele sayı: " + sayi);

//-------------------------------------------------------------------------------------------------------------------------

//4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.

//Random rnd = new Random();

//int sayi =  rnd.Next();

//Console.WriteLine("rastgele sayi: " + sayi + "\nsayının 3e bölümünden kalan: " + sayi%3 );

//-------------------------------------------------------------------------------------------------------------------------

//5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.

//Console.WriteLine("Yaşınız kaç?");
//int yas = Convert.ToInt32(Console.ReadLine());

//if (yas > 18)
//    Console.WriteLine("+");
//else 
//    Console.WriteLine("-");

//-------------------------------------------------------------------------------------------------------------------------

//6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
//}

//-------------------------------------------------------------------------------------------------------------------------

//7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.

//Console.WriteLine("1.metni gir: ");
//string metin1 = Console.ReadLine();

//Console.WriteLine("2.metni gir: ");
//string metin2 = Console.ReadLine();

//(metin1,metin2) = (metin2, metin1);

//Console.WriteLine("1.metin: " + metin1 + "\n2.metin: " + metin2);

//-------------------------------------------------------------------------------------------------------------------------

//8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.

//void BenDegerDondurmem()
//{
//    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
//}

//BenDegerDondurmem();

//-------------------------------------------------------------------------------------------------------------------------

//9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

//int Topla (int x, int y)
//{
//    return x + y;
//}

//Console.WriteLine("1.sayıyı gir: ");
//int sayi1 = Convert.ToInt32 (Console.ReadLine());
//Console.WriteLine("2.sayıyı gir: ");
//int sayi2= Convert.ToInt32 (Console.ReadLine());

//Console.WriteLine("sayıların toplamı: " + Topla(sayi1,sayi2));

//-------------------------------------------------------------------------------------------------------------------------

//10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.

//string DegerDondur (bool a)
//{
//    string secim;

//    if (a)
//    {
//        secim = "true girdiniz.";
//    }
//    else 

//        secim = "false girdiniz.";

//    return secim;
//}

//Console.WriteLine("true ya da false giriniz");
//bool giris = Convert.ToBoolean(Console.ReadLine());

//Console.WriteLine(DegerDondur(giris));

//-------------------------------------------------------------------------------------------------------------------------

// 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

//int EnYasli(int[] yas)
//{
//    return yas.Max();
//}

//int[] yaslar = new int[3];

//for (int i = 0; i < yaslar.Length; i++)
//{
//    Console.WriteLine("Yas giriniz: ");
//    yaslar[i] = Convert.ToInt32(Console.ReadLine());
//}

//Console.WriteLine("en yaşlı : " + EnYasli(yaslar));

//-------------------------------------------------------------------------------------------------------------------------

//12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.

//int SınırsızSayıGirisi()
//{
//    int[] sayilar = new int[0];

//    while (true)
//    {
//        Console.WriteLine("Bir sayı giriniz:");
//        int sayi = Convert.ToInt32(Console.ReadLine());

//        Array.Resize(ref sayilar, sayilar.Length + 1);

//        sayilar[sayilar.Length - 1] = sayi;

//        Console.WriteLine("En büyük sayı: " + sayilar.Max());

//        Console.WriteLine("Çıkmak için 'e' harfine basınız, devam etmek için rastgele bir tuşa basınız");
//        char cikis = Convert.ToChar(Console.ReadLine());

//        if (cikis == 'e')
//        {
//            break;
//        }

//    }

//    return sayilar.Max();
//}

//SınırsızSayıGirisi();

//-------------------------------------------------------------------------------------------------------------------------

//13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

//void YerDegistir()
//{

//    Console.WriteLine("1.metni gir: ");
//    string isim1 = Console.ReadLine();

//    Console.WriteLine("2.metni gir: ");
//    string isim2 = Console.ReadLine();

//    (isim1, isim2) = (isim2, isim1);

//    Console.WriteLine("1.isim: " + isim1 + "\n2.isim: " + isim2);
//}

//YerDegistir();

//-------------------------------------------------------------------------------------------------------------------------

//14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.

//bool CiftMi()
//{
//    Console.WriteLine("Bir sayı giriniz: ");
//    int sayi = Convert.ToInt32(Console.ReadLine());


//    return sayi % 2 == 0;
//}

//Console.WriteLine(CiftMi());

//-------------------------------------------------------------------------------------------------------------------------

//15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

//void YolHesapla()
//{

//    Console.WriteLine("Hızınız kaç km: ");
//    int hiz = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Kaç saatte gittiniz: ");
//    double zaman = Convert.ToDouble(Console.ReadLine());

//    double yol = hiz * zaman;

//    Console.WriteLine(yol + " km gittiniz.");
//}

//YolHesapla();

//-------------------------------------------------------------------------------------------------------------------------

//16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

//void DaireAlanHesabı()
//{
//    Console.WriteLine("Dairenin yarıçapını giriniz: ");
//    int r = Convert.ToInt32(Console.ReadLine());

//    double pi = 3.14;

//    Console.WriteLine("Dairenin alanı: " + pi* Math.Pow(r,2));
//}

//DaireAlanHesabı();

//-------------------------------------------------------------------------------------------------------------------------

//17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

//string cumle = "Zaman bir GeRi SayIm";

//Console.WriteLine(cumle.ToUpper());
//Console.WriteLine(cumle.ToLower());

//-------------------------------------------------------------------------------------------------------------------------

//18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

//string selam = "    Selamlar   ";

//Console.WriteLine(selam);

//selam = selam.Trim();

//Console.WriteLine(selam);

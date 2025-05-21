

//Geriye Değer Döndürmeyen Bir void metot.
//Ekrana sevdiğiniz bir şarkı sözünü yazdırsın. 

void SarkiSozu()
{
    Console.WriteLine("Birden dursun istersin seneler olunca mazi, öyle bir geçer zaman ki");
}

SarkiSozu();

//Geriye Tamsayı Döndüren Bir metot
//Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.

int BolumdenKalan()
{
    Random rnd = new Random();

    int sayi = rnd.Next();

    int kalan = sayi % 2;

    return kalan;

}

Console.WriteLine(BolumdenKalan());


//Parametre Alan ve Geriye Değer Döndüren Bir Metot
//Parametre olarak aldığı iki sayının çarpımını geriye dönsün.

int SayilariCarp(int a, int b)
{
    return a * b;
}

Console.WriteLine("Sayıların çarpımı: "+ SayilariCarp(3,5));


//Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
//Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.

void Hosgeldin( string ad, string soyad)
{
    Console.WriteLine("Hoşgeldiniz "+ ad +" "+ soyad);
}

Console.WriteLine("adınız: ");
string ad = Console.ReadLine();
Console.WriteLine("soyadınız: ");
string soyad = Console.ReadLine();

Hosgeldin(ad, soyad);

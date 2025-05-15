//1->Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

//int i = 0;

//while(i<10)
//{
//    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
//    i++;
//}

//-------------------------------------------------------------------------------------------------

//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

//int i = 1;

//while (i<21)
//{
//    Console.WriteLine(i);
//    i++;
//}

//-------------------------------------------------------------------------------------------------

//3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

//int i = 1;

//while (i<21)
//{
//    if (i%2 == 0)
//        Console.WriteLine(i);
//    i++;
//}

//-------------------------------------------------------------------------------------------------

//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

//int i = 50;
//int toplam = 0;

//while (i<151)
//{
//    toplam += i;
//    i++;
//}
//Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);

//-------------------------------------------------------------------------------------------------

//5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int i = 1;
int tekToplam = 0; //tek sayıların toplamı
int ciftToplam = 0; //cift sayıların toplamı

while (i < 121)
{
    if (i % 2 == 0)
    {
        ciftToplam += i;
    }
    else
        tekToplam += i;
    i++;
}

Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + tekToplam + " çift sayıların toplamı: " + ciftToplam);



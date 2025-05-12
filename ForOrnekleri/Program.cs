//1->Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

//for (int i = 0; i<10; i++)
//{
//    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
//}
//---------------------------------------------------------------------------------------------------

//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

//for(int i= 1; i<=20; i++)
//{
//    Console.WriteLine(i);
//}
//---------------------------------------------------------------------------------------------------

//3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

//for (int i = 2; i <= 20; i += 2)
//{
//    Console.WriteLine(i);
//}
//---------------------------------------------------------------------------------------------------

//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

//int toplam = 0;

//for (int i = 50; i <= 150; i++)
//{
//    toplam += i;
//}
//Console.WriteLine(toplam);
//---------------------------------------------------------------------------------------------------

//5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int tekToplam =0 ; //tek sayıların toplamı
int ciftToplam= 0; //cift sayıların toplamı

for (int i = 1; i<=120; i+=2)
{
    tekToplam += i;
}
for (int j = 2; j<=120; j+=2)
{
    ciftToplam += j;
}

Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı {tekToplam}, çift sayıların toplamı {ciftToplam}");


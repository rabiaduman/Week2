
//Kullanıcının girdiği bir limit değerine kadar 0'dan bir sayaç çalıştırıp artırarak, ekrana " Ben bir Patika'lıyım " yazdırınız.

/*While ile yazdığımızda kullanıcıdan alınan limit değeri 0 dan küçük ise koşulu sağlamadığı için döngüye hiç girmiyor, 
 * ekrana yazı gelmiyor. Do while ile yazdığımızda koşul döngünün sonunda kontrol edildiği için kodlar bir kez çalıştırılıyor ve ekrana bir kez yazı yazdırılıyor */

//---------------------------------------WHILE İLE ÇÖZÜM--------------------------------------------------

//Console.WriteLine("Limit değeri giriniz: ");
//int limit = Convert.ToInt32(Console.ReadLine());

//int sayac = 0;

//while (sayac<= limit)
//{
//    Console.WriteLine("Ben bir Patika'lıyım ");
//    sayac++;
//}

//------------------------------------DO WHILE İLE ÇÖZÜM--------------------------------------------------

Console.WriteLine("Limit değeri giriniz: ");
int limit = Convert.ToInt32(Console.ReadLine());

int sayac = 0;

do
{
    Console.WriteLine("Ben bir Patika'lıyım ");
    sayac++;

} while (sayac <= limit);


//--------------------------------------------------------------------------------------------------------
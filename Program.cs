﻿// //Ekranda girilen sayıya kadar olan tek sayıları ekrana yazdır
// Console.WriteLine("Lütfen bir sayı giriniz:");
// int sayac = int.Parse(Console.ReadLine());
// for (int i = 1; i < sayac; i++)
// {
//     if (i%2 == 1)
//     {
//         Console.WriteLine(i);
//     }
// }

// //1 ile 1000 arasındaki tek ve çift sayıları kendi içlerinde toplamlarını ekrana yazdır
// int tekToplam = 0;
// int ciftToplam = 0;
// for (int i = 1; i <= 1000; i++)
// {
//     if (i%2==1)
//         tekToplam += i; //tekToplam = tekToplam + i

//         else
//          ciftToplam += i; //ciftToplam = ciftToplam + i
        
        
    
//     Console.WriteLine("Tek Toplam:" + tekToplam);
//     Console.WriteLine("Çift Toplam:" + ciftToplam);

// }
for (int i = 1; i < 10; i++)
{
    if(i == 4)
       break;
    Console.WriteLine(i); 
}

for (int i = 1; i < 10; i++)
{
    if(i == 4)
       continue;
    Console.WriteLine(i); 
}
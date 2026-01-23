/*
// BruteForce Protect System:

// Değişkenleri Ayırdık

using System;

string sistemSifresi;
string girilenSifre;
int kalanHak;

sistemSifresi = "CyberSecurity2026"; // Bu sabit kalır
girilenSifre = ""; // Kullanıcının yazdığı buraya gelir
kalanHak = 3;

Console.WriteLine("--- GÜVENLİ GİRİŞ SİSTEMİ ---");

while (kalanHak > 0)
{
    Console.Write("Şifre: ");
    girilenSifre = Console.ReadLine(); // Kullanıcının girişini al

    // Kontrol Mekanizması
    if (girilenSifre == sistemSifresi) // Doğruysa
    {
        Console.WriteLine("*************************");
        Console.ForegroundColor = ConsoleColor.Green; // Yeşil Yazı
        Console.WriteLine("Kullanıcı Girişi Başarılı!");
        Console.ResetColor(); // Rengi düzelt
        break; // Döngüyü kır, çık
    } else // Yanlışsa
    {
        kalanHak--; // Hakkı azalt
        
        Console.ForegroundColor = ConsoleColor.Red; // Kırmızı Yazı
    }

    if (kalanHak == 0) // Eğer hak bittiyse (Son tur)
    {
        Console.WriteLine("*************************");
        Console.WriteLine("HAKKINIZ BİTTİ! HESAP BLOKE EDİLDİ 🚨");
    }
    else // Hala hakkı varsa
    {
        Console.WriteLine("Hatalı Şifre Kalan Hak: " + kalanHak);
    }
    
    Console.ResetColor(); // Rengi düzelt
} 

Console.WriteLine("\nSistem Kapatılıyor...");
Console.Read(); // Ekran hemen kapanmasın diye
*/


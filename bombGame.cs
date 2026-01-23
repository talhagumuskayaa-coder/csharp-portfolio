/*Console.WriteLine("--- 💣 Bombayı İmha Etmen Gerekiyor! ---");

int can = 5; 
Random rastgele = new Random();
int sayi = rastgele.Next(1, 101); // 0-100 değil, 1-100 arası olsun diye

// Sadece WHILE yetiyor. Can olduğu sürece dön.
while (can > 0)
{
    Console.Write("\nBombayı Çözmek İçin Şifreyi Gir (1-100): ");
    // Try-Catch veya TryParse kullanmadık ama normalde harf girilirse patlar. Şimdilik OK.
    int tahmin = Convert.ToInt32(Console.ReadLine());

    if (tahmin == sayi) // Önce kazanma durumuna bakalım
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n-------------------");
        Console.WriteLine("✅ ŞİFRE DOĞRU! BOMBA ETKİSİZ HALE GETİRİLDİ 🥳");
        Console.WriteLine("-------------------");
        Console.ResetColor();
        break; // DÖNGÜYÜ KIR VE ÇIK (Oyun Bitti)
    }
    else if (tahmin > sayi)
    {
        Console.WriteLine("🔻 Daha KÜÇÜK bir sayı gir!");
        can--; // Canı azalt
    }
    else if (tahmin < sayi)
    {
        Console.WriteLine("🔺 Daha BÜYÜK bir sayı gir!");
        can--; // Canı azalt
    }

    // Her turun sonunda kalan canı gösterelim
    if (can > 0)
    {
        Console.WriteLine($"Kalan Hakkın: {can}");
    }
}

// Döngüden çıktık. Neden çıktık? Kazandı mı yoksa canı mı bitti?
if (can == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n-------------------");
    Console.WriteLine($"BOOOOOOOMM!! ☠️❌ Patladın! Şifre şuydu: {sayi}");
    Console.WriteLine("-------------------");
    Console.ResetColor();
}*/
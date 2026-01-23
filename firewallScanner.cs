/*Console.WriteLine("--- Razor Firewall Dashboard ---");

// 1. DÜZELTME: Diziyi tek seferde, hatasız tanımlama yöntemi
string[] ipler = { 
    "192.168.1.2", 
    "192.168.1.10", // Arada boşluk kalmadı
    "192.168.1.15", 
    "192.168.1.20", 
    "10.20.1.25", 
    "10.20.1.26", 
    "88.20.1.27", 
    "192.168.1.30",
    "10.5.5.5"      // Ekstra bir tehdit daha
};

int hackerSayisi = 0;

Console.WriteLine("Tarama Başlatılıyor...\n");

// 2. DÖNGÜ
foreach (string ip in ipler)
{
    // Tehdit Kontrolü
    if (ip.StartsWith("10") || ip.StartsWith("88"))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("🚨 TEHDİT ALGILANDI: " + ip);
        hackerSayisi++; // Sayacı artırıyoruz!
    }
    else
    {
        // Güvenli olanları da yeşil gösterelim
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("✅ Güvenli: " + ip);
    }
    
    // Her satırdan sonra rengi normale döndür ki ekran karışmasın
    Console.ResetColor();
}

// 3. RAPORLAMA
Console.WriteLine("\n--------------------------------");
Console.WriteLine("TARAMA TAMAMLANDI.");
Console.WriteLine("Toplam Engellenen Tehdit: " + hackerSayisi);
Console.WriteLine("--------------------------------");*/
Console.WriteLine("*** Taş-Kağıt-Makas Oyunu ***");

string[] secenekler = { "Taş", "Kağıt", "Makas" };

int oyuncuSkor = 0;
int botSkor = 0;

Random rastgele = new Random();

// Döngü Başlangıcı
while (oyuncuSkor < 3 && botSkor < 3)
{
    Console.Write("\nTaş, Kağıt, Makas?: ");
    string oyuncuSecim = Console.ReadLine();
    
    // Bot Seçimi
    int rastgeleSayi = rastgele.Next(0, 3);
    string botSecim = secenekler[rastgeleSayi];
    
    Console.WriteLine("----------------------");
    Console.WriteLine("Botun Hamlesi: " + botSecim); 
    Console.WriteLine("----------------------");

    // --- KONTROLLER ---

    // 1. OYUNCUNUN KAZANDIĞI DURUMLAR
    if (oyuncuSecim == "Makas" && botSecim == "Kağıt")
    {
        oyuncuSkor++;
        Console.WriteLine("🎉 Oyuncu +1 Puan");
        Console.WriteLine("Oyuncu: " + oyuncuSkor + " - Bot: " + botSkor);
    } 
    else if (oyuncuSecim == "Taş" && botSecim == "Makas")
    {
        oyuncuSkor++;
        Console.WriteLine("🎉 Oyuncu +1 Puan");
        Console.WriteLine("Oyuncu: " + oyuncuSkor + " - Bot: " + botSkor);
    } 
    else if (oyuncuSecim == "Kağıt" && botSecim == "Taş")
    {
        oyuncuSkor++;
        Console.WriteLine("🎉 Oyuncu +1 Puan");
        Console.WriteLine("Oyuncu: " + oyuncuSkor + " - Bot: " + botSkor);
    } 
    // 2. BOTUN KAZANDIĞI DURUMLAR
    else if (oyuncuSecim == "Makas" && botSecim == "Taş")
    {
        botSkor++;
        Console.WriteLine("💀 Bot +1 Puan");
        // DÜZELTME: Burası eskiden yanlıştı (Oyuncu yerine botSkor yazıyordu)
        Console.WriteLine("Oyuncu: " + oyuncuSkor + " - Bot: " + botSkor);
    } 
    else if (oyuncuSecim == "Taş" && botSecim == "Kağıt")
    {
        botSkor++;
        Console.WriteLine("💀 Bot +1 Puan");
        // DÜZELTME: Skor değişkeni düzeltildi
        Console.WriteLine("Oyuncu: " + oyuncuSkor + " - Bot: " + botSkor);
    } 
    else if (oyuncuSecim == "Kağıt" && botSecim == "Makas")
    {
        botSkor++;
        Console.WriteLine("💀 Bot +1 Puan");
        // DÜZELTME: Skor değişkeni düzeltildi
        Console.WriteLine("Oyuncu: " + oyuncuSkor + " - Bot: " + botSkor);
    } 
    // 3. BERABERLİK DURUMLARI
    else if (oyuncuSecim == "Makas" && botSecim == "Makas")
    {
        Console.WriteLine("🤝 Berabere");
    } 
    else if (oyuncuSecim == "Taş" && botSecim == "Taş")
    {
        Console.WriteLine("🤝 Berabere");
    }
    else if (oyuncuSecim == "Kağıt" && botSecim == "Kağıt") // BU EKSİKTİ EKLENDİ!
    {
        Console.WriteLine("🤝 Berabere");
    }
}

// --- FİNAL ---
if (botSkor == 3)
{
    Console.WriteLine("\n------------------");
    Console.WriteLine("🔴 KAZANAN BOT");
    Console.WriteLine("------------------");
} 
else if (oyuncuSkor == 3)
{
    Console.WriteLine("\n------------------");
    Console.WriteLine("🟢 KAZANAN OYUNCU");
    Console.WriteLine("------------------");
}

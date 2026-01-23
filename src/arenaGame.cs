/*Console.WriteLine("⚔️ --- GLADYATÖR ARENASINA HOŞ GELDİN --- ⚔️");
Console.WriteLine("Senin Canın: 100 | Canavarın Canı: 100");
Console.WriteLine("------------------------------------------");

int oyuncuCanı = 100;
int canavarCanı = 100;

Random rastgele = new Random();

// Kullanılmayan 'int saldırı' değişkenini sildim.

while (oyuncuCanı > 0 && canavarCanı > 0)
{
    Console.WriteLine("\nSaldırmak İçin 'ENTER' Tuşuna Bas 👊");
    Console.ReadLine(); // Bekleme yapar
    
    // --- SENİN SIRAN ---
    int seninVurusan = rastgele.Next(5, 25); // 0 vurmasın diye en az 5 yaptım
    canavarCanı -= seninVurusan;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("🗡️ Canavara " + seninVurusan + " hasar vurdun!");
    Console.ResetColor();
    Console.WriteLine("👾 Canavarın Kalan Canı: " + canavarCanı);

    // Canavar öldü mü kontrolü
    if (canavarCanı <= 0)
    {
        Console.WriteLine("\n***********************");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("🏆 KAZANDIN! CANAVARI YENDİN!");
        Console.ResetColor();
        Console.WriteLine("***********************");
        break; // Döngüden çık
    }

    // --- CANAVARIN SIRASI ---
    Console.WriteLine("-------------------------");
    Console.WriteLine("Canavar sana saldırıyor...");
    // Heyecan olsun diye programı 1 saniye (1000 ms) uyutuyoruz
    System.Threading.Thread.Sleep(1000); 

    int canavarVurusu = rastgele.Next(5, 25);
    oyuncuCanı -= canavarVurusu;

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("🔥 Canavar sana " + canavarVurusu + " hasar vurdu!");
    Console.ResetColor();
    Console.WriteLine("❤️ Senin Kalan Canın: " + oyuncuCanı);

    // Sen öldün mü kontrolü
    if (oyuncuCanı <= 0)
    {
        Console.WriteLine("\n***********************");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("💀 ÖLDÜN... KAYBETTİN.");
        Console.ResetColor();
        Console.WriteLine("***********************");
        break;
    }
}*/
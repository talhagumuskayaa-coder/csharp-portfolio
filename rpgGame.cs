int level = 1;
int xp = 0;
int gerekenXp = 100;
int secim = 0;

Random rastgele = new Random();

Console.WriteLine("--- RPG OYUNU BAŞLADI ---");

while (true)
{
    Console.WriteLine("\n1. Canavar Avla 🪓"); // \n bir satır boşluk bırakır
    Console.WriteLine("2. Durumuna Bak 🏆");
    Console.WriteLine("3. Oyundan Çık ❌");
    Console.Write("Seçiminiz: ");
    
    secim = Convert.ToInt32(Console.ReadLine());

    switch (secim)
    {
        case 1:
            // Her tur yeni bir zar atılıyor (Doğru Yer!)
            int gelenXp = rastgele.Next(10, 30);
            
            Console.WriteLine("---------------------------------");
            Console.WriteLine("⚔️ Canavarla Savaştın!");
            xp += gelenXp;

            Console.WriteLine("Kazandın! Gelen XP: " + gelenXp);
            
            // Level Kontrolü
            if (xp >= gerekenXp) // Eşitse veya büyükse
            {
                level++;
                xp -= gerekenXp; // Kalan XP'yi devret
                gerekenXp += 50; // Hedefi zorlaştır
                
                Console.WriteLine("🎉 TEBRİKLER LEVEL ATLADIN! Yeni Level: " + level);
            }
            Console.WriteLine("---------------------------------");
            break;

        case 2:
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Aktif Levelin: " + level);
            Console.WriteLine("XP Durumu: " + xp + " / " + gerekenXp);
            Console.WriteLine("---------------------------------");
            break;

        case 3:
            Console.WriteLine("Çıkış Yapılıyor... Güle güle!");
            return; // DÜZELTME BURADA: Programı tamamen kapatır.

        default:
            Console.WriteLine("Lütfen Geçerli Bir Sayı (1-3) Tuşlayınız");
            break;
    }
}

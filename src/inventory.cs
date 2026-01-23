/*Console.WriteLine("--- Envanter Sistemi Başlatıldı ---");

string[] envanter = new string[5];
envanter[0] = "Kılıç";
envanter[1] = "Kalkan";
envanter[2] = "Harita";
envanter[3] = "Yara Bandı";
envanter[4] = "İksir";

while (true)
{
    Console.WriteLine("\n1. Envanteri Görüntüle 🎒");
    Console.WriteLine("2. Eşya Ara 🔧");
    Console.WriteLine("3. Envanteri Kapat ❌");
    Console.Write("Seçiminiz: ");
    
    string secim = Console.ReadLine();
    Console.Clear(); // Ekranı temizler, güzel görünür

    switch (secim)
    {
        case "1":
            Console.WriteLine("--- Çantandaki Eşyalar ---");
            foreach (string item in envanter)
            {
                Console.WriteLine("- " + item); // Şık dursun diye tire ekledim
            }
            Console.WriteLine("--------------------------");
            break;

        case "2":
            // --- ARAMA MANTIĞI BURADA BAŞLIYOR ---
            
            // 1. Kullanıcıdan ne aradığını SADECE BİR KERE soruyoruz
            Console.Write("Hangi eşyayı arıyorsunuz?: ");
            string arananEsya = Console.ReadLine();
            
            bool bulunduMu = false; // Henüz bulamadık

            // 2. Çantayı geziyoruz
            foreach (string esya in envanter)
            {
                // ÖNEMLİ: Büyük/Küçük harf duyarlılığını kaldırmak için ikisini de küçülttük (İsteğe bağlı ama önerilir)
                if (esya == arananEsya) 
                {
                    bulunduMu = true; // Bulduk!
                    break; // Aramayı bitir
                }
            }

            // 3. Sonucu yazdırıyoruz
            if (bulunduMu == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"✅ Evet, [{arananEsya}] çantanda var!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"❌ Maalesef, [{arananEsya}] bulunamadı.");
                Console.ResetColor();
            }
            Console.WriteLine("--------------------------");
            break;

        case "3":
            Console.WriteLine("Çıkış Yapılıyor...");
            return; // Programı kapatır

        default:
            Console.WriteLine("Lütfen geçerli bir seçim yapınız (1-3).");
            break;
    }
}*/
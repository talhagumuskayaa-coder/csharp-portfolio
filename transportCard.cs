/*// --- DEĞİŞKENLER (Variables) ---
int kartBakiye; 
kartBakiye = 200; // Başlangıç bakiyemiz (State)
int secim = 0; // Döngüye girebilmek için 5 olmayan bir değer verdik
int miktar; // Yükleme yapılacak tutar için boş kutu

Console.WriteLine("--- İSTANBUL KART UYGULAMASI ---");

// --- SONSUZ DÖNGÜ (Loop) ---
// Kullanıcı 5 (Çıkış) tuşuna basmadığı sürece bu döngü sonsuza kadar döner.
while (secim != 5)
{
    // Menü Tasarımı (Görsellik)
    Console.WriteLine("-------------------------------");
    Console.WriteLine("Bakiyeniz: " + kartBakiye + "TL"); 
    Console.WriteLine("-------------------------------");
    
    Console.WriteLine("1. Otobüs (15 TL) ");
    Console.WriteLine("2. Metro (20 TL) ");
    Console.WriteLine("3. Marmaray (35 TL) ");
    Console.WriteLine("4. Bakiye Yükle ");
    Console.WriteLine("5. Çıkış ");
    Console.Write("Seçiminiz: ");
    
    // Kullanıcının girdiği yazıyı sayıya çevirip 'secim' değişkenini güncelliyoruz.
        secim = int.Parse(Console.ReadLine());

        // --- KARAR MEKANİZMASI (Switch-Case) ---
    switch (secim)
    {
        case 1: // Otobüs
            // Bakiye Kontrolü (State Check)
            if (kartBakiye >= 15)
            {
                kartBakiye = kartBakiye - 15; // Bakiyeden düş
            }
            else
            {
                // Hata Mesajı
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Yetersiz Bakiye!");
                Console.WriteLine("-------------------------------");
            } 
            break;
        case 2: // Metro
            if (kartBakiye >= 20)
            {
                kartBakiye = kartBakiye - 20;
            }
            else
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Yetersiz Bakiye!");
                Console.WriteLine("-------------------------------");
            }
            break;
        case 3: // Marmaray
            if (kartBakiye >= 35)
            {
                kartBakiye = kartBakiye - 35;
            }
            else
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Yetersiz Bakiye!");
                Console.WriteLine("-------------------------------");
            }
            break;
        case 4: // Bakiye Yükleme
            Console.Write("Yatırmak İstediğiniz Tutarı Giriniz: ");
            miktar = int.Parse(Console.ReadLine());
            
            // Bakiyenin üzerine ekleme yapıyoruz (Accumulation)
            kartBakiye += miktar;
            break;
        case 5: // Çıkış
            Console.WriteLine("Çıkış Yapılıyor...");
            break;
        default: // Hatalı Tuşlama (1-5 dışı)
            Console.WriteLine("Lütfen Geçerli Bir Parametre Tuşlayınız");
            break;
    }
    
}*/
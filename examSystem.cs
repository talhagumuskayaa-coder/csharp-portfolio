/*// --- PROJE: SINIF NOT ANALİZ SİSTEMİ ---

Console.WriteLine("--- SINIF NOT SİSTEMİ ---");

// 1. ADIM: Sınıf mevcudunu öğrenme
// Kullanıcıdan kaç kişi olduğunu alıyoruz ki dizinin boyutunu belirleyelim.
Console.Write("Sınıfta Kaç Öğrenci Var: ");
int mevcut = Convert.ToInt32(Console.ReadLine());

// 2. ADIM: Dizi (Raf) Oluşturma
// Girilen sayı kadar (örn: 5) boş tam sayı kutusu oluşturuyoruz.
int[] notlar = new int[mevcut];

// 3. ADIM: Veri Girişi (Doldurma)
// Dizinin içine yazı yazmak için indeks (i) lazım, o yüzden 'for' kullanıyoruz.
for (int i = 0; i < notlar.Length; i++)
{
    // Kullanıcıya "0. Öğrenci" dememek için (i+1) ile soru soruyoruz.
    Console.Write((i + 1) + ". Öğrencinin Notunu Giriniz: ");
    
    // Girilen veriyi yakalayıp dizinin o anki kutusuna (i) kaydediyoruz.
    notlar[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("-----------------------------");
Console.WriteLine("Tüm notlar sisteme kaydedildi! Analiz yapılıyor...");

// 4. ADIM: Analiz Değişkenleri (Hazırlık)
int toplam = 0;       // Ortalamayı bulmak için tüm notları burada toplayacağız (Kumbara).
int enYuksek = 0;     // Başlangıçta en düşük değeri verdik ki, gelen ilk not bunu geçebilsin.
int enDusuk = 100;    // Başlangıçta tavan puanı verdik ki, gelen notlar bundan düşük olabilsin.

// 5. ADIM: Veri Analizi (Okuma)
// Diziyi sadece okumak ve incelemek için 'foreach' en pratik döngüdür.
foreach (int gelenNot in notlar)
{
    // Toplama İşlemi: Her gelen notu kumbaraya ekle.
    toplam += gelenNot;

    // En Yüksek Notu Bulma Mantığı:
    // Eğer şu an elimizdeki not, bildiğimiz en yüksekten daha büyükse;
    // Yeni kral (enYuksek) artık bu nottur.
    if (gelenNot > enYuksek)
    {
        enYuksek = gelenNot; // Hafızayı güncelliyoruz.
    }

    // En Düşük Notu Bulma Mantığı:
    // Eğer şu anki not, bildiğimiz en düşükten daha küçükse;
    // Yeni en düşük artık bu nottur.
    if (gelenNot < enDusuk)
    {
        enDusuk = gelenNot; // Hafızayı güncelliyoruz.
    }
}

// 6. ADIM: Sonuç Hesaplama ve Yazdırma
// Toplam puanı öğrenci sayısına bölerek ortalamayı buluyoruz.
int ortalama = toplam / mevcut; 

Console.WriteLine("*----------------------*");
    
// Sonuçları Yeşil renk ile ekrana basıyoruz.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("📊 SINIF ANALİZ RAPORU");
Console.WriteLine("Sınıf Ortalaması: " + ortalama);
Console.WriteLine("En Yüksek Not: " + enYuksek);
Console.WriteLine("En Düşük Not: " + enDusuk);

// Rengi normale döndür.
Console.ResetColor();
Console.WriteLine("*----------------------*");*/
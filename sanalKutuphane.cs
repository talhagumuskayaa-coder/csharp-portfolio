using System.Data;
using System.Data.SqlClient;

// BAĞLANTI ADRESİNİ TEK BİR YERE ALDIK (Yönetmesi kolay olsun diye)
string baglantiAdresi = "Data Source=localhost;Initial Catalog=dinamikKutuphane;TrustServerCertificate=True;Encrypt=False;user=sa;password=Talha6534;";

Console.WriteLine("--- SINIF YÖNETİM SİSTEMİ ---");
Console.WriteLine();

void ogrenciEkle()
{
    // Using bloğu bağlantıyı iş bitince otomatik kapatır (connection.Close yazmana gerek kalmaz)
    using (SqlConnection connection = new SqlConnection(baglantiAdresi))
    {
        connection.Open();
        Console.Write("Öğrenci Adı: ");
        string ogrenciAdi = Console.ReadLine();

        Console.Write("Öğrenci Soyadı: ");
        string ogrenciSoyadi = Console.ReadLine();

        // ID (Numara) göndermiyoruz, çünkü SQL otomatik veriyor (Identity)
        string sorgu = "INSERT INTO ogrenciListesi (ogrenciAdi, ogrenciSoyadi) VALUES (@ad, @soyad)";
        
        using (SqlCommand command = new SqlCommand(sorgu, connection))
        {
            command.Parameters.AddWithValue("@ad", ogrenciAdi);
            command.Parameters.AddWithValue("@soyad", ogrenciSoyadi);
            command.ExecuteNonQuery();
        }
    }
    Console.WriteLine("✅ Öğrenci Başarıyla Eklendi!\n");
}

void ogrenciSil()
{
    // Önce listeyi gösterelim ki kimi sileceğini bilsin
    ogrenciListele(); 
    
    using (SqlConnection connection = new SqlConnection(baglantiAdresi))
    {
        connection.Open();
        Console.Write("\nSilinecek Öğrenci NO (ID): ");
        // TryParse: Kullanıcı harf girerse patlamasın diye kontrol
        if (int.TryParse(Console.ReadLine(), out int ogrenciNo))
        {
            string sorgu = "DELETE FROM ogrenciListesi WHERE ogrenciNumarasi = @id";
            using (SqlCommand command = new SqlCommand(sorgu, connection))
            {
                command.Parameters.AddWithValue("@id", ogrenciNo);
                int etkilenen = command.ExecuteNonQuery();
                
                if(etkilenen > 0) Console.WriteLine("✅ Silme İşlemi Başarılı!\n");
                else Console.WriteLine("❌ Bu numarada bir öğrenci bulunamadı.\n");
            }
        }
        else
        {
            Console.WriteLine("❌ Lütfen geçerli bir sayı giriniz!\n");
        }
    }
}

void ogrenciGuncelle()
{
    ogrenciListele(); // Güncellerken de ID lazım
    
    using (SqlConnection connection = new SqlConnection(baglantiAdresi))
    {
        connection.Open();
        Console.Write("\nGüncellenecek Öğrenci NO: ");
        int ogrenciNo = int.Parse(Console.ReadLine()); // Basit tuttum senin gibi

        Console.Write("Yeni İsim: ");
        string ogrenciAdi = Console.ReadLine();

        Console.Write("Yeni Soyisim: ");
        string ogrenciSoyadi = Console.ReadLine();

        string sorgu = "UPDATE ogrenciListesi SET ogrenciAdi = @ad, ogrenciSoyadi = @soyad WHERE ogrenciNumarasi = @id";
        
        using (SqlCommand command = new SqlCommand(sorgu, connection))
        {
            command.Parameters.AddWithValue("@ad", ogrenciAdi);
            command.Parameters.AddWithValue("@soyad", ogrenciSoyadi);
            command.Parameters.AddWithValue("@id", ogrenciNo);
            command.ExecuteNonQuery();
        }
    }
    Console.WriteLine("✅ Güncelleme Başarılı!\n");
}

void ogrenciListele()
{
    Console.WriteLine("\n--- 📋 ÖĞRENCİ LİSTESİ ---");
    using (SqlConnection connection = new SqlConnection(baglantiAdresi))
    {
        connection.Open();
        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ogrenciListesi", connection);
        DataTable dataTable = new DataTable();
        adapter.Fill(dataTable);

        foreach (DataRow row in dataTable.Rows)
        {
            // BURASI ÖNEMLİ: ID numarasını da yazdırıyoruz
            Console.WriteLine($"[{row["ogrenciNumarasi"]}] {row["ogrenciAdi"]} {row["ogrenciSoyadi"]}");
        }
    }
    Console.WriteLine("--------------------------\n");
}

// MAIN LOOP
while (true)
{
    Console.WriteLine("1- 📜 Listele");
    Console.WriteLine("2- ➕ Ekle");
    Console.WriteLine("3- 🗑️ Sil");
    Console.WriteLine("4- ✏️ Güncelle");
    Console.Write("Seçim: ");
    
    string giris = Console.ReadLine();

    switch (giris)
    {
        case "1": ogrenciListele(); break;
        case "2": ogrenciEkle(); break;
        case "3": ogrenciSil(); break;
        case "4": ogrenciGuncelle(); break;
        default: Console.WriteLine("Geçersiz seçim!"); break;
    }
}
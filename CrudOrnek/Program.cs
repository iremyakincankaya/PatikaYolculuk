using Npgsql;

string cs = "Host=localhost;Port=5433;Username=postgres;Password=postgre;Database=hafta7db";

//OgrenciEkle("Koray Avcı","e",1999);
//OgrenciSil(3);
//AdGuncelle(5, "Muhtar Hamit");
Listele();



void OgrenciEkle(string ad,string cinsiyet,int dogumYili)
{
    using (var con = new NpgsqlConnection(cs))
    {
        con.Open();
        var cmd = new NpgsqlCommand($"INSERT INTO ogrenciler(ad, cinsiyet, dogum_yili) VALUES(@p1,@p2,@p3)", con);
        cmd.Parameters.AddWithValue("@p1",ad);
        cmd.Parameters.AddWithValue("@p2", cinsiyet);
        cmd.Parameters.AddWithValue("@p3", dogumYili);
        int etkilenenSatirSayisi=cmd.ExecuteNonQuery();

    }
}


void OgrenciSil(int id)
{
    using (var con = new NpgsqlConnection(cs))
    {
        con.Open();
        var cmd = new NpgsqlCommand($"Delete From ogrenciler Where id=@id", con);
        cmd.Parameters.AddWithValue("@id", id);
 
        int etkilenenSatirSayisi = cmd.ExecuteNonQuery();

    }
}

void AdGuncelle(int id,string ad)
{
    using (var con = new NpgsqlConnection(cs))
    {
        con.Open();
        var cmd = new NpgsqlCommand($"UPDATE ogrenciler Set ad=@ad Where id=@id", con);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@ad", ad);
        int etkilenenSatirSayisi = cmd.ExecuteNonQuery();

    }
}


void Listele()
{

    //1 Bağlantı kur
    NpgsqlConnection con = new NpgsqlConnection(cs);

    con.Open();
    Console.WriteLine("Bağlantı Durumu:" + con.State);
    Console.WriteLine();

    //KOmutu oluşturur
    NpgsqlCommand cmd = new NpgsqlCommand("Select * From ogrenciler order by 1", con);

    //komutu çalıştır ve veri okuyucu oluştur
    NpgsqlDataReader dr = cmd.ExecuteReader();

    //satır satır oku ve yazdır.
    Console.WriteLine("{0,2} {1,-20} {2,-2} {3}", "#", "AD", "C", "D.Yil");
    Console.WriteLine();

    while (dr.Read())
    {
        Console.WriteLine("{0,2} {1,-20} {2,-2} {3}",
        dr["id"],
        dr["ad"],
        dr["cinsiyet"],
        dr["dogum_yili"]

        );
    }


    //okuyucu ve bağlntıyı kapat

    dr.Close();
    con.Close();
    Console.WriteLine();
    Console.WriteLine("Bağlantı Durumu:" + con.State);


}
Console.ReadKey();
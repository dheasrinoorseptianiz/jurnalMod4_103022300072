internal class Program
{
    private static void Main(string[] args)
    {
        // menampilkan daftar kelurahan beserta kode posnya dengan memanggil  KodeProduk.GetKodeElektronik untuk setiap kelurahan yang terdaftar dalam enum Kelurahan.
        Console.WriteLine("Produk : " + KodeProduk.GetKodeElektronik(KodeProduk.elektronik.Laptop));
    }
}
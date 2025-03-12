using System;

internal class KodeProduk
{
    public enum elektronik // enum elekttronik di gunakan untuk menyimpan daftar elektronik
    {
        Laptop,
        Smarthphone,
        Tablet,
        Headset,
        Keyboard,
        Mouse,
        Printer,
        Monitor,
        Smartwatch,
        Kamera
    }

    // Setiap indeks dari enum elektronik digunakan untuk mengakses array KodeElektronikList, yang berisi kode pos untuk masing-masing elektronik sesuai urutan.
    private static String[] KodeElektronikList = { "E100", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109" };

    // Untuk mendapatkan kode pos berdasarkan elektronik, digunakan method GetKodeElektronik(elektronik Elektronik), yang mengambil nilai kode produk dari array
    // berdasarkan indeks enum.

    public static String GetKodeElektronik(elektronik Elektronik)
    {
        return KodeElektronikList((int)Elektronik];
    }
}
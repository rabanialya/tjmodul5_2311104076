using System;

class Penjumlahan
{
    public static T JumlahTigaAngka<T>(T a, T b, T c)
    {
        dynamic angka1 = a;
        dynamic angka2 = b;
        dynamic angka3 = c;

        return angka1 + angka2 + angka3;
    }
}

class Program
{
    static void Main()
    {
        int angka1 = 12;
        int angka2 = 34;
        int angka3 = 56;

        int hasil = Penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);

        Console.WriteLine($"Hasil penjumlahan: {hasil}");
    }
}
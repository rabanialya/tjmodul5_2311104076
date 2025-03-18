using System;
using System.Collections.Generic;
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


class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    // Konstruktor untuk inisialisasi list kosong
    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    // Method untuk menambahkan data baru dan waktu penyimpanan
    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.UtcNow);
    }

    // Method untuk mencetak semua data dan waktu penyimpanannya
    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
        }
    }
}


class Program
{
    static void Main()
    {
        int angka1 = 11;
        int angka2 = 40;
        int angka3 = 76;

        int hasil = Penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);

        Console.WriteLine($"Hasil penjumlahan: {hasil}");

        SimpleDataBase<int> database = new SimpleDataBase<int>();

        database.AddNewData(angka1);
        database.AddNewData(angka2);
        database.AddNewData(angka3);

        database.PrintAllData();
    }
}
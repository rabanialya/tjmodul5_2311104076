using System;
using System.Collections.Generic;

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
        // Ganti dengan dua digit NIM kamu
        int angka1 = 11;
        int angka2 = 40;
        int angka3 = 76;

        // Tentukan tipe data berdasarkan digit terakhir NIM
        SimpleDataBase<int> database = new SimpleDataBase<int>();

        // Menambahkan data ke dalam database
        database.AddNewData(angka1);
        database.AddNewData(angka2);
        database.AddNewData(angka3);

        // Menampilkan semua data yang tersimpan
        database.PrintAllData();
    }
}
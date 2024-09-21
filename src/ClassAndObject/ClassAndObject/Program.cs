using ClassAndObject.Perpustakaan;
using ClassAndObject.TokoLaptop;
using ClassAndObject.Kendaraan;
using ClassAndObject.TokoSepeda;
using ClassAndObject.OperasiMatematika;
using System;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Buku
            Buku buku1 = new Buku("Nama Buku", "Penulis", 2021);
            buku1.TampilkanInfo();

            // Kendaraan
            Mobil mobil1 = new Mobil("Toyota", "Corolla", 2020);
            mobil1.TampilkanSpesifikasi();

            // Laptop
            Laptop laptop1 = new Laptop("Dell", "Intel Core i7", 16, 512);
            
            laptop1.TampilkanSpesifikasi();

            // Sepeda
            Sepeda sepeda1 = new Sepeda("Polygon", "Mountain Bike", 14.5);
            
            sepeda1.TampilkanInformasi();

            // Kalkulator
            Kalkulator kalkulator1 = new Kalkulator();
            double hasilTambah = kalkulator1.Tambah(10, 5);
            double hasilKurang = kalkulator1.Kurang(10, 5);
            double hasilKali = kalkulator1.Kali(10, 5);
            double hasilBagi = kalkulator1.Bagi(10, 5);

            Console.WriteLine($"Hasil Tambah: {hasilTambah}");
            Console.WriteLine($"Hasil Kurang: {hasilKurang}");
            Console.WriteLine($"Hasil Kali: {hasilKali}");
            Console.WriteLine($"Hasil Bagi: {hasilBagi}");
        }
    }
}

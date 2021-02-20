
using System;

namespace oopfundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("Masukkan Merk Kendaraanmu?");
            string merk = Console.ReadLine();
            Console.WriteLine("Masukkan Model Kendaraan?");
            string model = Console.ReadLine();
            Console.WriteLine("Masukkan Horse Power Kendaraan Anda");
            double hp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Apakah kendaraan Anda menggunakan Turbo Charger? (0/1)");

            double kecepatan = 0;
            kecepatan = (hp / 4) * 1.5 + 100;

            Console.WriteLine("Estimasi Kecepatan Kendaraan?");

            Console.WriteLine(String.Format("Estimasi Kecepatan Optimal adalah {0} KM/H", kecepatan));






        }
    }
}
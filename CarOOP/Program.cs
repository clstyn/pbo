
using System;

namespace CarOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan Merk Kendaraanmu?");
            string brand = Console.ReadLine();
            Console.WriteLine("Masukkan Model Kendaraan?");
            string model = Console.ReadLine();
            Console.WriteLine("Masukkan Horse Power Kendaraan Anda");
            double hp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Apakah kendaraan bermode Turbo? (True/False)");
            bool isTurbo = Convert.ToBoolean(Console.ReadLine());
            //instancing
            Vehicle car = new Vehicle(brand, model, hp, isTurbo);
            //call procedure
            car.ShowVehicleInfo();
            //call function
            double velocity = car.CalculateOptimumV(hp);
            Console.WriteLine("Kecepatan Optimum Mobil adalah {0}", velocity);
        }
    }
}
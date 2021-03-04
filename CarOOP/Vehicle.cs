using System;

namespace CarOOP
{
    class Vehicle
    {
        string brand;
        string model;
        double horsepower;
        double optimumVelocity;
        bool isTurbo;

        public Vehicle(string brand, string model, double horsepower, bool isTurbo)
        {
            this.brand = brand;
            this.model = model;
            this.horsepower = horsepower;
            this.isTurbo = isTurbo;
        }

        public void ShowVehicleInfo()
        {
            Console.WriteLine("{0} - {1} that has {2} horsepower", brand, model, horsepower);
        }

        public double CalculateOptimumV(double horsepower)
        {
            double velocity = 0;
            //non turbo
            velocity = (horsepower / 4) * 1.5 + 100;
            //turbo
            if (isTurbo == true)
            {
                velocity = velocity + 0.1 * velocity;
            }
            return velocity;
        }
    }
}
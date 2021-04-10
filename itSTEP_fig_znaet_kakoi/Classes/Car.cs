using System;
namespace itSTEP_fig_znaet_kakoi.Classes
{
    public abstract class Car
    {
        public int Horsepower { get; set; }
        public int Weight { get; set; }
        public int Speed { get; set; }
        public int DistanceCounter { get; set; } = 1;
        public abstract void Drive();

        public Car()
        {
        }
        public Car(int horsep, int weight, int speed)
        {
            this.Horsepower = horsep;
            this.Weight = weight;
            this.Speed = speed;
        }
    }




}

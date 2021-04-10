using System;
namespace itSTEP_fig_znaet_kakoi.Classes
{
    public delegate void CarHandler(object sender, CarEventArgs e);

    public class Sportcar : Car
    {
        public event CarHandler SportCarEvent;

        public Sportcar()
        {

        }
        public Sportcar(int a, int b, int c):base(a,b,c)
        {

        }
        public override void Drive()
        {
            Console.WriteLine("{0} is driving as fast as it can! ", this.GetType().Name);
        }
    }

    public class RegCar : Car
    {
        public event CarHandler SportCarEvent;

        public RegCar()
        {

        }
        public RegCar(int a, int b, int c) : base(a, b, c)
        {

        }
        public override void Drive()
        {
            Console.WriteLine("{0} is driving as fast as it can! ", this.GetType().Name);
        }
    }
    public class Truck : Car
    {
        public event CarHandler SportCarEvent;

        public Truck()
        {

        }
        public Truck(int a, int b, int c) : base(a, b, c)
        {

        }
        public override void Drive()
        {
            Console.WriteLine("{0} is driving as fast as it can! ", this.GetType().Name);
        }
    }
    public class Bus : Car
    {
        public event CarHandler SportCarEvent;

        public Bus()
        {

        }
        public Bus(int a, int b, int c) : base(a, b, c)
        {

        }
        public override void Drive()
        {
            Console.WriteLine("{0} is driving as fast as it can! ", this.GetType().Name);
        }
    }

}

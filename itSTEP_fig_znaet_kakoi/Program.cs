using System;
using System.Collections.Generic;
using itSTEP_fig_znaet_kakoi.Classes;
namespace itSTEP_fig_znaet_kakoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<Car> cars = new List<Car>
            {
                new Truck(350,2000,90),
                new Bus(350,2000,60),
                new RegCar(350,2000,80),
                new Sportcar(350,2000,120),
            };

            Game newGame = new Game(cars, 250);
            newGame.SportCarEvent += DisplayMessage;
            newGame.StartGame();
        }

        private static void DisplayMessage(object sender, CarEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }

    
}

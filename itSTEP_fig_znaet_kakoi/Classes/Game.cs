using System;
using System.Collections.Generic;
using System.Threading;

namespace itSTEP_fig_znaet_kakoi.Classes
{
    public class Game
    {
        delegate void CarCaller();
        public event CarHandler SportCarEvent;
        CarCaller Driver;
        List<Car> Cars;
        public double Distance { get; set; }
        public Game()
        {

        }
        public Game(List<Car> cars, int distance)
        {
            Cars = cars;
            this.Distance = distance;
            for(int i = 0; i < cars.Count; i++)
            {
                Driver += cars[i].Drive;
            }
        }
        public void StartGame()
        {
            Console.Clear();
            Console.WriteLine("Game has started!");
            foreach (Car car in Cars)
            {
                Console.WriteLine(car.GetType().Name + " is ready!");
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Start!");
            bool done = false;
            while (true)
            {
                if (done)
                    break;
                Console.WriteLine("===================================================");
                for (int ctr = Driver.GetInvocationList().Length - 1, i = Cars.Count-1; i >= 0; ctr--,i--)
                {
                    var temp = Driver.GetInvocationList();
                    temp[i].DynamicInvoke();
                    if ((Cars[i].DistanceCounter*Cars[i].Speed)/Distance>=1)
                    {
                        SportCarEvent.Invoke(Cars[i], new CarEventArgs(string.Format(Cars[i].GetType().Name + " has reached the finish and is a winner! Congratz!"), Cars[i], DateTime.Now,CarEvents.Finish));
                        done = true;
                        break;
                    }
                    Console.WriteLine(Cars[i].GetType().Name + " has reached " +(double)((Cars[i].DistanceCounter++) * Cars[i].Speed)/Distance + " of distance");
                    Thread.Sleep(1500);
                }
                Console.WriteLine("===================================================");

            }
        }
    }
}


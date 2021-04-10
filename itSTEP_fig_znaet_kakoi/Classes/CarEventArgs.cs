using System;
namespace itSTEP_fig_znaet_kakoi.Classes
{
    public enum CarEvents
    {
        Finish,
        CarAccident,
        NoGas
    }

    public class CarEventArgs
    {
        public CarEvents EventType { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public object Causer { get; set; }

        public CarEventArgs()
        {
        }

        public CarEventArgs(string msg, object Causer, DateTime date, CarEvents ev) 
        {
            this.Message = msg;
            this.Causer = Causer;
            this.Date = date;
            this.EventType = ev;
        }
    }
}

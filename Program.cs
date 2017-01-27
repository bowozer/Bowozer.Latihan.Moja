using System;
using System.Threading;

namespace Bowozer.Latihan.Moja
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var mojacko = new Mojacko()
            {
                Shape = "Bulat",
                Eye = "Super Besar",
                Colour = "Oranye",
            };

            mojacko.Move();
            Thread.Sleep(1500);
            mojacko.Move();
            Thread.Sleep(200);
            mojacko.Move();
            Thread.Sleep(2500);
            mojacko.Startled();
        }
    }
}

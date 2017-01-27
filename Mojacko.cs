using System;

namespace Bowozer.Latihan.Moja
{
    public class Mojacko
    {
        public string Shape { get; set; }

        public string Eye { get; set; }

        public string Colour { get; set; }

        public void Move()
        {
            Console.WriteLine("Mojacko moves like jagger!");
        }

        public void Startled()
        {
            Console.WriteLine("Mojacko kaget!");
            Console.Beep();
        }
    }
}

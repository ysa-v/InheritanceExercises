using System;
namespace Technology
{
    public class Laptop : Computer
    {
        public Laptop()
        {
            public double ScreenSize { get; set; }

            public Laptop(double ram, double storage, string chip, double screenSize): base(ram, storage, chip)
            {
                ScreenSize = screenSize;
            }
        }
    }
}


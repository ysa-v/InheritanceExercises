using System;
namespace Technology
{
    public class SmartPhone
    {
        public SmartPhone()
        {
            public string OperatingSystem { get; set; }

            public Laptop(double ram, double storage, string chip, string operatingSystem) : base(ram, storage, chip)
            {
                OperatingSystem = operatingSystem;
            }
        }
    }
}


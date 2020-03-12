using System;

namespace Prep3
{
    public class Laptop : Computer
    {
        private string _operatingSystem;
        public int IsLidClosed { get; set; }
        public override string OperatingSystem
        {
            get
            {
                return _operatingSystem;
            }
            set
            {
                if (value == "Windows" || value == "MacOS" || value == "Linux")
                {
                    _operatingSystem = value;
                }
                else
                {
                    _operatingSystem = "Unknown";
                }
            }
        }

        public override void Disconnect()
        {
            IsOn = true;
            IsDisconnected = true;
            Console.WriteLine("The system is running on battery.");
        }
    }
}

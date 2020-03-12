using System;

namespace Prep4
{
    public class Desktop : Computer
    {
        private string _operatingSystem;

        public int Slots { get; set; }

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
            IsOn = false;
            IsDisconnected = true;
            Console.WriteLine("The system was hard powered off.");
        }
    }
}

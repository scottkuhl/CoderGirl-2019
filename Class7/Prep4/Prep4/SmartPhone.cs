using System;

namespace Prep4
{
    public class SmartPhone : Computer
    {
        private string _operatingSystem;

        public override string OperatingSystem
        {
            get
            {
                return _operatingSystem;
            }
            set
            {
                if (value == "Android" || value == "iOS")
                {
                    _operatingSystem = value;
                }
                else
                {
                    _operatingSystem = "Unknown";
                }
            }
        }

        public void Call()
        {
            Console.WriteLine("Ring Ring!");
        }

        public override void Disconnect()
        {
            IsOn = true;
            IsDisconnected = true;
            Console.WriteLine("The system is running on battery.");
        }
    }
}

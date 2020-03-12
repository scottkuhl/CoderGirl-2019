using System;

namespace Prep4
{
    public abstract class Computer : AbstractEntity
    {
        public bool IsOn { get; protected set; }

        public bool IsDisconnected { get; protected set; }

        public abstract string OperatingSystem { get; set; }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("The system is now on.");
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("The system is now off.");
        }

        public abstract void Disconnect();
    }
}

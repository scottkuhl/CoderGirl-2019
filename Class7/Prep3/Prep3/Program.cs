using System;

// TODO: Discuss similarities and code reuse between Desktop, Laptop and SmartPhone.
// TODO: Demo new class heirachy and overlaping problems.

namespace Prep3
{
    class Program
    {
        static void Main(string[] args)
        {
            var desktop = new Desktop
            {
                Slots = 2,
                OperatingSystem = "Windows"
            };
            desktop.Disconnect();

            Console.WriteLine($"Desktop OS: {desktop.OperatingSystem}");
            Console.WriteLine($"Desktop connection: {!desktop.IsDisconnected}");
            Console.WriteLine($"Desktop power: {desktop.IsOn}");

            var laptop = new Laptop
            {
                OperatingSystem = "Windows"
            };
            laptop.Disconnect();

            Console.WriteLine($"Laptop OS: {laptop.OperatingSystem}");
            Console.WriteLine($"Laptop connection: {!laptop.IsDisconnected}");
            Console.WriteLine($"Laptop power: {laptop.IsOn}");

            var phone = new SmartPhone
            {
                OperatingSystem = "Blackburry"
            };
            phone.Disconnect();

            Console.WriteLine($"Phone OS: {phone.OperatingSystem}");
            Console.WriteLine($"Phone connection: {!phone.IsDisconnected}");
            Console.WriteLine($"Phone power: {phone.IsOn}");
        }
    }
}

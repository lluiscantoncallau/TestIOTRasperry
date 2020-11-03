using System;
using System.Device.Gpio;
using System.Threading;

namespace TestIOTRasperry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start program");
            var pin = 4;
            var controller = new GpioController();
            controller.OpenPin(pin,PinMode.Output );

            while (true)
            {
                controller.Write(pin, PinValue.High);
                Console.Write("PIN: " + pin.ToString() + " High");
                Thread.Sleep(1000);
                controller.Write(pin, PinValue.Low);
                Console.Write("PIN: " + pin.ToString() + " Low");
                Thread.Sleep(1000);
            }
           
        }
    }
}

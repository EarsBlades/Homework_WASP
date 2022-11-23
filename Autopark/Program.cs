using System;

namespace Autopark
{
    class Program
    {
        static void Main(string[] args)
        {
            Car cr = new Car("Honda", 650, 1999);
            PassengerCar ps = new PassengerCar("Volvo", 320, 1995, 4);
            Truck tr = new Truck("Peterbild", 450, 10, 100, "Vin Disel");
            
            Autopark av = new Autopark("Рынок", new List<Car>() {cr, ps, tr});
            Console.WriteLine(av.ToString());
            
            Console.ReadKey();
        }
    }
}
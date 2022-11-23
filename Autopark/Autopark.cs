using System;
namespace Autopark
{
    public class Autopark
    {
        private string name_autopark;
        private List<Car> car_instances = new List<Car>();
        
        public Autopark(string name_autopark, List<Car> car_instances)
        {
            this.name_autopark = name_autopark;
            this.car_instances = car_instances;
        }
        
        public override string ToString()
        {
            string result = "";
            foreach (Car car in car_instances)
                result += car + "\n";
            return ("Название автопарка: " + name_autopark + 
                    "\n" + result.ToString());
        }
    }
}


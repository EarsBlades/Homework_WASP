using System;

namespace Autopark
{
    public class Truck : Car
    {
        private int max_capacity;
        private string fi;
        private Dictionary<string, int> actual_cargo = new Dictionary<string, int>();

        public Truck(
            string mark,
            int power,
            int year_of_production,
            int max_capacity,
            string fi
        ) : base(mark, power, year_of_production)
        {
            this.max_capacity = max_capacity;
            this.fi = fi;
        }

        public void EditDriver(string driver)
        {
            fi = driver;
        }

        public void AddDelCargo(string action, string name, int weight)
        {
            if (action == "add")
                actual_cargo.Add(name, weight);
            if (action == "del")
                actual_cargo.Remove(name, out weight);
        }

        public string Print_Dict_Cargo()
        {
            string result = "";
            foreach (KeyValuePair<string, int> tmp in actual_cargo)
            {
                result += string.Format("Груз: {0} Вес: {1}", tmp.Key, tmp.Value);
            }
            return result;
        }
        
        public override string ToString()
        {
            return ("Марка: " + mark +
                    "\nМощность: " + power.ToString() +
                    "\nГод производства: " + year_of_production.ToString() +
                    "\nМаксимальная грузоподъёмность: " + max_capacity.ToString() +
                    "\nФИ водителя: " + fi + "\n");
            
        }
    }
}


using System;

namespace Autopark
{
    public class PassengerCar : Car
    {
        private int count_passengers;
        private Dictionary<string, int> repair_book = new Dictionary<string, int>();

        public PassengerCar(
            string mark,
            int power,
            int year_of_production,
            int count_passengers) : base(mark, power, year_of_production)
        {
            this.count_passengers = count_passengers;
        }

        public void AddSpare(string name, int age)
        {
            repair_book.Add(name, age);
        }

        public string Parsing_Dict(string name)
        {
            int res = 0;
            if (repair_book.TryGetValue(name, out res))
                return res.ToString();
            else
                return "Такой запчасти нет";
        }

        public string Print_Dict_Repair()
        {
            string result = "";
            foreach (KeyValuePair<string, int> tmp in repair_book)
            {
                result += string.Format("Запчасть: {0} Год: {1}", tmp.Key, tmp.Value);
            }
            return result;
        }

        public override string ToString()
        {
            return ("Марка: " + mark +
                    "\nМощность: " + power.ToString() +
                    "\nГод производства: " + year_of_production.ToString() +
                    "\nКоличество пассажиров: " + count_passengers.ToString() + "\n");
        }
    }
}
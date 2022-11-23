using System;

namespace Autopark
{
    public class Car
    {
        protected string mark;
        protected int power;
        protected int year_of_production;

        public Car(string mark, int power, int year_of_production)
        {
            this.mark = mark;
            this.power = power;
            this.year_of_production = year_of_production;
        }

        public override string ToString()
        {
            return "Марка: " + this.mark + 
                   "\nМощность: " + this.power.ToString() + 
                   "\nГод производства: " + this.year_of_production.ToString() + "\n";
        }   
    }
}
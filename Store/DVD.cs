using System;

namespace Store
{
    public class DVD : Disk
    {
        private string producer;
        private string filmCompany;
        private int minutesCount;

        public DVD(string producer, string filmCompany, int minutesCount, string Name, string Genre) : base(Name, Genre)
        {
            this.producer = producer;
            this.filmCompany = filmCompany;
            this.minutesCount = minutesCount;
            this.Name = Name;
            this.Genre = Genre;
        }

        public override int DiskSize
        {
            get => (minutesCount / 64) * 2;
            set { minutesCount = value; }
        }

        public override void Burn(params string[] values)
        {
            producer = values[0];
            filmCompany = values[1];
            burnCount++;
        }

        public override string ToString()
        {
            return ("Название: " + Name +
                    "\nЖанр: " + Genre +
                    "\nРежиссёр: " + producer +
                    "\nКинокомпания: " + filmCompany +
                    "\nКоличество минут: " + minutesCount +
                    "\nКоличество прожигов: " + burnCount);
        }
    }
}
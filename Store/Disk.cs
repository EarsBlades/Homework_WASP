using System;

namespace Store
{
    public class Disk : IStoreItem
    {
        protected string Name;
        protected string Genre;
        protected int burnCount;

        public Disk(string Name, string Genre)
        {
            this.Name = Name;
            this.Genre = Genre;
        }

        public virtual int DiskSize
        {
            get => burnCount;
            set { burnCount = value; }
        }

        public virtual void Burn(params string[] values) {}

        public double Price { get; set; }
        double IStoreItem.DiscountPrice(int percent) => Price;
    }
}
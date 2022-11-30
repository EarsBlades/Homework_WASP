using System;

namespace Store
{
    public interface IStoreItem
    {
        public double Price { get; set; }

        public double DiscountPrice(int percent)
        {
            return Price * (percent / 100);
        }

    }
}
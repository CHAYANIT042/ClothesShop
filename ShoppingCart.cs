using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop
{
    class ShoppingCart : Address
    {
        private TShirt[] orderTShirt;

        public ShoppingCart(string street, string city, string zipCode) : base(street, city, zipCode)
        {
        }

        public void AddOrder(string size, string color, float price)
        {
            if(orderTShirt == null)
            {
                orderTShirt = new TShirt[1];
                orderTShirt[0] = new TShirt(size, color, price);
            }
            else
            {
                TShirt newOrder = new TShirt(size, color, price);
                TShirt[] temp = new TShirt[orderTShirt.Length + 1];
                orderTShirt.CopyTo(temp, 0);
                temp[orderTShirt.Length] = newOrder;
                orderTShirt = temp;
            }
        }

        public TShirt[] GetOrders()
        {
            return orderTShirt;
        }

        public float GetTotal()
        {
            float total = 0;
            foreach(TShirt a in orderTShirt)
            {
                total += a.GetPrice();
            }

            return total;
        }

        public void PrintAllOrders()
        {
            foreach (TShirt a in orderTShirt)
            {
                Console.WriteLine("- size: {0} / color: {1} / price: {2}", a.GetSize(), a.GetColor(), a.GetPrice().ToString());
            }
        }
    }
}

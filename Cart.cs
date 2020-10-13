using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping
{
    class Cart
    {
        public Cart()
        {
            items = new List<Item>();
        }


        private List<Item> items;


        public string AddToCart(string itemName)
        {
            double itemprice = Convert.ToDouble(Console.ReadLine());
            Item item = new Item(items.Count + 1, itemName , itemprice );
            this.items.Add(item);
            return item.Name;
        }

        public IEnumerable<string> GetCartIteminfo()
        {
            foreach (var item in this.items)
            {
                yield return item.Name;
                yield return item.Price.ToString();

            }
        }

    }
}

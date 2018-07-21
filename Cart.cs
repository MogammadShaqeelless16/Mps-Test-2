using System;
using System.Collections.Generic;
using System.Text;

namespace Treehouse.PracticeSession
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
            Item item = new Item(items.Count + 1, itemName);
            this.items.Add(item);
            return item.Name;
        }

        public IEnumerable<string> GetCartItemNames()
        {
            foreach (var item in this.items)
            {
                yield return item.Name;
            }
        }

        public void Clear()
        {
            this.items.Clear();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Treehouse.PracticeSession
{
    class Program
    {
        public static void Main()
        {

            Cart cart = new Cart();

            bool stillAddingItems = true;

            while(stillAddingItems)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do? ");
                Console.WriteLine("Type 'add' to add an item.");
                Console.WriteLine("Type 'Checkout' to show your list.");
                string response = Console.ReadLine();
                Console.Clear();
                switch (response)
                {
                    case "add":
                        {
                            Console.Write("What item would you like to add? ");
                            string whatTheUserTyped = Console.ReadLine();
                            Console.Write("What is the price of the item ");
                            double price = Convert.ToInt32(Console.ReadLine());
                            cart.AddToCart(whatTheUserTyped);
                            break;
                        }
            
                    case "Checkout":
                        {
                            double total = price +  * 1.15 * price<list>;

                            foreach (string itemName in cart.GetCartIteminfo())
                            {
                                Console.WriteLine(itemName);
    
                            }
                            Console.WriteLine("the total is " total )
                            
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            break;
                        }

                }
            }

        }
    }
}

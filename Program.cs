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
                Console.WriteLine("Type 'remove' to add an item.");
                Console.WriteLine("Type 'show' to show your list.");
                Console.WriteLine("Type 'clear' to delete all items from list.");
                Console.WriteLine("Type 'quit' to quit.");
                string response = Console.ReadLine();
                Console.Clear();
                switch (response)
                {
                    case "add":
                        {
                            Console.Write("What item would you like to add? ");
                            string whatTheUserTyped = Console.ReadLine();
                            cart.AddToCart(whatTheUserTyped);
                            break;
                        }
                    case "quit":
                        {
                            stillAddingItems = false;
                            break;
                        }
                    case "show":
                        {
                            foreach (string itemName in cart.GetCartItemNames())
                            {
                                Console.WriteLine(itemName);
                            }
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            break;
                        }
                    case "clear":
                        {
                            cart.Clear();
                            break;
                        }
                }
            }

            
        }
    }
}

using System;
using System.Collections.Generic;

namespace Treehouse.PracticeSession
{
    class Program
    {
        public static void Main()
        {

  ShoppingCart sc = new ShoppingCart();

            var item1 = new Collections.Item();
            item1.Key = 1;
            item1.ItemName = "Huawei V8";
            sc.Add(item1);

            var item2 = new Collections.Item();
            item2.Key = 2;
            item2.ItemName = "Huawei V9";
            sc.Add(item2);

            var item3 = new Collections.Item();
            item3.Key = 3;
            item3.ItemName = "Huawei V10";
            sc.Add(item3);

            Console.WriteLine("使用索引器，输出对象：");
            Console.WriteLine(sc[3].ToString());

            Console.WriteLine("集合中对象数量：");
            Console.WriteLine(sc.Count);

            Console.WriteLine("列出所有对象：");
            sc.Items.ForEach(delegate (Collections.Item item)
            {
                Console.WriteLine(item.ToString());
            });

            
        }
    }
}

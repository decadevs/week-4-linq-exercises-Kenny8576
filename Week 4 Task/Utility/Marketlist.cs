using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Task.Utility
{
    public class Marketlist
    {
        public static List<Item> GetMktList()
        {
            return new List<Item>
            {
                  new Item { ItemId = 1, ItemDes = "Bag"},
                  new Item { ItemId = 2, ItemDes = "Pen"},
                  new Item { ItemId = 3, ItemDes = "Book"},
                  new Item { ItemId = 4, ItemDes = "Shoe"},
                  new Item { ItemId = 5, ItemDes = "Pen"}
            };
        }
    }
}

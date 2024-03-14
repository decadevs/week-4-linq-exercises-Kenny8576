using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Task.Utility
{
    public class Market
    {
        public static List<Sales> MarketSales()
        {
            return new List<Sales>
            {
                new Sales{ InvNo=1, itemId = 3, Qty = 10},
                  new Sales{ InvNo=2, itemId = 2, Qty = 20},
                  new Sales{ InvNo=3, itemId = 3, Qty = 500},
                 new Sales{ InvNo=4, itemId = 4, Qty = 20},
                 new Sales{ InvNo=5, itemId = 3, Qty = 100},
                 new Sales{ InvNo=6, itemId = 1, Qty = 50},
            };
        }
       
        
     
} 
    }




 

//        List<Sales> salesList = new List<Sales>
//{
//    
//};

 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Task.Utility
{
    public class State
    {
       public int Id { get; set; }
        public string stateName { get; set; }
        public int stateID { get; set; }
        public string stateCapital { get; set; }
    }

    public class GRP_A
    {
        public int Id { get; set; }
        public string stateName { get; set; }
        public int stateID { get; set; }
        public string stateCapital { get; set; }
    }

    public class GRP_B
    {
        public int Id { get; set; }
        public string groupName { get; set; }
        public int stateID { get; set; }
        public string stateCapital { get; set; }
    }

    public class GRP_C
    {
        public int Id { get; set; }
        public string stateName { get; set; }
        public int stateID { get; set; }
        public string stateCapital { get; set; }
    }


    public class Item
    {
        public int ItemId { get; set; }
        public string ItemDes { get; set; }
    }

    public class Sales
    {
        public int InvNo { get; set;}
        public int itemId { get; set;}
        public int Qty { get; set;}
        public int SalesPrice { get; set;}
    }
}

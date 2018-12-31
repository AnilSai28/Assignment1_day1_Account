using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_oop
{
    class Class1
    {
        public int orderid;
        public string customername;
        public string itemname;
        public int itemquantity;
        public int itemprice;
        public int getordervalue()
        {
        return itemquantity* itemprice;
    
    }
}
}
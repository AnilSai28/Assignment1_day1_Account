using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter order id : ");
            int oredrid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter customer name : ");
            string customername = Console.ReadLine();

            Console.WriteLine("enter item name : ");
            string itemname = Console.ReadLine();

            Console.WriteLine("enter item quantity : ");
            int itemquantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter item price : ");
            int itemprice = Convert.ToInt32(Console.ReadLine());

            oop obj = new oop();
            obj.itemquantity = itemquantity;
            obj.itemprice = itemprice;
            int result = obj.getordervalue();
            Console.WriteLine("order value :" + result);

            Console.ReadLine();






        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChildFormUpdates
{
    public class Order
    {
        public string OrderName  { get; set; }
        public List<OrderLineItem> LineItems { get; set; }
        public int NumLineItems => LineItems.Count;

        public Order()
        {
            LineItems = new List<OrderLineItem>();
        }

        public void AddLineItem()
        {
            Console.WriteLine($"Adding line item ");
            LineItems.Add(new OrderLineItem());
            Console.WriteLine($"Now i have {LineItems.Count}");
        }
    }

    public class OrderLineItem
    {
        public int Quantity { get; set; }
        public string ItemName { get; set; }

        public OrderLineItem()
        {
            Quantity = DateTime.Now.Second;
            ItemName = DateTime.Now.ToString();
        }
    }
}

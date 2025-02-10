using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsBookShop
{
    internal class Order
    {
        public int Id { get; set; }
        public int Code_Buyer { get; set; }
        public int Code_Employee { get; set; }
        public DateTime DateOrder { get; set; }
        public DateTime DateDelivery { get; set; }
        public string CostOrder { get; set; }
        public bool IsSold { get; set; }

        public Employee Employee { get; set; }
        public Buyer Buyer { get; set; }

        public List<CompoundOrder> CompoundOrders { get; set; }
    }
}

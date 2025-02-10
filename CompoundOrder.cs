using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsBookShop
{
    internal class CompoundOrder
    {
        public int Id { get; set; }
        
        public Order OrderId { get; set; }
        public Book BookId { get; set; }
    }
}

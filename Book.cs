using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ModelsBookShop
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Cost { get; set; }
        public byte[]? Photo { get; set; }
        public int Sale { get; set; }

        public Author Author { get; set; }
        public List<CompoundOrder> CompoundOrders { get; set; }
    }
}

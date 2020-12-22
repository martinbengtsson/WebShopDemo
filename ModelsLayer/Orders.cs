using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Orders
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public  IEnumerable<Product> Product { get; set; }
        public DateTime Datetime { get; set; }

    }
}

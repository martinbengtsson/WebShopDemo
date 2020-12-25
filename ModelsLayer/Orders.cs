using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual IEnumerable<Product> Product { get; set; }
        public DateTime Datetime { get; set; }

    }
}

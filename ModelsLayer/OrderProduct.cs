using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class OrderProduct
    {
        [Key]
        public int OrderProductId { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        [ForeignKey("OrderId")]
        public int OrderId { get; set; }

        public Orders order { get; set; }
        public Product product { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        public Product product { get; set; }
    }
}

using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryModel
{
   public interface IProductRepository
    {
    IEnumerable<Product> GetTopSellingProducts();
    }
}

using System.Collections.Generic;

namespace NetCoreMVCPractice.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products  { get;}
    }
}
using System.Collections.Generic;

namespace NetCoreMVCPractice.Models
{
    public class EFProductRepository : IProductRepository
    {
        private MyAppDbContext context { get; }

        public EFProductRepository(MyAppDbContext ctx)
        {
            context = ctx;
        }

        IEnumerable<Product> IProductRepository.Products => context.Products;
    }
}
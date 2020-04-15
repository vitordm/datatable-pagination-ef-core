using DataTablePaginationEFCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTablePaginationEFCore.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(DataTablePaginationEFCoreContext context) : base(context)
        {
            
        }
    }
}

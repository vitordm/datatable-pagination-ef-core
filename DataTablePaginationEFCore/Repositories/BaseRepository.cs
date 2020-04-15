using DataTablePaginationEFCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTablePaginationEFCore.Repositories
{
    public abstract class BaseRepository
    {
        protected DataTablePaginationEFCoreContext DbContext;

        public BaseRepository(DataTablePaginationEFCoreContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}

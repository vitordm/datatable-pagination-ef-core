using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTablePaginationEFCore.Context
{
    public class DataTablePaginationEFCoreContext : DbContext
    {
        public DataTablePaginationEFCoreContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        protected DataTablePaginationEFCoreContext()
        {
        }
    }
}

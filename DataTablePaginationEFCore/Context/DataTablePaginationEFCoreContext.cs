using DataTablePaginationEFCore.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#if DEBUG
            optionsBuilder.EnableSensitiveDataLogging();
#endif

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataTablePaginationEFCoreContext).Assembly);
        }
    }
}
